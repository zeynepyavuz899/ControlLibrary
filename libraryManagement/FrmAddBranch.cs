using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryManagement
{
    public partial class FrmAddBranch : Form
    {
        public FrmAddBranch()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbranchbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Categorie (CategorieName) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Successfull");
            txtName.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label2 = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtName = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Categorie Where CategorieID=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", label2);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Deleted");
            txtName.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Categorie Set CategorieName=@k2 Where CategorieID=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", label2);
            komut.Parameters.AddWithValue("@k2", txtName.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Updated");
            txtName.Clear();
        }
    }
}
