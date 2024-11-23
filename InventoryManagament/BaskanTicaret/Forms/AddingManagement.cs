using FontAwesome.Sharp;
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
    public partial class AddingManagement : Form
    {
        SqlConnection con = new SqlConnection("Server=G™RKEM;Database=BaskanTicaret;Integrated Security=True;");
        SqlCommand command = new SqlCommand();
        public AddingManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu Kullanıcıyı eklemek istediğinize emin misiniz ?", "Kullanıcı Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO dbo.staff(id, username, password, rank)VALUES(@id, @username, @password, @rank)", con);
                    command.Parameters.AddWithValue("@id", textBox2.Text);
                    command.Parameters.AddWithValue("@username", textBox1.Text);
                    command.Parameters.AddWithValue("@password", textBox3.Text);
                    command.Parameters.AddWithValue("@rank", textBox4.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu Kullanıcıyı güncellemek istediğinize emin misiniz ?", "Kullanıcı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("UPDATE dbo.staff SET username = @username, password = @password, rank = @rank WHERE username LIKE '" + textBox1.Text + "'", con);
                    command.Parameters.AddWithValue("@username", textBox1.Text);
                    command.Parameters.AddWithValue("@password", textBox3.Text);
                    command.Parameters.AddWithValue("@rank", textBox4.Text);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
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
