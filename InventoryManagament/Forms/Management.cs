using FontAwesome.Sharp;
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
    public partial class Management : Form
    {
        SqlConnection con = new SqlConnection("Server=G™RKEM;Database=BaskanTicaret;Integrated Security=True;");
        SqlCommand command = new SqlCommand();
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baskanTicaretDataSet4.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.baskanTicaretDataSet4.staff);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                AddingManagement addingmanagement = new AddingManagement();
                addingmanagement.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                addingmanagement.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                addingmanagement.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                addingmanagement.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                addingmanagement.button1.Enabled = false;
                addingmanagement.button2.Enabled = true;
                addingmanagement.textBox2.Enabled = false;

                addingmanagement.ShowDialog();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz ?", "Kullanıcı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    command = new SqlCommand("DELETE FROM dbo.staff WHERE id LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AddingManagement addingmanagement = new AddingManagement();
            addingmanagement.ShowDialog();
        }
    }
}
