using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormÜrünleriListele : Form
    {
        private readonly string baglantiDizesi = "Data Source=stok.db;Version=3;Encoding=UTF-8;";

        public FormÜrünleriListele()
        {
            InitializeComponent();
        }

        private void FormÜrünleriListele_Load(object sender, EventArgs e)
        {
            VerileriYukle("SELECT ID, `ÜRÜN ADI`, `KATEGORİ` FROM urun_tablo");

            // DataGridView sütun başlıklarını Türkçeleştir
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ÜRÜN ADI"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["KATEGORİ"].HeaderText = "Kategori";

            // DataGridView stil ayarları
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // SQL Sorgusu fonksiyonu
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
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSiralaAZ_Click(object sender, EventArgs e)
        {
            VerileriYukle("SELECT ID, `ÜRÜN ADI`, `KATEGORİ` FROM urun_tablo ORDER BY `ÜRÜN ADI` ASC");
        }

        private void btnSiralaID_Click(object sender, EventArgs e)
        {
            VerileriYukle("SELECT ID, `ÜRÜN ADI`, `KATEGORİ` FROM urun_tablo ORDER BY ID ASC");
        }

        private void btnSiralaZA_Click(object sender, EventArgs e)
        {
            VerileriYukle("SELECT ID, `ÜRÜN ADI`, `KATEGORİ` FROM urun_tablo ORDER BY `ÜRÜN ADI` DESC");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim().Replace("'", "''"); // SQL enjeksiyonunu önlemek için
            string sqlSorgusu = "SELECT ID, `ÜRÜN ADI`, `KATEGORİ` FROM urun_tablo";

            if (!string.IsNullOrEmpty(aramaMetni))
            {
                sqlSorgusu += $" WHERE `ÜRÜN ADI` LIKE '%{aramaMetni}%' OR `KATEGORİ` LIKE '%{aramaMetni}%'";
            }

            VerileriYukle(sqlSorgusu);
        }
    }
}
