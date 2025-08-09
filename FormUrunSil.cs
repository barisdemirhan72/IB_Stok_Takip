using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormUrunSil : Form
    {
        private int UrunID;
        private string UrunAdi;
        private string Birim;
        private string Kategori;
        private int Miktar;

        public FormUrunSil(int id, string urunAdi, string birim, string kategori, int miktar)
        {
            InitializeComponent();
            UrunID = id;
            UrunAdi = urunAdi;
            Birim = birim;
            Kategori = kategori;
            Miktar = miktar;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (radioSadeceSil.Checked)
            {
                // Ürünü urun_tablo'dan sil
                SilUrun();
            }
            else if (radioBaskaAdinaAldir.Checked)
            {
                string adSoyad = txtAdSoyad.Text.Trim();
                if (string.IsNullOrEmpty(adSoyad))
                {
                    MessageBox.Show("Lütfen ürün alan kişinin adını soyadını giriniz.");
                    return;
                }
                BaskaAdinaAldir(adSoyad);
            }
        }

        private void SilUrun()
        {
            try
            {
                string baglantiDizesi = "Data Source=stok.db;Version=3;";
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    string sql = "DELETE FROM urun_tablo WHERE ID = @id";
                    using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", UrunID);
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başarıyla silindi.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        private void BaskaAdinaAldir(string adSoyad)
        {
            try
            {
                string baglantiDizesi = "Data Source=stok.db;Version=3;";
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();

                    // 1) Ürünü urun_tablo'dan sil
                    string deleteSQL = "DELETE FROM urun_tablo WHERE ID = @id";
                    using (SQLiteCommand komutDelete = new SQLiteCommand(deleteSQL, baglanti))
                    {
                        komutDelete.Parameters.AddWithValue("@id", UrunID);
                        komutDelete.ExecuteNonQuery();
                    }

                    // 2) urun_alinan tablosuna kayıt ekle
                    string insertSQL = @"INSERT INTO urun_alinan 
                        (ID, `ÜRÜN ADI`, `BİRİM`, `KATEGORİ`, `MİKTAR`, `AD SOYAD`, `ALINAN TARİH`) 
                        VALUES (@id, @urunAdi, @birim, @kategori, @miktar, @adSoyad, @alınanTarih)";

                    using (SQLiteCommand komutInsert = new SQLiteCommand(insertSQL, baglanti))
                    {
                        komutInsert.Parameters.AddWithValue("@id", UrunID);
                        komutInsert.Parameters.AddWithValue("@urunAdi", UrunAdi);
                        komutInsert.Parameters.AddWithValue("@birim", Birim);
                        komutInsert.Parameters.AddWithValue("@kategori", Kategori);
                        komutInsert.Parameters.AddWithValue("@miktar", Miktar);
                        komutInsert.Parameters.AddWithValue("@adSoyad", adSoyad);
                        komutInsert.Parameters.AddWithValue("@alınanTarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        komutInsert.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Ürün başkası adına aldırıldı ve silindi.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında hata oluştu: " + ex.Message);
            }
        }

        private void radioBaskaAdinaAldir_CheckedChanged(object sender, EventArgs e)
        {
            txtAdSoyad.Enabled = radioBaskaAdinaAldir.Checked;
        }

        private void FormUrunSil_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Enabled = false; // Başlangıçta devre dışı
            radioSadeceSil.Checked = true; // Varsayılan seçim
        }


    }
}
