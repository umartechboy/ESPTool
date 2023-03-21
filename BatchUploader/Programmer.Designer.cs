namespace BatchUploader
{
    partial class Programmer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.portTB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshB = new System.Windows.Forms.Button();
            this.consoleTB = new System.Windows.Forms.TextBox();
            this.beginB = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portTB
            // 
            this.portTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portTB.FormattingEnabled = true;
            this.portTB.Location = new System.Drawing.Point(39, 3);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(120, 23);
            this.portTB.TabIndex = 0;
            this.portTB.TextChanged += new System.EventHandler(this.portTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // refreshB
            // 
            this.refreshB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshB.Location = new System.Drawing.Point(165, 2);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(23, 24);
            this.refreshB.TabIndex = 2;
            this.refreshB.Text = "*";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // consoleTB
            // 
            this.consoleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTB.Location = new System.Drawing.Point(4, 88);
            this.consoleTB.Multiline = true;
            this.consoleTB.Name = "consoleTB";
            this.consoleTB.Size = new System.Drawing.Size(273, 181);
            this.consoleTB.TabIndex = 3;
            // 
            // beginB
            // 
            this.beginB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.beginB.Location = new System.Drawing.Point(194, 2);
            this.beginB.Name = "beginB";
            this.beginB.Size = new System.Drawing.Size(83, 80);
            this.beginB.TabIndex = 2;
            this.beginB.Text = "Begin";
            this.beginB.UseVisualStyleBackColor = true;
            this.beginB.Click += new System.EventHandler(this.beginB_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(4, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(130, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "--";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // Programmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.consoleTB);
            this.Controls.Add(this.beginB);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTB);
            this.Name = "Programmer";
            this.Size = new System.Drawing.Size(280, 272);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox portTB;
        private Label label1;
        private Button refreshB;
        private TextBox consoleTB;
        private Button beginB;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
    }
}
