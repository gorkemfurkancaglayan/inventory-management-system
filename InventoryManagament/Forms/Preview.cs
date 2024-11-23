using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaskanTicaret.Forms
{
    public partial class Preview : Form
    {
        SqlConnection con = new SqlConnection("Server=G™RKEM;Database=BaskanTicaret;Integrated Security=True;");
        SqlCommand command = new SqlCommand();
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'baskanTicaretDataSet1.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.baskanTicaretDataSet1.urun);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Adding adding = new Adding();
            adding.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                Adding adding = new Adding();
                adding.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                adding.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                adding.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                adding.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                adding.textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                adding.comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                adding.textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                adding.comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                adding.comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                adding.numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                adding.button1.Enabled = false;
                adding.button2.Enabled = true;
                adding.textBox2.Enabled = false;

                adding.ShowDialog();
            }
            else if (colName == "delete")
            {
                if(MessageBox.Show("Ürünü silmek istediğinize emin misiniz ?", "Ürün Silme", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    command = new SqlCommand("DELETE FROM dbo.urun WHERE urunkod LIKE '"+ dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün başarıyla silindi.");
                }
            }
        }
    }
}
