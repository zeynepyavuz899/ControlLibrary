namespace libraryManagement
{
    partial class FrmBookReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelbookreport = new System.Windows.Forms.Panel();
            this.WıevBookBaslık = new System.Windows.Forms.Label();
            this.pubcb = new System.Windows.Forms.ComboBox();
            this.slctpubbtn = new System.Windows.Forms.Button();
            this.slctpublbl = new System.Windows.Forms.Label();
            this.slctbranchbtn = new System.Windows.Forms.Button();
            this.slctbranchlbl = new System.Windows.Forms.Label();
            this.branchcb = new System.Windows.Forms.ComboBox();
            this.panelbookreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbookreport
            // 
            this.panelbookreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panelbookreport.Controls.Add(this.WıevBookBaslık);
            this.panelbookreport.Location = new System.Drawing.Point(1, 17);
            this.panelbookreport.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panelbookreport.Name = "panelbookreport";
            this.panelbookreport.Size = new System.Drawing.Size(949, 100);
            this.panelbookreport.TabIndex = 1;
            this.panelbookreport.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbookreport_Paint);
            // 
            // WıevBookBaslık
            // 
            this.WıevBookBaslık.AutoSize = true;
            this.WıevBookBaslık.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WıevBookBaslık.ForeColor = System.Drawing.SystemColors.Window;
            this.WıevBookBaslık.Location = new System.Drawing.Point(255, -8);
            this.WıevBookBaslık.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.WıevBookBaslık.Name = "WıevBookBaslık";
            this.WıevBookBaslık.Size = new System.Drawing.Size(418, 105);
            this.WıevBookBaslık.TabIndex = 2;
            this.WıevBookBaslık.Text = "VIEW BOOK";
            // 
            // pubcb
            // 
            this.pubcb.FormattingEnabled = true;
            this.pubcb.Location = new System.Drawing.Point(699, 183);
            this.pubcb.Margin = new System.Windows.Forms.Padding(5);
            this.pubcb.Name = "pubcb";
            this.pubcb.Size = new System.Drawing.Size(218, 35);
            this.pubcb.TabIndex = 16;
            // 
            // slctpubbtn
            // 
            this.slctpubbtn.Location = new System.Drawing.Point(527, 227);
            this.slctpubbtn.Margin = new System.Windows.Forms.Padding(5);
            this.slctpubbtn.Name = "slctpubbtn";
            this.slctpubbtn.Size = new System.Drawing.Size(82, 33);
            this.slctpubbtn.TabIndex = 15;
            this.slctpubbtn.Text = "View";
            this.slctpubbtn.UseVisualStyleBackColor = true;
            // 
            // slctpublbl
            // 
            this.slctpublbl.AutoSize = true;
            this.slctpublbl.ForeColor = System.Drawing.SystemColors.Window;
            this.slctpublbl.Location = new System.Drawing.Point(471, 186);
            this.slctpublbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.slctpublbl.Name = "slctpublbl";
            this.slctpublbl.Size = new System.Drawing.Size(218, 29);
            this.slctpublbl.TabIndex = 14;
            this.slctpublbl.Text = "Select Publication :";
            // 
            // slctbranchbtn
            // 
            this.slctbranchbtn.Location = new System.Drawing.Point(66, 227);
            this.slctbranchbtn.Margin = new System.Windows.Forms.Padding(5);
            this.slctbranchbtn.Name = "slctbranchbtn";
            this.slctbranchbtn.Size = new System.Drawing.Size(82, 33);
            this.slctbranchbtn.TabIndex = 11;
            this.slctbranchbtn.Text = "View";
            this.slctbranchbtn.UseVisualStyleBackColor = true;
            // 
            // slctbranchlbl
            // 
            this.slctbranchlbl.AutoSize = true;
            this.slctbranchlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.slctbranchlbl.Location = new System.Drawing.Point(36, 186);
            this.slctbranchlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.slctbranchlbl.Name = "slctbranchlbl";
            this.slctbranchlbl.Size = new System.Drawing.Size(175, 29);
            this.slctbranchlbl.TabIndex = 12;
            this.slctbranchlbl.Text = "Select Branch :";
            // 
            // branchcb
            // 
            this.branchcb.FormattingEnabled = true;
            this.branchcb.Location = new System.Drawing.Point(221, 180);
            this.branchcb.Margin = new System.Windows.Forms.Padding(5);
            this.branchcb.Name = "branchcb";
            this.branchcb.Size = new System.Drawing.Size(218, 35);
            this.branchcb.TabIndex = 13;
            // 
            // FrmBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.pubcb);
            this.Controls.Add(this.slctpubbtn);
            this.Controls.Add(this.slctpublbl);
            this.Controls.Add(this.slctbranchbtn);
            this.Controls.Add(this.slctbranchlbl);
            this.Controls.Add(this.branchcb);
            this.Controls.Add(this.panelbookreport);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmBookReport";
            this.Text = "Book Report";
            this.panelbookreport.ResumeLayout(false);
            this.panelbookreport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbookreport;
        private System.Windows.Forms.Label WıevBookBaslık;
        private System.Windows.Forms.ComboBox pubcb;
        private System.Windows.Forms.Button slctpubbtn;
        private System.Windows.Forms.Label slctpublbl;
        private System.Windows.Forms.Button slctbranchbtn;
        private System.Windows.Forms.Label slctbranchlbl;
        private System.Windows.Forms.ComboBox branchcb;
    }
}