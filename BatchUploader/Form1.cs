namespace BatchUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("files.txt"))
            {
                var files = File.ReadAllLines("files.txt").ToDictionary((file) => file.Split('=')[0], (file) => file.Split('=')[1]);
                foreach (var tb in new TextBox[] { firmwareTB, partitionsTB, storageTB })
                    if (files.ContainsKey(tb.Name))
                        tb.Text = files[tb.Name];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var tabs = File.ReadAllLines("tabs.txt").ToDictionary((tab) => tab.Split('=')[0], (file) => file.Split('=')[1]);
            //if (tabs.Count == 0)
                AddANewProgrammer();
            //foreach (var tab in tabs)
            //{
            //    AddANewProgrammer();
            //    //var tb = 
            //}
        }
        private void firmwareFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var tb = (TextBox)sender;
            var ofd = new OpenFileDialog();
            ofd.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {   
                tb.Text = ofd.FileName;
                if (!File.Exists("files.txt"))
                    File.WriteAllText("files.txt", "");
                var files = File.ReadAllLines("files.txt").ToDictionary((file) => file.Split('=')[0], (file) => file.Split('=')[1]);
                files[tb.Name] = tb.Text;
                File.WriteAllLines("files.txt", files.ToArray().Select(f => f.Key + "=" + f.Value));
            }
        }

        Programmer AddANewProgrammer()
        {
            var t = new TabPage();
            t.Text = "Programmer";
            programmersTC.TabPages.Insert(programmersTC.TabCount - 1, t);
            programmersTC.SelectedTab = t;
            var p = new Programmer() { Dock = DockStyle.Fill };
            p.OnGetFilesRequest += (s, e) =>
            {
                e.Partitions = partitionsTB.Text;
                e.Firmware = firmwareTB.Text;
                e.Storage = storageTB.Text;
            };
            t.Controls.Add(p);
            return p;
        }


        private void programmersTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (programmersTC.SelectedIndex == programmersTC.TabCount - 1)
                AddANewProgrammer();
        }
    }
}