namespace libraryManagement
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginlbl = new System.Windows.Forms.Label();
            this.passtb = new System.Windows.Forms.TextBox();
            this.passlb = new System.Windows.Forms.Label();
            this.idlb = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.idtb = new System.Windows.Forms.MaskedTextBox();
            this.StdPic = new System.Windows.Forms.PictureBox();
            this.AdmPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.loginlbl);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 100);
            this.panel1.TabIndex = 9;
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.loginlbl.Location = new System.Drawing.Point(360, -3);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(245, 105);
            this.loginlbl.TabIndex = 7;
            this.loginlbl.Text = "LOGIN";
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(354, 405);
            this.passtb.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(261, 34);
            this.passtb.TabIndex = 16;
            this.passtb.UseSystemPasswordChar = true;
            // 
            // passlb
            // 
            this.passlb.AutoSize = true;
            this.passlb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passlb.ForeColor = System.Drawing.SystemColors.Window;
            this.passlb.Location = new System.Drawing.Point(220, 411);
            this.passlb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passlb.Name = "passlb";
            this.passlb.Size = new System.Drawing.Size(129, 29);
            this.passlb.TabIndex = 15;
            this.passlb.Text = "Password:";
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idlb.ForeColor = System.Drawing.SystemColors.Window;
            this.idlb.Location = new System.Drawing.Point(284, 347);
            this.idlb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(49, 29);
            this.idlb.TabIndex = 14;
            this.idlb.Text = "ID:";
            // 
            // loginbtn
            // 
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginbtn.FlatAppearance.BorderSize = 3;
            this.loginbtn.Location = new System.Drawing.Point(486, 461);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(129, 43);
            this.loginbtn.TabIndex = 11;
            this.loginbtn.Text = "Log In";
            this.loginbtn.UseVisualStyleBackColor = true;
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(354, 341);
            this.idtb.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.idtb.Mask = "00000000000";
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(261, 34);
            this.idtb.TabIndex = 10;
            this.idtb.ValidatingType = typeof(int);
            // 
            // StdPic
            // 
            this.StdPic.Image = ((System.Drawing.Image)(resources.GetObject("StdPic.Image")));
            this.StdPic.Location = new System.Drawing.Point(498, 192);
            this.StdPic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StdPic.Name = "StdPic";
            this.StdPic.Size = new System.Drawing.Size(117, 113);
            this.StdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StdPic.TabIndex = 12;
            this.StdPic.TabStop = false;
            // 
            // AdmPic
            // 
            this.AdmPic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdmPic.Image = ((System.Drawing.Image)(resources.GetObject("AdmPic.Image")));
            this.AdmPic.Location = new System.Drawing.Point(354, 192);
            this.AdmPic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdmPic.Name = "AdmPic";
            this.AdmPic.Size = new System.Drawing.Size(114, 113);
            this.AdmPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdmPic.TabIndex = 13;
            this.AdmPic.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.passlb);
            this.Controls.Add(this.idlb);
            this.Controls.Add(this.StdPic);
            this.Controls.Add(this.AdmPic);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Label passlb;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.PictureBox StdPic;
        private System.Windows.Forms.PictureBox AdmPic;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.MaskedTextBox idtb;
    }
}