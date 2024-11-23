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
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection("Server=G™RKEM;Database=BaskanTicaret;Integrated Security=True;");
        SqlCommand command = new SqlCommand();
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'baskanTicaretDataSet3.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.baskanTicaretDataSet3.urun);
            // TODO: Bu kod satırı 'baskanTicaretDataSet2.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            RefreshProductList();
        }
        private void RefreshProductList()
        {

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.urun", con);
                SqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string urunKod = reader["urunkod"].ToString();
                    string urunTur = reader["uruntur"].ToString();
                    string aracSeri = reader["aracseri"].ToString();
                    string urunAltModel = reader["urunaltmodel"].ToString();
                    string urunUstModel = reader["urunustmodel"].ToString();
                    string urunDurum = reader["urundurum"].ToString();
                    string urunFiyat = reader["urunfiyat"].ToString();
                    string urunSutun = reader["urunsutun"].ToString();
                    string urunSatir = reader["urunsatir"].ToString();
                    string urunAdet = reader["urunadet"].ToString();

                    dataGridView1.Rows.Add(urunKod, urunTur, aracSeri, urunAltModel, urunUstModel, urunDurum, urunFiyat, urunSutun, urunSatir, urunAdet);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.urun WHERE aracseri LIKE @searchTerm", con);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                SqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string urunKod = reader["urunkod"].ToString();
                    string urunTur = reader["uruntur"].ToString();
                    string aracSeri = reader["aracseri"].ToString();
                    string urunAltModel = reader["urunaltmodel"].ToString();
                    string urunUstModel = reader["urunustmodel"].ToString();
                    string urunDurum = reader["urundurum"].ToString();
                    string urunFiyat = reader["urunfiyat"].ToString();
                    string urunSutun = reader["urunsutun"].ToString();
                    string urunSatir = reader["urunsatir"].ToString();
                    string urunAdet = reader["urunadet"].ToString();

                    dataGridView1.Rows.Add(urunKod, urunTur, aracSeri, urunAltModel, urunUstModel, urunDurum, urunFiyat, urunSutun, urunSatir, urunAdet);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanında arama yapılırken hata oluştu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
