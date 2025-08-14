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
                                    ÜRÜN_ADI AS URUN_ADI, 
                                    BİRİM AS BIRIM, 
                                    KATEGORİ AS KATEGORI, 
                                    MİKTAR AS MIKTAR, 
                                    AD_SOYAD AS AD_SOYAD, 
                                    ALINAN_TARIH AS ALINAN_TARIH 
                                   FROM urun_alinan 
                                   ORDER BY ALINAN_TARIH DESC";

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
                MessageBox.Show("Veri çekme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAlinanUrunler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            dataGridView1.RowHeadersVisible = false; // Boş sütunu kaldır

            // Sütunların genişlik ayarı
            dataGridView1.Columns["KATEGORI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["BIRIM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ALINAN_TARIH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["MIKTAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["URUN_ADI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["AD_SOYAD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Hücre içindeki verilerin hizalaması
            dataGridView1.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BIRIM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["KATEGORI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["MIKTAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["AD_SOYAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ALINAN_TARIH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}