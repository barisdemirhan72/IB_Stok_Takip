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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormÜrünleriListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.btnSiralaAZ = new İB_Stok_Takip.RJButton();
            this.btnSiralaID = new İB_Stok_Takip.RJButton();
            this.btnSiralaZA = new İB_Stok_Takip.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(598, 82);
            this.txtArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(251, 39);
            this.txtArama.TabIndex = 9;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(118)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 57);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(113, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Listesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
            this.lblArama.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Image = ((System.Drawing.Image)(resources.GetObject("lblArama.Image")));
            this.lblArama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArama.Location = new System.Drawing.Point(597, 57);
            this.lblArama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(60, 23);
            this.lblArama.TabIndex = 13;
            this.lblArama.Text = "   Ara";
            // 
            // btnSiralaAZ
            // 
            this.btnSiralaAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
            this.btnSiralaAZ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(71)))));
            this.btnSiralaAZ.BorderColor = System.Drawing.Color.Black;
            this.btnSiralaAZ.BorderRadius = 20;
            this.btnSiralaAZ.BorderSize = 2;
            this.btnSiralaAZ.FlatAppearance.BorderSize = 0;
            this.btnSiralaAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiralaAZ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaAZ.ForeColor = System.Drawing.Color.White;
            this.btnSiralaAZ.Location = new System.Drawing.Point(598, 149);
            this.btnSiralaAZ.Name = "btnSiralaAZ";
            this.btnSiralaAZ.Size = new System.Drawing.Size(251, 53);
            this.btnSiralaAZ.TabIndex = 14;
            this.btnSiralaAZ.Text = "Ürünleri Sırala [A-Z]";
            this.btnSiralaAZ.TextColor = System.Drawing.Color.White;
            this.btnSiralaAZ.UseVisualStyleBackColor = false;
            // 
            // btnSiralaID
            // 
            this.btnSiralaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.btnSiralaID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.btnSiralaID.BorderColor = System.Drawing.Color.Black;
            this.btnSiralaID.BorderRadius = 20;
            this.btnSiralaID.BorderSize = 2;
            this.btnSiralaID.FlatAppearance.BorderSize = 0;
            this.btnSiralaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiralaID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaID.ForeColor = System.Drawing.Color.White;
            this.btnSiralaID.Location = new System.Drawing.Point(598, 292);
            this.btnSiralaID.Name = "btnSiralaID";
            this.btnSiralaID.Size = new System.Drawing.Size(251, 53);
            this.btnSiralaID.TabIndex = 15;
            this.btnSiralaID.Text = "Ürünleri Sırala [ID]";
            this.btnSiralaID.TextColor = System.Drawing.Color.White;
            this.btnSiralaID.UseVisualStyleBackColor = false;
            // 
            // btnSiralaZA
            // 
            this.btnSiralaZA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
            this.btnSiralaZA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(23)))));
            this.btnSiralaZA.BorderColor = System.Drawing.Color.Black;
            this.btnSiralaZA.BorderRadius = 20;
            this.btnSiralaZA.BorderSize = 2;
            this.btnSiralaZA.FlatAppearance.BorderSize = 0;
            this.btnSiralaZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiralaZA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiralaZA.ForeColor = System.Drawing.Color.White;
            this.btnSiralaZA.Location = new System.Drawing.Point(598, 220);
            this.btnSiralaZA.Name = "btnSiralaZA";
            this.btnSiralaZA.Size = new System.Drawing.Size(251, 53);
            this.btnSiralaZA.TabIndex = 16;
            this.btnSiralaZA.Text = "Ürünleri Sırala [Z-A]";
            this.btnSiralaZA.TextColor = System.Drawing.Color.White;
            this.btnSiralaZA.UseVisualStyleBackColor = false;
            // 
            // FormÜrünleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 496);
            this.Controls.Add(this.btnSiralaZA);
            this.Controls.Add(this.btnSiralaID);
            this.Controls.Add(this.btnSiralaAZ);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormÜrünleriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormÜrünleriListele";
            this.Load += new System.EventHandler(this.FormÜrünleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArama;
        private RJButton btnSiralaAZ;
        private RJButton btnSiralaID;
        private RJButton btnSiralaZA;
    }
}