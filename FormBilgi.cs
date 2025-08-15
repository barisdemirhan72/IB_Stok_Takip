using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İB_Stok_Takip
{
    public partial class FormBilgi : Form
    {
        public FormBilgi()
        {
            InitializeComponent();
        }

        private void FormBilgi_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true; // Kullanıcı metni değiştiremesin
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical; // Yalnızca dikey kaydırma çubuğu
            richTextBox1.WordWrap = true; // Satır kaydırma (uzun satırlar otomatik alt satıra geçsin)

            string dosyaYolu = Path.Combine(Application.StartupPath, "iskenderun_stok_kullanici_kilavuzu.txt");
            richTextBox1.Text = File.ReadAllText(dosyaYolu);
        }

        
    }
}
