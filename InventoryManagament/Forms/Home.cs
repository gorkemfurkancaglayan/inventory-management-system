 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BaskanTicaret.Forms
{
    public partial class Home : Form
    {
        private string connectionString = "Server=G™RKEM;Database=BaskanTicaret;Integrated Security=True;";
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            UpdateChart();
            timer1.Start();
        }
        private void UpdateChart()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(CAST(urunadet as int)) FROM dbo.urun";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object urunCount = command.ExecuteScalar();
                    label5.Text = urunCount.ToString();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(CAST(urunadet as int)) FROM dbo.urun where uruntur = 'Çamurluk'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object camurlukCount = command.ExecuteScalar();
                    chart2.Series["Series1"].Points.AddXY("Toplam Çamurluk", camurlukCount);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(CAST(urunadet as int)) FROM dbo.urun where uruntur = 'Far'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object farCount = command.ExecuteScalar();
                    chart2.Series["Series1"].Points.AddXY("Toplam Far", farCount);
                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(CAST(urunadet as int)) FROM dbo.urun where uruntur = 'Jant'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object jantCount = command.ExecuteScalar();
                    chart2.Series["Series1"].Points.AddXY("Toplam Jant", jantCount);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label3.Text = DateTime.Now.ToString("dd MMM yyyy");
            label4.Text = DateTime.Now.ToString("dddd");
        }

    }
}


