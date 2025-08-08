using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormÜrünDüzenle : Form
    {
        private string connectionString = "Data Source=stok.db;Version=3;";
        private int seciliId = -1;
        public FormÜrünDüzenle()
        {
            InitializeComponent();
            
        }

        private void FormÜrünDüzenle_Load(object sender, EventArgs e)
        {
            comboBox_kategori.Items.AddRange(new string[] { "TONER" });
            ListeyiGetir();
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void ListeyiGetir()
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM urun_tablo";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                seciliId = Convert.ToInt32(row.Cells[0].Value);
                textBox_urunadi.Text = row.Cells["ÜRÜN"].Value.ToString();
                comboBox_kategori.SelectedItem = row.Cells["KATEGORİ"].Value.ToString();
                textBox_miktar.Text = row.Cells["MİKTARI"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

             if (seciliId == -1)
             {
                 MessageBox.Show("Lütfen güncellenecek ürünü seçin.");
                 return;
             }

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE urun_tablo SET ÜRÜN=@urun, KATEGORİ=@katagori, MİKTARI=@miktari WHERE ID=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@urun", textBox_urunadi.Text);
                    cmd.Parameters.AddWithValue("@katagori", comboBox_kategori.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@miktari", textBox_miktar.Text);
                    cmd.Parameters.AddWithValue("@id", seciliId);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Ürün başarıyla güncellendi!");
            ListeyiGetir();
        }
    }
}
