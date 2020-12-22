namespace libraryManagement
{
    partial class FrmStudentReport
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
            this.studentbtn = new System.Windows.Forms.Button();
            this.studentlbl = new System.Windows.Forms.Label();
            this.slctbranchbtn = new System.Windows.Forms.Button();
            this.slctbranchlbl = new System.Windows.Forms.Label();
            this.branchcb = new System.Windows.Forms.ComboBox();
            this.panelbookreport = new System.Windows.Forms.Panel();
            this.WıevBookBaslık = new System.Windows.Forms.Label();
            this.Studenttb = new System.Windows.Forms.TextBox();
            this.panelbookreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentbtn
            // 
            this.studentbtn.Location = new System.Drawing.Point(536, 227);
            this.studentbtn.Margin = new System.Windows.Forms.Padding(5);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(82, 33);
            this.studentbtn.TabIndex = 22;
            this.studentbtn.Text = "View";
            this.studentbtn.UseVisualStyleBackColor = true;
            // 
            // studentlbl
            // 
            this.studentlbl.AutoSize = true;
            this.studentlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.studentlbl.Location = new System.Drawing.Point(481, 186);
            this.studentlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentlbl.Name = "studentlbl";
            this.studentlbl.Size = new System.Drawing.Size(180, 29);
            this.studentlbl.TabIndex = 21;
            this.studentlbl.Text = "Student Name :";
            this.studentlbl.Click += new System.EventHandler(this.slctpublbl_Click);
            // 
            // slctbranchbtn
            // 
            this.slctbranchbtn.Location = new System.Drawing.Point(63, 227);
            this.slctbranchbtn.Margin = new System.Windows.Forms.Padding(5);
            this.slctbranchbtn.Name = "slctbranchbtn";
            this.slctbranchbtn.Size = new System.Drawing.Size(82, 33);
            this.slctbranchbtn.TabIndex = 18;
            this.slctbranchbtn.Text = "View";
            this.slctbranchbtn.UseVisualStyleBackColor = true;
            // 
            // slctbranchlbl
            // 
            this.slctbranchlbl.AutoSize = true;
            this.slctbranchlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.slctbranchlbl.Location = new System.Drawing.Point(33, 186);
            this.slctbranchlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.slctbranchlbl.Name = "slctbranchlbl";
            this.slctbranchlbl.Size = new System.Drawing.Size(175, 29);
            this.slctbranchlbl.TabIndex = 19;
            this.slctbranchlbl.Text = "Select Branch :";
            // 
            // branchcb
            // 
            this.branchcb.FormattingEnabled = true;
            this.branchcb.Location = new System.Drawing.Point(218, 180);
            this.branchcb.Margin = new System.Windows.Forms.Padding(5);
            this.branchcb.Name = "branchcb";
            this.branchcb.Size = new System.Drawing.Size(218, 35);
            this.branchcb.TabIndex = 20;
            // 
            // panelbookreport
            // 
            this.panelbookreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panelbookreport.Controls.Add(this.WıevBookBaslık);
            this.panelbookreport.Location = new System.Drawing.Point(-2, 17);
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
            this.WıevBookBaslık.Location = new System.Drawing.Point(176, 0);
            this.WıevBookBaslık.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.WıevBookBaslık.Name = "WıevBookBaslık";
            this.WıevBookBaslık.Size = new System.Drawing.Size(629, 105);
            this.WıevBookBaslık.TabIndex = 2;
            this.WıevBookBaslık.Text = "STUDENT REPORT";
            this.WıevBookBaslık.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Studenttb
            // 
            this.Studenttb.Location = new System.Drawing.Point(669, 180);
            this.Studenttb.Name = "Studenttb";
            this.Studenttb.Size = new System.Drawing.Size(218, 34);
            this.Studenttb.TabIndex = 23;
            // 
            // FrmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.Studenttb);
            this.Controls.Add(this.studentbtn);
            this.Controls.Add(this.studentlbl);
            this.Controls.Add(this.slctbranchbtn);
            this.Controls.Add(this.slctbranchlbl);
            this.Controls.Add(this.branchcb);
            this.Controls.Add(this.panelbookreport);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmStudentReport";
            this.Text = "Student Report";
            this.panelbookreport.ResumeLayout(false);
            this.panelbookreport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Label studentlbl;
        private System.Windows.Forms.Button slctbranchbtn;
        private System.Windows.Forms.Label slctbranchlbl;
        private System.Windows.Forms.ComboBox branchcb;
        private System.Windows.Forms.Panel panelbookreport;
        private System.Windows.Forms.Label WıevBookBaslık;
        private System.Windows.Forms.TextBox Studenttb;
    }
}