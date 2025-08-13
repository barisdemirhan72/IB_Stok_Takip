namespace İB_Stok_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblDateTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.arama = new System.Windows.Forms.TextBox();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.btnUrunEkle = new İB_Stok_Takip.RJButton();
			this.btnUrunSil = new İB_Stok_Takip.RJButton();
			this.btnUrunListele = new İB_Stok_Takip.RJButton();
			this.btnAlinanUrunler = new İB_Stok_Takip.RJButton();
			this.btnYazdir = new İB_Stok_Takip.RJButton();
			this.btnRaporla = new İB_Stok_Takip.RJButton();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1363, 70);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(111, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(657, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "İskenderun Belediyesi Stok Takip Uygulaması";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, -1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(95, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblDateTime
			// 
			this.lblDateTime.AutoSize = true;
			this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
			this.lblDateTime.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDateTime.Location = new System.Drawing.Point(1011, 706);
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(101, 34);
			this.lblDateTime.TabIndex = 2;
			this.lblDateTime.Text = "label2";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 114);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(980, 626);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.Form1_Load);
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// arama
			// 
			this.arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.arama.Location = new System.Drawing.Point(1007, 114);
			this.arama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.arama.Name = "arama";
			this.arama.Size = new System.Drawing.Size(333, 53);
			this.arama.TabIndex = 11;
			this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// btnUrunEkle
			// 
			this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
			this.btnUrunEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
			this.btnUrunEkle.BorderColor = System.Drawing.Color.Black;
			this.btnUrunEkle.BorderRadius = 20;
			this.btnUrunEkle.BorderSize = 2;
			this.btnUrunEkle.FlatAppearance.BorderSize = 0;
			this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUrunEkle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
			this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
			this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUrunEkle.Location = new System.Drawing.Point(1007, 193);
			this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUrunEkle.Name = "btnUrunEkle";
			this.btnUrunEkle.Size = new System.Drawing.Size(335, 65);
			this.btnUrunEkle.TabIndex = 16;
			this.btnUrunEkle.Text = "     Yeni Ürün Ekle";
			this.btnUrunEkle.TextColor = System.Drawing.Color.White;
			this.btnUrunEkle.UseVisualStyleBackColor = false;
			// 
			// btnUrunSil
			// 
			this.btnUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
			this.btnUrunSil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
			this.btnUrunSil.BorderColor = System.Drawing.Color.Black;
			this.btnUrunSil.BorderRadius = 20;
			this.btnUrunSil.BorderSize = 2;
			this.btnUrunSil.FlatAppearance.BorderSize = 0;
			this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUrunSil.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUrunSil.ForeColor = System.Drawing.Color.White;
			this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
			this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUrunSil.Location = new System.Drawing.Point(1007, 304);
			this.btnUrunSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUrunSil.Name = "btnUrunSil";
			this.btnUrunSil.Size = new System.Drawing.Size(335, 65);
			this.btnUrunSil.TabIndex = 17;
			this.btnUrunSil.Text = "   Ürün Sil/Al";
			this.btnUrunSil.TextColor = System.Drawing.Color.White;
			this.btnUrunSil.UseVisualStyleBackColor = false;
			// 
			// btnUrunListele
			// 
			this.btnUrunListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
			this.btnUrunListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
			this.btnUrunListele.BorderColor = System.Drawing.Color.Black;
			this.btnUrunListele.BorderRadius = 20;
			this.btnUrunListele.BorderSize = 2;
			this.btnUrunListele.FlatAppearance.BorderSize = 0;
			this.btnUrunListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUrunListele.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUrunListele.ForeColor = System.Drawing.Color.White;
			this.btnUrunListele.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunListele.Image")));
			this.btnUrunListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUrunListele.Location = new System.Drawing.Point(1007, 412);
			this.btnUrunListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUrunListele.Name = "btnUrunListele";
			this.btnUrunListele.Size = new System.Drawing.Size(335, 65);
			this.btnUrunListele.TabIndex = 18;
			this.btnUrunListele.Text = "   Ürün Listele";
			this.btnUrunListele.TextColor = System.Drawing.Color.White;
			this.btnUrunListele.UseVisualStyleBackColor = false;
			// 
			// btnAlinanUrunler
			// 
			this.btnAlinanUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
			this.btnAlinanUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
			this.btnAlinanUrunler.BorderColor = System.Drawing.Color.Black;
			this.btnAlinanUrunler.BorderRadius = 20;
			this.btnAlinanUrunler.BorderSize = 2;
			this.btnAlinanUrunler.FlatAppearance.BorderSize = 0;
			this.btnAlinanUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlinanUrunler.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAlinanUrunler.ForeColor = System.Drawing.Color.White;
			this.btnAlinanUrunler.Image = ((System.Drawing.Image)(resources.GetObject("btnAlinanUrunler.Image")));
			this.btnAlinanUrunler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlinanUrunler.Location = new System.Drawing.Point(1007, 513);
			this.btnAlinanUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAlinanUrunler.Name = "btnAlinanUrunler";
			this.btnAlinanUrunler.Size = new System.Drawing.Size(335, 65);
			this.btnAlinanUrunler.TabIndex = 19;
			this.btnAlinanUrunler.Text = "  Alınan Ürünler";
			this.btnAlinanUrunler.TextColor = System.Drawing.Color.White;
			this.btnAlinanUrunler.UseVisualStyleBackColor = false;
			// 
			// btnYazdir
			// 
			this.btnYazdir.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnYazdir.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.btnYazdir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
			this.btnYazdir.BorderRadius = 20;
			this.btnYazdir.BorderSize = 2;
			this.btnYazdir.FlatAppearance.BorderSize = 0;
			this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYazdir.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYazdir.ForeColor = System.Drawing.Color.Black;
			this.btnYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.Image")));
			this.btnYazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnYazdir.Location = new System.Drawing.Point(1007, 607);
			this.btnYazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnYazdir.Name = "btnYazdir";
			this.btnYazdir.Size = new System.Drawing.Size(159, 65);
			this.btnYazdir.TabIndex = 20;
			this.btnYazdir.Text = "Yazdır";
			this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnYazdir.TextColor = System.Drawing.Color.Black;
			this.btnYazdir.UseVisualStyleBackColor = false;
			// 
			// btnRaporla
			// 
			this.btnRaporla.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnRaporla.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.btnRaporla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
			this.btnRaporla.BorderRadius = 20;
			this.btnRaporla.BorderSize = 2;
			this.btnRaporla.FlatAppearance.BorderSize = 0;
			this.btnRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRaporla.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRaporla.ForeColor = System.Drawing.Color.Black;
			this.btnRaporla.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporla.Image")));
			this.btnRaporla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRaporla.Location = new System.Drawing.Point(1173, 607);
			this.btnRaporla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRaporla.Name = "btnRaporla";
			this.btnRaporla.Size = new System.Drawing.Size(168, 65);
			this.btnRaporla.TabIndex = 21;
			this.btnRaporla.Text = "Raporla";
			this.btnRaporla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRaporla.TextColor = System.Drawing.Color.Black;
			this.btnRaporla.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(1012, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 29);
			this.label2.TabIndex = 22;
			this.label2.Text = "   Ara";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1365, 753);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRaporla);
			this.Controls.Add(this.btnYazdir);
			this.Controls.Add(this.btnAlinanUrunler);
			this.Controls.Add(this.btnUrunListele);
			this.Controls.Add(this.btnUrunSil);
			this.Controls.Add(this.btnUrunEkle);
			this.Controls.Add(this.arama);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblDateTime);
			this.Controls.Add(this.panel1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İskenderun Belediyesi Stok Takip Uygulaması";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private RJButton btnUrunEkle;
        private RJButton btnUrunSil;
        private RJButton btnUrunListele;
        private RJButton btnAlinanUrunler;
        private RJButton btnYazdir;
        private RJButton btnRaporla;
        private System.Windows.Forms.Label label2;
    }
}

