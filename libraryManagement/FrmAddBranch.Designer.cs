namespace libraryManagement
{
    partial class FrmAddBranch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbranchbaslık = new System.Windows.Forms.Label();
            this.addbranchcont = new System.Windows.Forms.Label();
            this.addbranchtb = new System.Windows.Forms.TextBox();
            this.addbranchbtn = new System.Windows.Forms.Button();
            this.branchnamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.addbranchbaslık);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 100);
            this.panel1.TabIndex = 1;
            // 
            // addbranchbaslık
            // 
            this.addbranchbaslık.AutoSize = true;
            this.addbranchbaslık.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addbranchbaslık.ForeColor = System.Drawing.SystemColors.Window;
            this.addbranchbaslık.Location = new System.Drawing.Point(229, 0);
            this.addbranchbaslık.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.addbranchbaslık.Name = "addbranchbaslık";
            this.addbranchbaslık.Size = new System.Drawing.Size(509, 105);
            this.addbranchbaslık.TabIndex = 2;
            this.addbranchbaslık.Text = "ADD BRANCH ";
            // 
            // addbranchcont
            // 
            this.addbranchcont.AutoSize = true;
            this.addbranchcont.Location = new System.Drawing.Point(441, 286);
            this.addbranchcont.Name = "addbranchcont";
            this.addbranchcont.Size = new System.Drawing.Size(78, 29);
            this.addbranchcont.TabIndex = 8;
            this.addbranchcont.Text = "label3";
            // 
            // addbranchtb
            // 
            this.addbranchtb.Location = new System.Drawing.Point(433, 187);
            this.addbranchtb.Margin = new System.Windows.Forms.Padding(5);
            this.addbranchtb.Name = "addbranchtb";
            this.addbranchtb.Size = new System.Drawing.Size(223, 34);
            this.addbranchtb.TabIndex = 5;
            // 
            // addbranchbtn
            // 
            this.addbranchbtn.Location = new System.Drawing.Point(433, 231);
            this.addbranchbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addbranchbtn.Name = "addbranchbtn";
            this.addbranchbtn.Size = new System.Drawing.Size(155, 39);
            this.addbranchbtn.TabIndex = 6;
            this.addbranchbtn.Text = "Add Branch";
            this.addbranchbtn.UseVisualStyleBackColor = true;
            // 
            // branchnamelbl
            // 
            this.branchnamelbl.AutoSize = true;
            this.branchnamelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.branchnamelbl.Location = new System.Drawing.Point(245, 190);
            this.branchnamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.branchnamelbl.Name = "branchnamelbl";
            this.branchnamelbl.Size = new System.Drawing.Size(178, 29);
            this.branchnamelbl.TabIndex = 7;
            this.branchnamelbl.Text = "Branch Name :";
            // 
            // FrmAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.addbranchcont);
            this.Controls.Add(this.addbranchtb);
            this.Controls.Add(this.addbranchbtn);
            this.Controls.Add(this.branchnamelbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmAddBranch";
            this.Text = "Add Branch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addbranchbaslık;
        private System.Windows.Forms.Label addbranchcont;
        private System.Windows.Forms.TextBox addbranchtb;
        private System.Windows.Forms.Button addbranchbtn;
        private System.Windows.Forms.Label branchnamelbl;
    }
}