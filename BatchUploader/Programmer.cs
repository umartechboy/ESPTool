using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using ESPTool.Devices;
using ESPTool.Firmware;
using System.Diagnostics;

namespace BatchUploader
{
    public partial class Programmer : UserControl
    {
        Device dev = new Device();
        public event GetFilesEventHandler OnGetFilesRequest;
        public Programmer()
        {
            InitializeComponent();
            ParentChanged += refreshB_Click;
        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            portTB.Items.Clear();
            portTB.Items.AddRange(SerialPort.GetPortNames());
        }

        private void portTB_TextChanged(object sender, EventArgs e)
        {
            this.Parent.Text = portTB.Text;
            portName = portTB.Text;
        }
        void Log(string str, params object[] args)
        {
            this.Invoke(() => consoleTB.AppendText(
                "[" + DateTime.Now.ToString("hh:mm:ss.F") + "] " + string.Format(str + "\r\n", args)));
        } 
        Thread programmerThread = null;
        string portName = "";
        private void beginB_Click(object sender, EventArgs e)
        {
            if (programmerThread == null)
            {
                async Task<bool> Func()
                {
                    Log("Programmer thread started");
                    Log("Opening serial port: " + portName);
                    if (!(await dev.OpenSerial(portName, 115200)).Success)
                    {
                        Log("Could not open the port " + portName);
                        return false;
                    }

                    Log("Triggering bootloader with RTS/DTR");
                    if (!(await dev.EnterBootloader()).Success)
                    {
                        Log("ESP could not enter the bootloader.");
                        return false;
                    }

                    Log("Syncing...");
                    if (!(await dev.Sync()).Success)
                    {
                        Log("Sync failed. Check your connections.");
                        return false;
                    }

                    Log("Detecting chip type...");
                    var chipType = await dev.DetectChipType();
                    if (!(chipType).Success)
                    {
                        Log("Could not detect the chip type.");
                        return false;
                    }
                    else
                    {
                        if (chipType.Value == ChipTypes.ESP32)
                            dev = new ESP32(dev);
                        else
                        {
                            Log("Chip type {0} not supported.", chipType.Value);
                            return false;
                        }
                    }


                    var esp = (ESP32)dev;
                    Log("Uploading stubloader");
                    var suc = await esp.StartStubloader();
                    if (!suc.Success)
                    {
                        Log("Stubloader failed. Check your connections.");
                        return false;
                    }

                    Log("Changing baud rate to 912600");
                    if (!(await dev.ChangeBaud(921600)).Success)
                    {
                        Log("Operation failed. Check your connections.");
                        return false;
                    }

                    Log("Uploading firmware");

                    FirmwareImage image = new FirmwareImage();
                    image.Segments = new List<Segment>();
                    var files = new GetFilesRequestEventArgs();
                    OnGetFilesRequest(this, files);
                    foreach (string file in files.All)
                    {
                        FileInfo bin = new FileInfo(file);

                        UInt32 offset = 0;

                        switch (Path.GetFileNameWithoutExtension(file))
                        {

                            case "bootloader":
                                offset = 0x1000;
                                break;

                            case "Firmware":
                                offset = 0x10000;
                                break;
                            case "storage":
                                offset = 0x110000;
                                break;
                            case "partition-table":
                                offset = 0x8000;
                                break;

                        }

                        using (Stream stream = bin.OpenRead())
                        {
                            byte[] data = new byte[stream.Length];
                            stream.Read(data, 0, data.Length);


                            Segment seg = new Segment();
                            seg.Offset = offset;
                            seg.Data = data;

                            image.Segments.Add(seg);
                        }
                    }

                    var progress = new Progress<float>(prog =>
                    {
                        progressBar1.InvokeIfRequired(() => { progressBar1.Value = (int)(prog * 100); });
                    });

                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    suc = await esp.UploadToFLASHDeflated(image, false, default, progress);
                    sw.Stop();

                    if (!(await dev.ChangeBaud(921600)).Success)
                    {
                        Log("Upload failed. Try again...");
                        return false;
                    }
                    Log($"Total time taken {sw.ElapsedMilliseconds / 1000.0F:F1}s \r\n");
                    progress.repo

                    return true;
                }
                programmerThread = new Thread(async () =>
                {
                    Invoke(() => beginB.Text = "Abort");
                    var t = Func();
                    try
                    {
                        t.Wait();
                        Log("Prommer thread completed sussefully\r\n-------------------------\r\n\r\n");
                    }
                    catch (Exception ex)
                    {
                        Log("Programmer thread exited: {0}", ex.Message);
                        Log("Prommer thread failed to complete\r\n-------------------------\r\n\r\n");
                    }

                    programmerThread = null;
                    Invoke(() => beginB.Text = "Begin");
                });
                programmerThread.Start();
            }
            else
            {
                programmerThread.Interrupt();
            }
        }
    }

    public delegate void GetFilesEventHandler(object sender, GetFilesRequestEventArgs e);
    public class GetFilesRequestEventArgs : EventArgs
    {
        public string Firmware { get; set; }
        public string Storage { get; set; }
        public string Partitions { get; set; }
        public string[] All { get { return new string[] { Firmware, Storage, Partitions }; } }
    }
    public static class Helpers
    {
        private delegate void SafeCallDelegate<T>(T c, Action action);
        public static void InvokeIfRequired<T>(this T c, Action action) where T : Control
        {
            if (c.InvokeRequired)
            {
                c.Invoke(new SafeCallDelegate<T>(InvokeIfRequired), new object[] { c, action });
            }
            else
            {
                action();
            }
        }
    }

}
