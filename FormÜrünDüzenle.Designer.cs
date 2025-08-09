namespace İB_Stok_Takip
{
    partial class FormÜrünDüzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(177, 176);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(460, 32);
            this.cmbKategori.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kategori:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(178, 28);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(459, 40);
            this.txtUrunAdi.TabIndex = 13;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(14, 28);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(155, 40);
            this.lblUrunAdi.TabIndex = 12;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirim.Location = new System.Drawing.Point(14, 97);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(114, 40);
            this.lblBirim.TabIndex = 20;
            this.lblBirim.Text = "Birim: ";
            // 
            // txtBirim
            // 
            this.txtBirim.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirim.Location = new System.Drawing.Point(177, 97);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(460, 40);
            this.txtBirim.TabIndex = 21;
            // 
            // numericMiktar
            // 
            this.numericMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericMiktar.Location = new System.Drawing.Point(177, 236);
            this.numericMiktar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(120, 41);
            this.numericMiktar.TabIndex = 22;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Gold;
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(21, 300);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(276, 70);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "[▲] Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormÜrünDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 401);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.numericMiktar);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.MaximizeBox = false;
            this.Name = "FormÜrünDüzenle";
            this.Text = "Ürün Düzenleme";
            this.Load += new System.EventHandler(this.FormÜrünDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.NumericUpDown numericMiktar;
        private System.Windows.Forms.Button btnKaydet;
    }
}