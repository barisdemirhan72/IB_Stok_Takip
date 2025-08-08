namespace İB_Stok_Takip
{
    partial class FormÜrünEkle
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.katagori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 62);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(867, 689);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Ürün Ekle";
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.PaleGreen;
            this.ekle.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(894, 486);
            this.ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(393, 80);
            this.ekle.TabIndex = 5;
            this.ekle.Text = "Ürün Ekle [+]";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(886, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Adı";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(894, 109);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(391, 61);
            this.ad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(886, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Katagorisi";
            // 
            // katagori
            // 
            this.katagori.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katagori.FormattingEnabled = true;
            this.katagori.Items.AddRange(new object[] {
            "TONER",
            "RAM",
            "VGA"});
            this.katagori.Location = new System.Drawing.Point(894, 254);
            this.katagori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.katagori.Name = "katagori";
            this.katagori.Size = new System.Drawing.Size(391, 50);
            this.katagori.TabIndex = 9;
            this.katagori.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(886, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Adeti";
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(894, 394);
            this.adet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adet.Multiline = true;
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(391, 61);
            this.adet.TabIndex = 11;
            // 
            // FormÜrünEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1292, 781);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.katagori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormÜrünEkle";
            this.Text = "FormÜrünEkle";
            this.Load += new System.EventHandler(this.FormÜrünEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox katagori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adet;
    }
}