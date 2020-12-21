namespace libraryManagement
{
    partial class FrmReturnBook
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
            this.pubcb = new System.Windows.Forms.ComboBox();
            this.slctpublbl = new System.Windows.Forms.Label();
            this.buttonselect = new System.Windows.Forms.Button();
            this.slctbranchlbl = new System.Windows.Forms.Label();
            this.branchcb = new System.Windows.Forms.ComboBox();
            this.panelbookreport = new System.Windows.Forms.Panel();
            this.WıevBookBaslık = new System.Windows.Forms.Label();
            this.panelbookreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pubcb
            // 
            this.pubcb.FormattingEnabled = true;
            this.pubcb.Location = new System.Drawing.Point(647, 173);
            this.pubcb.Margin = new System.Windows.Forms.Padding(5);
            this.pubcb.Name = "pubcb";
            this.pubcb.Size = new System.Drawing.Size(218, 35);
            this.pubcb.TabIndex = 23;
            // 
            // slctpublbl
            // 
            this.slctpublbl.AutoSize = true;
            this.slctpublbl.ForeColor = System.Drawing.SystemColors.Window;
            this.slctpublbl.Location = new System.Drawing.Point(487, 179);
            this.slctpublbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.slctpublbl.Name = "slctpublbl";
            this.slctpublbl.Size = new System.Drawing.Size(150, 29);
            this.slctpublbl.TabIndex = 21;
            this.slctpublbl.Text = "Select Book :";
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(419, 235);
            this.buttonselect.Margin = new System.Windows.Forms.Padding(5);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(115, 33);
            this.buttonselect.TabIndex = 18;
            this.buttonselect.Text = "Select";
            this.buttonselect.UseVisualStyleBackColor = true;
            // 
            // slctbranchlbl
            // 
            this.slctbranchlbl.AutoSize = true;
            this.slctbranchlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.slctbranchlbl.Location = new System.Drawing.Point(36, 179);
            this.slctbranchlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.slctbranchlbl.Name = "slctbranchlbl";
            this.slctbranchlbl.Size = new System.Drawing.Size(183, 29);
            this.slctbranchlbl.TabIndex = 19;
            this.slctbranchlbl.Text = "Select Student  :";
            // 
            // branchcb
            // 
            this.branchcb.FormattingEnabled = true;
            this.branchcb.Location = new System.Drawing.Point(221, 173);
            this.branchcb.Margin = new System.Windows.Forms.Padding(5);
            this.branchcb.Name = "branchcb";
            this.branchcb.Size = new System.Drawing.Size(218, 35);
            this.branchcb.TabIndex = 20;
            // 
            // panelbookreport
            // 
            this.panelbookreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panelbookreport.Controls.Add(this.WıevBookBaslık);
            this.panelbookreport.Location = new System.Drawing.Point(1, 10);
            this.panelbookreport.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panelbookreport.Name = "panelbookreport";
            this.panelbookreport.Size = new System.Drawing.Size(949, 100);
            this.panelbookreport.TabIndex = 17;
            // 
            // WıevBookBaslık
            // 
            this.WıevBookBaslık.AutoSize = true;
            this.WıevBookBaslık.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WıevBookBaslık.ForeColor = System.Drawing.SystemColors.Window;
            this.WıevBookBaslık.Location = new System.Drawing.Point(82, -5);
            this.WıevBookBaslık.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.WıevBookBaslık.Name = "WıevBookBaslık";
            this.WıevBookBaslık.Size = new System.Drawing.Size(726, 105);
            this.WıevBookBaslık.TabIndex = 2;
            this.WıevBookBaslık.Text = "BOOK RETURN FORM";
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.pubcb);
            this.Controls.Add(this.slctpublbl);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.slctbranchlbl);
            this.Controls.Add(this.branchcb);
            this.Controls.Add(this.panelbookreport);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmReturnBook";
            this.Text = "Return Book";
            this.panelbookreport.ResumeLayout(false);
            this.panelbookreport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pubcb;
        private System.Windows.Forms.Label slctpublbl;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Label slctbranchlbl;
        private System.Windows.Forms.ComboBox branchcb;
        private System.Windows.Forms.Panel panelbookreport;
        private System.Windows.Forms.Label WıevBookBaslık;
    }
}