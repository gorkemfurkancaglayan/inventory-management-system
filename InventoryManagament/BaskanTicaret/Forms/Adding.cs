using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaskanTicaret.Forms
{
    public partial class Adding : Form
    {
        SqlConnection  con = new SqlConnection("Server=G™RKEM;Database=BaskanTicaret;Integrated Security=True;");
        SqlCommand command = new SqlCommand();

        public Adding()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelAddingtitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu ürünü eklemek istediğinize emin misiniz ?", "Ürün Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO dbo.urun(urunkod, uruntur, aracseri, urunaltmodel, urunustmodel, urundurum, urunfiyat, urunsutun, urunsatir, urunadet)VALUES(@urunkod, @uruntur, @aracseri, @urunaltmodel, @urunustmodel, @urundurum, @urunfiyat, @urunsutun, @urunsatir, @urunadet)", con);
                    command.Parameters.AddWithValue("@urunkod", textBox2.Text);
                    command.Parameters.AddWithValue("@uruntur", textBox1.Text);
                    command.Parameters.AddWithValue("@aracseri", textBox3.Text);
                    command.Parameters.AddWithValue("@urunaltmodel", textBox4.Text);
                    command.Parameters.AddWithValue("@urunustmodel", textBox5.Text);
                    command.Parameters.AddWithValue("@urundurum", comboBox1.Text);
                    command.Parameters.AddWithValue("@urunfiyat", textBox7.Text);
                    command.Parameters.AddWithValue("@urunsutun", comboBox2.Text);
                    command.Parameters.AddWithValue("@urunsatir", comboBox3.Text);
                    command.Parameters.AddWithValue("@urunadet", numericUpDown1.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün başarıyla eklendi.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu ürünü güncellemek istediğinize emin misiniz ?", "Ürün Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("UPDATE dbo.urun SET uruntur = @uruntur, aracseri = @aracseri, urunaltmodel = @urunaltmodel, urunustmodel = @urunustmodel, urundurum = @urundurum, urunfiyat = @urunfiyat, urunsutun = @urunsutun, urunsatir = @urunsatir, urunadet = @urunadet WHERE uruntur LIKE '" + textBox1.Text + "'", con);
                    command.Parameters.AddWithValue("@uruntur", textBox1.Text);
                    command.Parameters.AddWithValue("@aracseri", textBox3.Text);
                    command.Parameters.AddWithValue("@urunaltmodel", textBox4.Text);
                    command.Parameters.AddWithValue("@urunustmodel", textBox5.Text);
                    command.Parameters.AddWithValue("@urundurum", comboBox1.Text);
                    command.Parameters.AddWithValue("@urunfiyat", textBox7.Text);
                    command.Parameters.AddWithValue("@urunsutun", comboBox2.Text);
                    command.Parameters.AddWithValue("@urunsatir", comboBox3.Text);
                    command.Parameters.AddWithValue("@urunadet", numericUpDown1.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün başarıyla güncellendi.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
