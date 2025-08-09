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
            // İlk açılışta verileri yükle
            VerileriYukle(@"SELECT 
                ID,
                `ÜRÜN ADI` AS URUN_ADI,
                `BİRİM` AS BIRIM,
                `KATEGORİ` AS KATEGORI,
                `MİKTAR` AS MIKTAR
                FROM urun_tablo");

            // Başlıkları Türkçeleştir
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["URUN_ADI"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["BIRIM"].HeaderText = "Birim";
            dataGridView1.Columns["KATEGORI"].HeaderText = "Kategori";
            dataGridView1.Columns["MIKTAR"].HeaderText = "Miktar";

            // Sütun genişliklerini ayarla
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns["ID"].Width = 50;
            dataGridView1.Columns["URUN_ADI"].Width = 300;
            dataGridView1.Columns["BIRIM"].Width = 100;
            dataGridView1.Columns["KATEGORI"].Width = 150;
            dataGridView1.Columns["MIKTAR"].Width = 100;

            // Miktar sütununu gizle
            dataGridView1.Columns["MIKTAR"].Visible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // SQL Sorgusu ile DataGridView doldurma
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
            VerileriYukle(@"SELECT 
                ID,
                `ÜRÜN ADI` AS URUN_ADI,
                `BİRİM` AS BIRIM,
                `KATEGORİ` AS KATEGORI,
                `MİKTAR` AS MIKTAR
                FROM urun_tablo ORDER BY `ÜRÜN ADI` ASC");
        }
        private void btnSiralaID_Click(object sender, EventArgs e)
        {
            VerileriYukle(@"SELECT 
                ID,
                `ÜRÜN ADI` AS URUN_ADI,
                `BİRİM` AS BIRIM,
                `KATEGORİ` AS KATEGORI,
                `MİKTAR` AS MIKTAR
                FROM urun_tablo ORDER BY ID ASC");
        }
        private void btnSiralaZA_Click(object sender, EventArgs e)
        {
            VerileriYukle(@"SELECT 
                ID,
                `ÜRÜN ADI` AS URUN_ADI,
                `BİRİM` AS BIRIM,
                `KATEGORİ` AS KATEGORI,
                `MİKTAR` AS MIKTAR
                FROM urun_tablo ORDER BY `ÜRÜN ADI` DESC");
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim().Replace("'", "''");
            string sqlSorgusu = @"SELECT 
                ID,
                `ÜRÜN ADI` AS URUN_ADI,
                `BİRİM` AS BIRIM,
                `KATEGORİ` AS KATEGORI,
                `MİKTAR` AS MIKTAR
                FROM urun_tablo";

            if (!string.IsNullOrEmpty(aramaMetni))
            {
                sqlSorgusu += $" WHERE `ÜRÜN ADI` LIKE '%{aramaMetni}%' OR `KATEGORİ` LIKE '%{aramaMetni}%'";
            }
            VerileriYukle(sqlSorgusu);
        }
    }
}
