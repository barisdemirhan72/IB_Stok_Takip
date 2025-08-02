using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İB_Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
    }
}
