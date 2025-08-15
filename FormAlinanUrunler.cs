using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormAlinanUrunler : Form
    {
        private readonly string baglantiDizesi = "Data Source=stok.db;Version=3;";

        public FormAlinanUrunler()
        {
            InitializeComponent();
        }

        public void VerileriGetir()
        {
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tüm satırı seçme modu
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true; // Satırdaki herhangi bir hücreye tıklayınca tüm satırı seç
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gerekirse ek işlevsellik eklenebilir
        }


        private void ReindexIDs()
        {
            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    // Mevcut verileri al
                    string sql = "SELECT ÜRÜN_ADI, BİRİM, KATEGORİ, MİKTAR, AD_SOYAD, ALINAN_TARIH FROM urun_alinan ORDER BY ID";
                    using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                    {
                        using (SQLiteDataAdapter adaptor = new SQLiteDataAdapter(komut))
                        {
                            DataTable dt = new DataTable();
                            adaptor.Fill(dt);

                            // Geçici tablo oluştur
                            string createTempTable = "CREATE TABLE temp_urun_alinan (ID INTEGER PRIMARY KEY AUTOINCREMENT, ÜRÜN_ADI TEXT, BİRİM TEXT, KATEGORİ TEXT, MİKTAR INTEGER, AD_SOYAD TEXT, ALINAN_TARIH TEXT)";
                            using (SQLiteCommand cmd = new SQLiteCommand(createTempTable, baglanti))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            // Verileri yeni ID'lerle geçici tabloya ekle
                            foreach (DataRow row in dt.Rows)
                            {
                                string insertSql = "INSERT INTO temp_urun_alinan (ÜRÜN_ADI, BİRİM, KATEGORİ, MİKTAR, AD_SOYAD, ALINAN_TARIH) VALUES (@urunAdi, @birim, @kategori, @miktar, @adSoyad, @alinanTarih)";
                                using (SQLiteCommand insertCmd = new SQLiteCommand(insertSql, baglanti))
                                {
                                    insertCmd.Parameters.AddWithValue("@urunAdi", row["ÜRÜN_ADI"]);
                                    insertCmd.Parameters.AddWithValue("@birim", row["BİRİM"]);
                                    insertCmd.Parameters.AddWithValue("@kategori", row["KATEGORİ"]);
                                    insertCmd.Parameters.AddWithValue("@miktar", row["MİKTAR"]);
                                    insertCmd.Parameters.AddWithValue("@adSoyad", row["AD_SOYAD"]);
                                    insertCmd.Parameters.AddWithValue("@alinanTarih", row["ALINAN_TARIH"]);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }

                            // Eski tabloyu sil ve geçici tabloyu yeniden adlandır
                            using (SQLiteCommand cmd = new SQLiteCommand("DROP TABLE urun_alinan", baglanti))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            using (SQLiteCommand cmd = new SQLiteCommand("ALTER TABLE temp_urun_alinan RENAME TO urun_alinan", baglanti))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID yeniden sıralama hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var onay = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                    {
                        baglanti.Open();
                        string sql = "DELETE FROM urun_alinan WHERE ID = @id";
                        using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                        {
                            komut.Parameters.AddWithValue("@id", secilenID);
                            komut.ExecuteNonQuery();
                        }
                    }
                    ReindexIDs(); // ID'leri yeniden sırala
                    VerileriGetir(); // DataGridView'i güncelle

                    // Form1 ve FormÜrünleriListele açıksa güncelle
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Form1 form1)
                        {
                            form1.VerileriGetir();
                        }
                        else if (form is FormÜrünleriListele formListele)
                        {
                            formListele.VerileriYukle(@"SELECT 
                                ID,
                                ÜRÜN_ADI AS URUN_ADI,
                                BİRİM AS BIRIM,
                                KATEGORİ AS KATEGORI,
                                MİKTAR AS MIKTAR
                                FROM urun_tablo");
                        }
                    }
                    MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        PrintDocument printDocument = new PrintDocument();
        PrintDialog printDialog = new PrintDialog();
        int satirIndex = 0;
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int baslangicX = 50;
            int baslangicY = 50;
            int hucreYukseklik = 30;
            Font font = new Font("Arial", 9);
            Brush brush = Brushes.Black;
            StringFormat stringFormat = new StringFormat
            {
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.LineLimit
            };

            float[] sutunGenislikleri = new float[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                SizeF baslikBoyut = e.Graphics.MeasureString(dataGridView1.Columns[i].HeaderText, font);
                sutunGenislikleri[i] = Math.Max(baslikBoyut.Width, 60);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[i].Value != null)
                    {
                        SizeF veriBoyut = e.Graphics.MeasureString(row.Cells[i].Value.ToString(), font);
                        sutunGenislikleri[i] = Math.Max(sutunGenislikleri[i], veriBoyut.Width);
                    }
                }
            }

            // Toplam genişlik
            float toplamGenislik = sutunGenislikleri.Sum();
            float yazdirilabilirGenislik = e.MarginBounds.Width;
            float olcek = yazdirilabilirGenislik / toplamGenislik;

            // Başlıklar
            float currentX = baslangicX;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                float genislik = sutunGenislikleri[i] * olcek;
                RectangleF rect = new RectangleF(currentX, baslangicY, genislik, hucreYukseklik);
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, font, brush, rect, stringFormat);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect));
                currentX += genislik;
            }
            baslangicY += hucreYukseklik;

            // Satırlar
            while (satirIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[satirIndex];
                currentX = baslangicX;
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    float genislik = sutunGenislikleri[j] * olcek;
                    RectangleF rect = new RectangleF(currentX, baslangicY, genislik, hucreYukseklik);
                    if (row.Cells[j].Value != null)
                    {
                        e.Graphics.DrawString(row.Cells[j].Value.ToString(), font, brush, rect, stringFormat);
                    }
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect));
                    currentX += genislik;
                }
                satirIndex++;
                baslangicY += hucreYukseklik;

                if (baslangicY > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

    
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += PrintDocument1_PrintPage;
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                satirIndex = 0; // Her yazdırmada baştan başlasın
                printDocument.Print();
            }
        }

       
        
    }
}