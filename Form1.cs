using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
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

        // SQL BAĞLANTISI KURMA KOMUTU DENEMESİ
        /*
        void baglantiKur()
        {
            baglanti = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Stok_Takip;Trusted_Connection=True;");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Tablo", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
         // baglantiKur();
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

        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            Form FormÜrünDüzenle= new FormÜrünDüzenle();
            FormÜrünDüzenle.ShowDialog();
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            Form FormÜrünleriListele = new FormÜrünleriListele();
            FormÜrünleriListele.ShowDialog();
        }
        // Yazdırma için gerekli nesneler ve komutlar
        PrintDocument printDocument = new PrintDocument();
        PrintDialog printDialog = new PrintDialog();
        int satirIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int baslangicX = 50;
            int baslangicY = 50;
            int hucreYukseklik = 30;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            // Kolon başlıklarını yazdırma 
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, font, brush, baslangicX + (i * 120), baslangicY);
            }
            baslangicY += hucreYukseklik;
            // Satırları yazdırma
            while (satirIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[satirIndex];
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    object value = row.Cells[j].Value;
                    if (value != null)
                    {
                        e.Graphics.DrawString(value.ToString(), font, brush, baslangicX + (j * 120), baslangicY);
                    }
                }
                satirIndex++;
                baslangicY += hucreYukseklik;
                // Sayfaya sığmazsa, devam edeceğini belirtme şartı
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
    }
}
