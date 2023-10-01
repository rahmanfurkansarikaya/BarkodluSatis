namespace BarkodluSatis
{
    partial class fBarkodYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBarkodYazdir));
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.tUrunAdi = new BarkodluSatis.tStandart();
            this.tUrunMiktari = new BarkodluSatis.tNumeric();
            this.tBarkod = new BarkodluSatis.tNumeric();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBarkodCikar = new BarkodluSatis.bStandart();
            this.bOlustur = new BarkodluSatis.bStandart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(37, 51);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(83, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Adı : ";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(14, 86);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(106, 20);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Ürün Miktarı : ";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(48, 19);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(72, 20);
            this.lStandart3.TabIndex = 2;
            this.lStandart3.Text = "Barkod : ";
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.BackColor = System.Drawing.Color.White;
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAdi.Location = new System.Drawing.Point(126, 51);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(188, 26);
            this.tUrunAdi.TabIndex = 2;
            this.tUrunAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tUrunMiktari
            // 
            this.tUrunMiktari.BackColor = System.Drawing.Color.White;
            this.tUrunMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunMiktari.Location = new System.Drawing.Point(126, 83);
            this.tUrunMiktari.Name = "tUrunMiktari";
            this.tUrunMiktari.Size = new System.Drawing.Size(188, 26);
            this.tUrunMiktari.TabIndex = 3;
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(126, 19);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(188, 26);
            this.tBarkod.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bBarkodCikar
            // 
            this.bBarkodCikar.BackColor = System.Drawing.Color.SeaGreen;
            this.bBarkodCikar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.bBarkodCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkodCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkodCikar.ForeColor = System.Drawing.Color.White;
            this.bBarkodCikar.Image = ((System.Drawing.Image)(resources.GetObject("bBarkodCikar.Image")));
            this.bBarkodCikar.Location = new System.Drawing.Point(191, 328);
            this.bBarkodCikar.Margin = new System.Windows.Forms.Padding(1);
            this.bBarkodCikar.Name = "bBarkodCikar";
            this.bBarkodCikar.Size = new System.Drawing.Size(123, 63);
            this.bBarkodCikar.TabIndex = 5;
            this.bBarkodCikar.Text = "Yazdır";
            this.bBarkodCikar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBarkodCikar.UseVisualStyleBackColor = false;
            this.bBarkodCikar.Click += new System.EventHandler(this.bBarkodCikar_Click);
            // 
            // bOlustur
            // 
            this.bOlustur.BackColor = System.Drawing.Color.DarkCyan;
            this.bOlustur.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.bOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bOlustur.ForeColor = System.Drawing.Color.White;
            this.bOlustur.Image = ((System.Drawing.Image)(resources.GetObject("bOlustur.Image")));
            this.bOlustur.Location = new System.Drawing.Point(105, 113);
            this.bOlustur.Margin = new System.Windows.Forms.Padding(1);
            this.bOlustur.Name = "bOlustur";
            this.bOlustur.Size = new System.Drawing.Size(167, 59);
            this.bOlustur.TabIndex = 4;
            this.bOlustur.Text = "Oluştur";
            this.bOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bOlustur.UseVisualStyleBackColor = false;
            this.bOlustur.Click += new System.EventHandler(this.bOlustur_Click);
            // 
            // fBarkodYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 408);
            this.Controls.Add(this.bOlustur);
            this.Controls.Add(this.bBarkodCikar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tBarkod);
            this.Controls.Add(this.tUrunMiktari);
            this.Controls.Add(this.tUrunAdi);
            this.Controls.Add(this.lStandart3);
            this.Controls.Add(this.lStandart2);
            this.Controls.Add(this.lStandart1);
            this.Name = "fBarkodYazdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBarkodYazdir";
            this.Load += new System.EventHandler(this.fBarkodYazdir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private lStandart lStandart2;
        private lStandart lStandart3;
        private tStandart tUrunAdi;
        private tNumeric tUrunMiktari;
        private tNumeric tBarkod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bStandart bBarkodCikar;
        private bStandart bOlustur;
    }
}