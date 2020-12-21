namespace libraryManagement
{
    partial class FrmPenalty
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
            this.WıevpenaltyBaslık = new System.Windows.Forms.Label();
            this.slctpenalty = new System.Windows.Forms.Button();
            this.lblslctpenalty = new System.Windows.Forms.Label();
            this.cbpenalty = new System.Windows.Forms.ComboBox();
            this.panelbookreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbookreport
            // 
            this.panelbookreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panelbookreport.Controls.Add(this.WıevpenaltyBaslık);
            this.panelbookreport.Location = new System.Drawing.Point(1, 17);
            this.panelbookreport.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panelbookreport.Name = "panelbookreport";
            this.panelbookreport.Size = new System.Drawing.Size(949, 100);
            this.panelbookreport.TabIndex = 2;
            // 
            // WıevpenaltyBaslık
            // 
            this.WıevpenaltyBaslık.AutoSize = true;
            this.WıevpenaltyBaslık.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WıevpenaltyBaslık.ForeColor = System.Drawing.SystemColors.Window;
            this.WıevpenaltyBaslık.Location = new System.Drawing.Point(265, 0);
            this.WıevpenaltyBaslık.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.WıevpenaltyBaslık.Name = "WıevpenaltyBaslık";
            this.WıevpenaltyBaslık.Size = new System.Drawing.Size(460, 105);
            this.WıevpenaltyBaslık.TabIndex = 2;
            this.WıevpenaltyBaslık.Text = "Penalty Form";
            // 
            // slctpenalty
            // 
            this.slctpenalty.Location = new System.Drawing.Point(559, 173);
            this.slctpenalty.Margin = new System.Windows.Forms.Padding(5);
            this.slctpenalty.Name = "slctpenalty";
            this.slctpenalty.Size = new System.Drawing.Size(108, 33);
            this.slctpenalty.TabIndex = 14;
            this.slctpenalty.Text = "Select ";
            this.slctpenalty.UseVisualStyleBackColor = true;
            // 
            // lblslctpenalty
            // 
            this.lblslctpenalty.AutoSize = true;
            this.lblslctpenalty.ForeColor = System.Drawing.SystemColors.Window;
            this.lblslctpenalty.Location = new System.Drawing.Point(44, 176);
            this.lblslctpenalty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblslctpenalty.Name = "lblslctpenalty";
            this.lblslctpenalty.Size = new System.Drawing.Size(271, 29);
            this.lblslctpenalty.TabIndex = 15;
            this.lblslctpenalty.Text = "Select User for Penalty :";
            // 
            // cbpenalty
            // 
            this.cbpenalty.FormattingEnabled = true;
            this.cbpenalty.Location = new System.Drawing.Point(321, 173);
            this.cbpenalty.Margin = new System.Windows.Forms.Padding(5);
            this.cbpenalty.Name = "cbpenalty";
            this.cbpenalty.Size = new System.Drawing.Size(218, 35);
            this.cbpenalty.TabIndex = 16;
            // 
            // FrmPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.slctpenalty);
            this.Controls.Add(this.lblslctpenalty);
            this.Controls.Add(this.cbpenalty);
            this.Controls.Add(this.panelbookreport);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmPenalty";
            this.Text = "Penalty";
            this.Load += new System.EventHandler(this.FrmPenalty_Load);
            this.panelbookreport.ResumeLayout(false);
            this.panelbookreport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelbookreport;
        private System.Windows.Forms.Label WıevpenaltyBaslık;
        private System.Windows.Forms.Button slctpenalty;
        private System.Windows.Forms.Label lblslctpenalty;
        private System.Windows.Forms.ComboBox cbpenalty;
    }
}