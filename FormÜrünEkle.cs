using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace İB_Stok_Takip
{
    public partial class FormÜrünEkle : Form
    {
        private readonly string baglantiDizesi = "Data Source=stok.db;Version=3;Encoding=UTF-8;";

        public FormÜrünEkle()
        {
            InitializeComponent();
        }

        private void FormÜrünEkle_Load(object sender, EventArgs e)
        {
            VerileriYukle("SELECT ID, ÜRÜN, KATEGORİ FROM urun_tablo");

            // DataGridView başlık ve stil ayarları
            if (dataGridView2.Columns.Count > 0)
            {
                dataGridView2.Columns["ID"].HeaderText = "ID";
                dataGridView2.Columns["ÜRÜN"].HeaderText = "Ürün Adı";
                dataGridView2.Columns["KATEGORİ"].HeaderText = "Kategori";
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
        }

        private void VerileriYukle(string sqlSorgusu)
        {
            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    using (SQLiteCommand komut = new SQLiteCommand(sqlSorgusu, baglanti))
                    using (SQLiteDataAdapter adaptor = new SQLiteDataAdapter(komut))
                    {
                        DataTable dt = new DataTable();
                        adaptor.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {

            string urunAdi = ad.Text.Trim();
            string kategori = katagori.SelectedItem?.ToString();
            string adetStr = adet.Text.Trim();

            if (string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(adetStr) || !int.TryParse(adetStr, out int adetDeger))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO urun_tablo (ÜRÜN, KATEGORİ, ADET) VALUES (@urun, @kategori, @adet)";
                    using (SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@urun", urunAdi);
                        komut.Parameters.AddWithValue("@kategori", kategori);
                        komut.Parameters.AddWithValue("@adet", adetDeger);
                        komut.ExecuteNonQuery();
                    }
                }

                // DataGridView'i yeniden yükle
                VerileriYukle("SELECT ID, ÜRÜN, KATEGORİ, ADET FROM urun_tablo");

                // Girişleri temizle
                ad.Clear();
                adet.Clear();
                katagori.SelectedIndex = 0;

                MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        


    }
}
}

