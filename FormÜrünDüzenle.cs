using System;
using System.Data;
using System.Data.SQLite; // NuGet: System.Data.SQLite
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormÜrünDüzenle : Form
    {
        private string connectionString = "Data Source=stok.db;Version=3;";
        public int UrunID { get; set; } // Form1'den gelen ID

        public FormÜrünDüzenle()
        {
            InitializeComponent();
        }

        private void FormÜrünDüzenle_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
            UrunBilgileriniGetir();
        }

        // Combobox'a benzersiz kategorileri yükle
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

        // Seçilen ürünün bilgilerini TextBox ve ComboBox'a aktar
        private void UrunBilgileriniGetir()
        {
            using (var baglanti = new SQLiteConnection(connectionString))
            {
                baglanti.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM urun_tablo WHERE ID=@id", baglanti))
                {
                    cmd.Parameters.AddWithValue("@id", UrunID);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtUrunAdi.Text = dr["ÜRÜN ADI"].ToString();
                            txtBirim.Text = dr["BİRİM"].ToString();
                            cmbKategori.Text = dr["KATEGORİ"].ToString();
                            numericMiktar.Value = Convert.ToDecimal(dr["MİKTAR"]);
                        }
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var baglanti = new SQLiteConnection(connectionString))
            {
                baglanti.Open();
                using (var cmd = new SQLiteCommand(@"UPDATE urun_tablo 
                    SET `ÜRÜN ADI`=@urunAdi, `BİRİM`=@birim, `KATEGORİ`=@kategori, `MİKTAR`=@miktar
                    WHERE ID=@id", baglanti))
                {
                    cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                    cmd.Parameters.AddWithValue("@birim", txtBirim.Text);
                    cmd.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                    cmd.Parameters.AddWithValue("@miktar", numericMiktar.Value);
                    cmd.Parameters.AddWithValue("@id", UrunID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Ürün bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Kaydet butonu


    }
}
