namespace BatchUploader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firmwareTB = new System.Windows.Forms.TextBox();
            this.partitionsTB = new System.Windows.Forms.TextBox();
            this.storageTB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.programmersTC = new System.Windows.Forms.TabControl();
            this.programmersTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firmware";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Partitions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Storage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firmwareTB
            // 
            this.firmwareTB.Location = new System.Drawing.Point(79, 12);
            this.firmwareTB.Name = "firmwareTB";
            this.firmwareTB.Size = new System.Drawing.Size(319, 23);
            this.firmwareTB.TabIndex = 0;
            this.firmwareTB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.firmwareFiles_MouseDoubleClick);
            // 
            // partitionsTB
            // 
            this.partitionsTB.Location = new System.Drawing.Point(79, 41);
            this.partitionsTB.Name = "partitionsTB";
            this.partitionsTB.Size = new System.Drawing.Size(319, 23);
            this.partitionsTB.TabIndex = 1;
            this.partitionsTB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.firmwareFiles_MouseDoubleClick);
            // 
            // storageTB
            // 
            this.storageTB.Location = new System.Drawing.Point(79, 70);
            this.storageTB.Name = "storageTB";
            this.storageTB.Size = new System.Drawing.Size(319, 23);
            this.storageTB.TabIndex = 2;
            this.storageTB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.firmwareFiles_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // programmersTC
            // 
            this.programmersTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programmersTC.Controls.Add(this.tabPage2);
            this.programmersTC.Location = new System.Drawing.Point(12, 108);
            this.programmersTC.Name = "programmersTC";
            this.programmersTC.SelectedIndex = 0;
            this.programmersTC.Size = new System.Drawing.Size(394, 330);
            this.programmersTC.TabIndex = 3;
            this.programmersTC.SelectedIndexChanged += new System.EventHandler(this.programmersTC_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.programmersTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storageTB);
            this.Controls.Add(this.partitionsTB);
            this.Controls.Add(this.firmwareTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.programmersTC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox firmwareTB;
        private TextBox partitionsTB;
        private TextBox storageTB;
        private TabPage tabPage2;
        private TabControl programmersTC;
    }
}