namespace İB_Stok_Takip
{
    partial class FormUrunSil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton radioSadeceSil;
        private System.Windows.Forms.RadioButton radioBaskaAdinaAldir;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnOnayla;

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
            this.radioSadeceSil = new System.Windows.Forms.RadioButton();
            this.radioBaskaAdinaAldir = new System.Windows.Forms.RadioButton();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioSadeceSil
            // 
            this.radioSadeceSil.AutoSize = true;
            this.radioSadeceSil.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioSadeceSil.Location = new System.Drawing.Point(30, 30);
            this.radioSadeceSil.Name = "radioSadeceSil";
            this.radioSadeceSil.Size = new System.Drawing.Size(296, 32);
            this.radioSadeceSil.TabIndex = 0;
            this.radioSadeceSil.TabStop = true;
            this.radioSadeceSil.Text = "Ürünü Sadece Listeden Sil";
            this.radioSadeceSil.UseVisualStyleBackColor = true;
            this.radioSadeceSil.CheckedChanged += new System.EventHandler(this.radioBaskaAdinaAldir_CheckedChanged);
            // 
            // radioBaskaAdinaAldir
            // 
            this.radioBaskaAdinaAldir.AutoSize = true;
            this.radioBaskaAdinaAldir.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBaskaAdinaAldir.Location = new System.Drawing.Point(30, 70);
            this.radioBaskaAdinaAldir.Name = "radioBaskaAdinaAldir";
            this.radioBaskaAdinaAldir.Size = new System.Drawing.Size(260, 32);
            this.radioBaskaAdinaAldir.TabIndex = 1;
            this.radioBaskaAdinaAldir.TabStop = true;
            this.radioBaskaAdinaAldir.Text = "Ürünü Bir Kişi Adına Al";
            this.radioBaskaAdinaAldir.UseVisualStyleBackColor = true;
            this.radioBaskaAdinaAldir.CheckedChanged += new System.EventHandler(this.radioBaskaAdinaAldir_CheckedChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(30, 171);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(300, 40);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(26, 125);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(304, 34);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Alan Kişinin Adı Soyadı:";
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.LightGreen;
            this.btnOnayla.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnOnayla.Location = new System.Drawing.Point(30, 231);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(300, 58);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // FormUrunSil
            // 
            this.ClientSize = new System.Drawing.Size(370, 314);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.radioBaskaAdinaAldir);
            this.Controls.Add(this.radioSadeceSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUrunSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Sil / Alındır";
            this.Load += new System.EventHandler(this.FormUrunSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
