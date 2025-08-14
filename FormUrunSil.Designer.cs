namespace İB_Stok_Takip
{
    partial class FormUrunSil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunSil));
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnOnayla = new İB_Stok_Takip.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioSadeceSil = new İB_Stok_Takip.RJRadioButton();
            this.radioBaskaAdinaAldir = new İB_Stok_Takip.RJRadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(32, 201);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(327, 40);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(50, 169);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(293, 29);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Alan Kişinin Adı Soyadı:";
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
            this.btnOnayla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
            this.btnOnayla.BorderColor = System.Drawing.Color.Black;
            this.btnOnayla.BorderRadius = 20;
            this.btnOnayla.BorderSize = 2;
            this.btnOnayla.FlatAppearance.BorderSize = 0;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayla.Image")));
            this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOnayla.Location = new System.Drawing.Point(115, 253);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(164, 49);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "   Onayla";
            this.btnOnayla.TextColor = System.Drawing.Color.White;
            this.btnOnayla.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 55);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(110, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Sil / Al";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // radioSadeceSil
            // 
            this.radioSadeceSil.AutoSize = true;
            this.radioSadeceSil.BackColor = System.Drawing.SystemColors.Control;
            this.radioSadeceSil.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
            this.radioSadeceSil.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioSadeceSil.ForeColor = System.Drawing.Color.Black;
            this.radioSadeceSil.Location = new System.Drawing.Point(32, 87);
            this.radioSadeceSil.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioSadeceSil.Name = "radioSadeceSil";
            this.radioSadeceSil.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioSadeceSil.Size = new System.Drawing.Size(353, 33);
            this.radioSadeceSil.TabIndex = 8;
            this.radioSadeceSil.TabStop = true;
            this.radioSadeceSil.Text = "Ürünü Sadece Listeden Sil";
            this.radioSadeceSil.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioSadeceSil.UseVisualStyleBackColor = false;
            // 
            // radioBaskaAdinaAldir
            // 
            this.radioBaskaAdinaAldir.AutoSize = true;
            this.radioBaskaAdinaAldir.BackColor = System.Drawing.SystemColors.Control;
            this.radioBaskaAdinaAldir.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.radioBaskaAdinaAldir.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBaskaAdinaAldir.ForeColor = System.Drawing.Color.Black;
            this.radioBaskaAdinaAldir.Location = new System.Drawing.Point(32, 120);
            this.radioBaskaAdinaAldir.MinimumSize = new System.Drawing.Size(0, 21);
            this.radioBaskaAdinaAldir.Name = "radioBaskaAdinaAldir";
            this.radioBaskaAdinaAldir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radioBaskaAdinaAldir.Size = new System.Drawing.Size(311, 33);
            this.radioBaskaAdinaAldir.TabIndex = 9;
            this.radioBaskaAdinaAldir.TabStop = true;
            this.radioBaskaAdinaAldir.Text = "Ürünü Bir Kişi Adına Al";
            this.radioBaskaAdinaAldir.UnCheckedColor = System.Drawing.Color.Gray;
            this.radioBaskaAdinaAldir.UseVisualStyleBackColor = false;
            // 
            // FormUrunSil
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 314);
            this.Controls.Add(this.radioBaskaAdinaAldir);
            this.Controls.Add(this.radioSadeceSil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUrunSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Sil / Alındır";
            this.Load += new System.EventHandler(this.FormUrunSil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private RJButton btnOnayla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJRadioButton radioSadeceSil;
        private RJRadioButton radioBaskaAdinaAldir;
        private System.Windows.Forms.Label label1;
    }
}
