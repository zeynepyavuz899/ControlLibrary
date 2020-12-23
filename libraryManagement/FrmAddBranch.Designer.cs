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
            this.txtName = new System.Windows.Forms.TextBox();
            this.addbranchbtn = new System.Windows.Forms.Button();
            this.branchnamelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 34);
            this.txtName.TabIndex = 5;
            // 
            // addbranchbtn
            // 
            this.addbranchbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addbranchbtn.Location = new System.Drawing.Point(541, 73);
            this.addbranchbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addbranchbtn.Name = "addbranchbtn";
            this.addbranchbtn.Size = new System.Drawing.Size(116, 39);
            this.addbranchbtn.TabIndex = 6;
            this.addbranchbtn.Text = "Add ";
            this.addbranchbtn.UseVisualStyleBackColor = true;
            this.addbranchbtn.Click += new System.EventHandler(this.addbranchbtn_Click);
            // 
            // branchnamelbl
            // 
            this.branchnamelbl.AutoSize = true;
            this.branchnamelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.branchnamelbl.Location = new System.Drawing.Point(54, 83);
            this.branchnamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.branchnamelbl.Name = "branchnamelbl";
            this.branchnamelbl.Size = new System.Drawing.Size(178, 29);
            this.branchnamelbl.TabIndex = 7;
            this.branchnamelbl.Text = "Branch Name :";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(541, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(541, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.branchnamelbl);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.addbranchbtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(111, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 230);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branch Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(111, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 109);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // FrmAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmAddBranch";
            this.Text = "Add Branch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addbranchbaslık;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button addbranchbtn;
        private System.Windows.Forms.Label branchnamelbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}