namespace İB_Stok_Takip
{
    partial class FormÜrünleriListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUrunlerListesi = new System.Windows.Forms.Label();
            this.btnSiralaAZ = new System.Windows.Forms.Button();
            this.btnSiralaZA = new System.Windows.Forms.Button();
            this.btnSiralaID = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblUrunlerListesi
            // 
            this.lblUrunlerListesi.AutoSize = true;
            this.lblUrunlerListesi.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunlerListesi.Location = new System.Drawing.Point(12, 18);
            this.lblUrunlerListesi.Name = "lblUrunlerListesi";
            this.lblUrunlerListesi.Size = new System.Drawing.Size(218, 34);
            this.lblUrunlerListesi.TabIndex = 1;
            this.lblUrunlerListesi.Text = "Ürünler Listesi";
            // 
            // btnSiralaAZ
            // 
            this.btnSiralaAZ.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSiralaAZ.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaAZ.ForeColor = System.Drawing.Color.Black;
            this.btnSiralaAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiralaAZ.Location = new System.Drawing.Point(782, 149);
            this.btnSiralaAZ.Name = "btnSiralaAZ";
            this.btnSiralaAZ.Size = new System.Drawing.Size(349, 64);
            this.btnSiralaAZ.TabIndex = 6;
            this.btnSiralaAZ.Text = "Ürünleri Sırala [A-Z]";
            this.btnSiralaAZ.UseVisualStyleBackColor = false;
            this.btnSiralaAZ.Click += new System.EventHandler(this.btnSiralaAZ_Click);
            // 
            // btnSiralaZA
            // 
            this.btnSiralaZA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSiralaZA.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaZA.ForeColor = System.Drawing.Color.Black;
            this.btnSiralaZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiralaZA.Location = new System.Drawing.Point(782, 238);
            this.btnSiralaZA.Name = "btnSiralaZA";
            this.btnSiralaZA.Size = new System.Drawing.Size(349, 64);
            this.btnSiralaZA.TabIndex = 7;
            this.btnSiralaZA.Text = "Ürünleri Sırala [Z-A]";
            this.btnSiralaZA.UseVisualStyleBackColor = false;
            this.btnSiralaZA.Click += new System.EventHandler(this.btnSiralaZA_Click);
            // 
            // btnSiralaID
            // 
            this.btnSiralaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSiralaID.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaID.ForeColor = System.Drawing.Color.Black;
            this.btnSiralaID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiralaID.Location = new System.Drawing.Point(782, 325);
            this.btnSiralaID.Name = "btnSiralaID";
            this.btnSiralaID.Size = new System.Drawing.Size(349, 64);
            this.btnSiralaID.TabIndex = 8;
            this.btnSiralaID.Text = "Ürünleri Sırala [ID]";
            this.btnSiralaID.UseVisualStyleBackColor = false;
            this.btnSiralaID.Click += new System.EventHandler(this.btnSiralaID_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(782, 67);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(349, 47);
            this.txtArama.TabIndex = 9;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // FormÜrünleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 611);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnSiralaID);
            this.Controls.Add(this.btnSiralaZA);
            this.Controls.Add(this.btnSiralaAZ);
            this.Controls.Add(this.lblUrunlerListesi);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormÜrünleriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormÜrünleriListele";
            this.Load += new System.EventHandler(this.FormÜrünleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUrunlerListesi;
        private System.Windows.Forms.Button btnSiralaAZ;
        private System.Windows.Forms.Button btnSiralaZA;
        private System.Windows.Forms.Button btnSiralaID;
        private System.Windows.Forms.TextBox txtArama;
    }
}