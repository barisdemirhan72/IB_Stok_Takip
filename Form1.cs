using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İB_Stok_Takip
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void VerileriGetir(string aramaMetni = "")
        {
            string baglantiDizesi = "Data Source=stok.db;Version=3;";
            try
            {
                using (SQLiteConnection baglanti = new SQLiteConnection(baglantiDizesi))
                {
                    baglanti.Open();

                    string sql = "SELECT * FROM urun_tablo";

                    if (!string.IsNullOrEmpty(aramaMetni))
                    {
                        sql += " WHERE `ÜRÜN ADI` LIKE @arama OR `KATEGORİ` LIKE @arama";
                    }

                    using (SQLiteCommand komut = new SQLiteCommand(sql, baglanti))
                    {
                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            komut.Parameters.AddWithValue("@arama", "%" + aramaMetni + "%");
                        }

                        using (SQLiteDataAdapter adaptor = new SQLiteDataAdapter(komut))
                        {
                            DataTable dt = new DataTable();
                            adaptor.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına Bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            VerileriGetir();

            // Manuel genişlikler
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns["ID"].Width = 50;
            dataGridView1.Columns["ÜRÜN ADI"].Width = 300;
            dataGridView1.Columns["BİRİM"].Width = 100;
            dataGridView1.Columns["KATEGORİ"].Width = 150;
            dataGridView1.Columns["MİKTAR"].Width = 60;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Form FormÜrünekle = new FormÜrünEkle();
            FormÜrünekle.ShowDialog();
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = arama.Text.Trim();
            VerileriGetir(aramaMetni);
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            Form FormÜrünleriListele = new FormÜrünleriListele();
            FormÜrünleriListele.ShowDialog();
        }
        
        PrintDocument printDocument = new PrintDocument();
        PrintDialog printDialog = new PrintDialog();
        int satirIndex = 0; 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int baslangicX = 50;
            int baslangicY = 50;
            int hucreYukseklik = 30;
            Font font = new Font("Arial", 11);
            Brush brush = Brushes.Black;
            StringFormat stringFormat = new StringFormat
            {
                Trimming = StringTrimming.EllipsisCharacter, // Uzun metinleri kes
                FormatFlags = StringFormatFlags.LineLimit
            };

            float[] sutunGenislikleri = new float[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                SizeF baslikBoyut = e.Graphics.MeasureString(dataGridView1.Columns[i].HeaderText, font);
                sutunGenislikleri[i] = Math.Max(baslikBoyut.Width, 100);

                // Satırlardaki en uzun metni kontrol et
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[i].Value != null)
                    {
                        SizeF veriBoyut = e.Graphics.MeasureString(row.Cells[i].Value.ToString(), font);
                        sutunGenislikleri[i] = Math.Max(sutunGenislikleri[i], veriBoyut.Width);
                    }
                }
            }

            float currentX = baslangicX;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                RectangleF rect = new RectangleF(currentX, baslangicY, sutunGenislikleri[i], hucreYukseklik);
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, font, brush, rect, stringFormat);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect));
                currentX += sutunGenislikleri[i];
            }
            baslangicY += hucreYukseklik;

            while (satirIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[satirIndex];
                currentX = baslangicX;
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    object value = row.Cells[j].Value;
                    RectangleF rect = new RectangleF(currentX, baslangicY, sutunGenislikleri[j], hucreYukseklik);
                    if (value != null)
                    {
                        e.Graphics.DrawString(value.ToString(), font, brush, rect, stringFormat);
                    }
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect));
                    currentX += sutunGenislikleri[j];
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
            satirIndex = 0;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += printDocument1_PrintPage;
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilenID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                FormÜrünDüzenle frm = new FormÜrünDüzenle();
                frm.UrunID = secilenID;
                frm.ShowDialog();

                // Düzenleme sonrası DataGridView'i yenile
                VerileriGetir();
            }
        }
    }
}
