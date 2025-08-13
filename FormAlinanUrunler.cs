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
            dataGridView1.RowHeadersVisible= false;//boş stun kaldırıldı

			//stunların genişlik ayarı;   

			dataGridView1.Columns["KATEGORI"].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells;//HÜCRE İÇİNDEKİ VERİYE GÖRE OLUŞUR
            dataGridView1.Columns["BIRIM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["ID"].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells; 
            dataGridView1.Columns["ALINAN_TARIH"].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["MIKTAR"].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["URUN_ADI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//BOŞTA KALAN ALANA SIĞACAK ŞEKİLDE AYARLANIR
            dataGridView1.Columns["AD_SOYAD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			//hücre içindeki verilerin hücre içindeki konumu

			dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//ındexlerin konumu
			dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//birimlerin konumu
			dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//kategori konumu(emin olamadım duruma göre değiştirilebiliriz)
			dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//miktarların konumu
			dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//tarih konumu

			dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//başlık kımının yazı konumu


		}
	}
}
