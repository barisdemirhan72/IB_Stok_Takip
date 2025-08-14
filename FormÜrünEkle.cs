using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormÜrünEkle : Form
    {
        private string connectionString = "Data Source=stok.db;Version=3;";

        public FormÜrünEkle()
        {
            InitializeComponent();
            btnUrunEkle.Click += btnUrunEkle_Click;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text.Trim();
            string birim = cmbbirim.Text.Trim();
            string kategori = cmbKategori.Text.Trim();
            int miktar = (int)numericMiktar.Value;

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(birim) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string baglantiDizesi = "Data Source=stok.db;Version=3;";
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();

                    // En büyük ID'yi bul
                    int yeniID = 1;
                    using (SQLiteCommand komutMax = new SQLiteCommand("SELECT MAX(ID) FROM urun_tablo", baglanti))
                    {
                        object sonuc = komutMax.ExecuteScalar();
                        if (sonuc != DBNull.Value && sonuc != null)
                        {
                            yeniID = Convert.ToInt32(sonuc) + 1;
                        }
                    }

                    string insertSQL = @"INSERT INTO urun_tablo (ID, `ÜRÜN ADI`, `BİRİM`, `KATEGORİ`, `MİKTAR`) 
                                         VALUES (@id, @urunAdi, @birim, @kategori, @miktar)";

                    using (SQLiteCommand komutInsert = new SQLiteCommand(insertSQL, baglanti))
                    {
                        komutInsert.Parameters.AddWithValue("@id", yeniID);
                        komutInsert.Parameters.AddWithValue("@urunAdi", urunAdi);
                        komutInsert.Parameters.AddWithValue("@birim", birim);
                        komutInsert.Parameters.AddWithValue("@kategori", kategori);
                        komutInsert.Parameters.AddWithValue("@miktar", miktar);

                        komutInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KategorileriYukle()
        {
            using (var baglanti = new SQLiteConnection(connectionString))
            {
                baglanti.Open();
                using (var cmd = new SQLiteCommand("SELECT DISTINCT KATEGORİ FROM urun_tablo", baglanti))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbKategori.Items.Add(dr["KATEGORİ"].ToString());
                    }
                }
            }
        }

        private void birimleriYukle()
        {
            using (var baglanti = new SQLiteConnection(connectionString))
            {
                baglanti.Open();
                using (var cmd = new SQLiteCommand("SELECT DISTINCT BİRİM FROM urun_tablo", baglanti))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbbirim.Items.Add(dr["BİRİM"].ToString());
                    }
                }
            }
        }
        private void FormÜrünEkle_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
            birimleriYukle();
            
        }
    }
}
