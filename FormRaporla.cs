using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormRaporla : Form
    {
        private readonly string baglantiDizesi = "Data Source=stok.db;Version=3;";
        DataTable tumVeriler = null;
        int satirIndex = 0; // Print için satır takibi
        PrintDocument printDocument;
        PrintDialog printDialog;

        public FormRaporla()
        {
            InitializeComponent();

            // Print nesnelerini oluştur
            printDocument = new PrintDocument();
            printDialog = new PrintDialog();

            printDocument.PrintPage += PrintDocument1_PrintPage;

            btnRaporOlustur.Click += btnRaporOlustur_Click;
        }

        private void FormRaporla_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            // Ayın ilk günü
            dateTimePicker1.Value = new DateTime(bugun.Year, bugun.Month, 1);
            // Ayın son günü
            dateTimePicker2.Value = new DateTime(bugun.Year, bugun.Month, DateTime.DaysInMonth(bugun.Year, bugun.Month));

            // İlk filtreleme
            VerileriGetir();

            // Olayları bağla
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += DateTimePicker2_ValueChanged;

            // Tarih sınırları
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            Filtrele(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
            Filtrele(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
        }

        private void VerileriGetir()
        {
            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    string sql = @"
                        SELECT 
                            strftime('%Y-%m-%d', ALINAN_TARIH) AS Tarih,
                            AD_SOYAD AS [Alınan Kişi],
                            ÜRÜN_ADI AS [Ürün Adı],
                            MİKTAR AS [Miktar],
                            BİRİM AS [Birim],
                            KATEGORİ AS [Kategori]
                        FROM urun_alinan
                        ORDER BY ALINAN_TARIH ASC
                    ";
                    using (SQLiteDataAdapter adaptor = new SQLiteDataAdapter(sql, baglanti))
                    {
                        tumVeriler = new DataTable();
                        adaptor.Fill(tumVeriler);
                    }
                }

                dataGridView1.DataSource = tumVeriler;
                AyarlariUygula();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message, "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            Filtrele(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);

            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                satirIndex = 0;
                printDocument.Print();
            }
        }

        private void Filtrele(DateTime baslangic, DateTime bitis)
        {
            if (tumVeriler == null || tumVeriler.Rows.Count == 0)
                return;

            DateTime baslangicTarih = baslangic.Date;
            DateTime bitisTarih = bitis.Date;

            var filteredRows = tumVeriler.AsEnumerable()
                .Where(r =>
                {
                    DateTime tarih = DateTime.Parse(r.Field<string>("Tarih"));
                    return tarih >= baslangicTarih && tarih <= bitisTarih;
                });

            if (filteredRows.Any())
                dataGridView1.DataSource = filteredRows.CopyToDataTable();
            else
                dataGridView1.DataSource = null;

            AyarlariUygula();
        }

        private void AyarlariUygula()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int baslangicX = 20; // Kenarlardan boşluk
            int baslangicY = 50;
            int hucreYukseklik = 40; // Daha büyük font için
            Font font = new Font("Arial", 10);
            Font baslikFont = new Font("Arial", 11, FontStyle.Bold);
            Brush brush = Brushes.Black;
            StringFormat stringFormat = new StringFormat
            {
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.LineLimit
            };

            if (dataGridView1.Columns.Count == 0) return;

            // Tarih aralığı başlığı
            string tarihAraligiYazi = $"Tarih Aralığı: {dateTimePicker1.Value:dd.MM.yyyy} - {dateTimePicker2.Value:dd.MM.yyyy}";
            e.Graphics.DrawString(tarihAraligiYazi, baslikFont, brush, baslangicX, baslangicY);
            baslangicY += 50;

            // Kolon genişlikleri
            float[] sutunGenislikleri = new float[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                SizeF baslikBoyut = e.Graphics.MeasureString(dataGridView1.Columns[i].HeaderText, font);
                sutunGenislikleri[i] = Math.Max(baslikBoyut.Width, 80);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[i].Value != null)
                    {
                        SizeF veriBoyut = e.Graphics.MeasureString(row.Cells[i].Value.ToString(), font);
                        sutunGenislikleri[i] = Math.Max(sutunGenislikleri[i], veriBoyut.Width);
                    }
                }
            }

            float toplamGenislik = sutunGenislikleri.Sum();
            float yazdirilabilirGenislik = e.MarginBounds.Width; 
            float olcek = (yazdirilabilirGenislik / toplamGenislik) * 1.25f; 


            // Kolon başlıkları
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
                        e.Graphics.DrawString(row.Cells[j].Value.ToString(), font, brush, rect, stringFormat);

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
    }
}
