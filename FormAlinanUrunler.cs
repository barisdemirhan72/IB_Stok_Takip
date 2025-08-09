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
    public partial class FormAlinanUrunler : Form
    {
        public FormAlinanUrunler()
        {
            InitializeComponent();
        }

        private void VerileriGetir()
        {
            string baglantiDizesi = "Data Source=stok.db;Version=3;";
            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();

                    string sql = @"SELECT 
                                    ID, 
                                    `ÜRÜN ADI` AS URUN_ADI, 
                                    `BİRİM` AS BIRIM, 
                                    `KATEGORİ` AS KATEGORI, 
                                    `MİKTAR` AS MIKTAR, 
                                    `AD SOYAD` AS AD_SOYAD, 
                                    `ALINAN TARİH` AS ALINAN_TARIH 
                                   FROM urun_alinan 
                                   ORDER BY `ALINAN TARİH` DESC";

                    using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                    {
                        using (SQLiteDataAdapter adaptor = new SQLiteDataAdapter(komut))
                        {
                            DataTable dt = new DataTable();
                            adaptor.Fill(dt);
                            dataGridView1.DataSource = dt;

                            // Opsiyonel: Kolon genişlik ayarları
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
        }
        private void FormAlinanUrunler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
    }
}
