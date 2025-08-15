using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormÜrünleriListele : Form
    {
        private readonly string baglantiDizesi = "Data Source=stok.db;Version=3;Encoding=UTF-8;";

        public FormÜrünleriListele()
        {
            InitializeComponent();
            // RJButton event bağlama
            btnSiralaAZ.Click += btnSiralaAZ_Click;
            btnSiralaID.Click += btnSiralaID_Click;
            btnSiralaZA.Click += btnSiralaZA_Click;
        }

        private void FormÜrünleriListele_Load(object sender, EventArgs e)
        {
            // İlk açılışta verileri yükle
            VerileriYukle(@"SELECT 
                ID,
                ÜRÜN_ADI AS URUN_ADI,
                BİRİM AS BIRIM,
                KATEGORİ AS KATEGORI,
                MİKTAR AS MIKTAR
                FROM urun_tablo");

            // Başlıkları Türkçeleştir
            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["URUN_ADI"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["BIRIM"].HeaderText = "Birim";
            dataGridView1.Columns["KATEGORI"].HeaderText = "Kategori";
            dataGridView1.Columns["MIKTAR"].HeaderText = "Miktar";

            // Sütun genişliklerini ayarla
            dataGridView1.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["URUN_ADI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["BIRIM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["KATEGORI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["MIKTAR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Hücre içindeki verilerin hizalaması
            dataGridView1.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BIRIM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["KATEGORI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["MIKTAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersVisible = false; // İlk (boş) sütunu kaldır
            dataGridView1.Columns["MIKTAR"].Visible = false; // Miktar sütununu gizle
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // SQL Sorgusu ile DataGridView doldurma
        public void VerileriYukle(string sqlSorgusu)
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
                ÜRÜN_ADI AS URUN_ADI,
                BİRİM AS BIRIM,
                KATEGORİ AS KATEGORI,
                MİKTAR AS MIKTAR
                FROM urun_tablo ORDER BY ÜRÜN_ADI ASC");
        }

        private void btnSiralaID_Click(object sender, EventArgs e)
        {
            VerileriYukle(@"SELECT 
                ID,
                ÜRÜN_ADI AS URUN_ADI,
                BİRİM AS BIRIM,
                KATEGORİ AS KATEGORI,
                MİKTAR AS MIKTAR
                FROM urun_tablo ORDER BY ID ASC");
        }

        private void btnSiralaZA_Click(object sender, EventArgs e)
        {
            VerileriYukle(@"SELECT 
                ID,
                ÜRÜN_ADI AS URUN_ADI,
                BİRİM AS BIRIM,
                KATEGORİ AS KATEGORI,
                MİKTAR AS MIKTAR
                FROM urun_tablo ORDER BY ÜRÜN_ADI DESC");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim().Replace("'", "''");
            string sqlSorgusu = @"SELECT 
                ID,
                ÜRÜN_ADI AS URUN_ADI,
                BİRİM AS BIRIM,
                KATEGORİ AS KATEGORI,
                MİKTAR AS MIKTAR
                FROM urun_tablo";

            if (!string.IsNullOrEmpty(aramaMetni))
            {
                sqlSorgusu += $" WHERE ÜRÜN_ADI LIKE '%{aramaMetni}%' OR KATEGORİ LIKE '%{aramaMetni}%'";
            }
            VerileriYukle(sqlSorgusu);
        }
    }
}