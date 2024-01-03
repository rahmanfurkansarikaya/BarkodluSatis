namespace ProgramRestore
{
    partial class Form1
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
            this.tDosya = new System.Windows.Forms.TextBox();
            this.bSec = new System.Windows.Forms.Button();
            this.bYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tDosya
            // 
            this.tDosya.Location = new System.Drawing.Point(13, 34);
            this.tDosya.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tDosya.Name = "tDosya";
            this.tDosya.Size = new System.Drawing.Size(384, 26);
            this.tDosya.TabIndex = 0;
            // 
            // bSec
            // 
            this.bSec.Location = new System.Drawing.Point(405, 30);
            this.bSec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSec.Name = "bSec";
            this.bSec.Size = new System.Drawing.Size(112, 35);
            this.bSec.TabIndex = 1;
            this.bSec.Text = "Yedek Seç";
            this.bSec.UseVisualStyleBackColor = true;
            this.bSec.Click += new System.EventHandler(this.bSec_Click);
            // 
            // bYukle
            // 
            this.bYukle.Location = new System.Drawing.Point(380, 70);
            this.bYukle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bYukle.Name = "bYukle";
            this.bYukle.Size = new System.Drawing.Size(141, 40);
            this.bYukle.TabIndex = 2;
            this.bYukle.Text = "YÜKLE";
            this.bYukle.UseVisualStyleBackColor = true;
            this.bYukle.Click += new System.EventHandler(this.bYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dikkat : Bu işlemi yaptığınızda yükleyeceğiniz\r\nson yedek bilgileri yüklenip eski" +
    "ler silinecektir.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "LÜTFEN ALDIĞINIZ SON YEDEĞİ SEÇİNİZ.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 121);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bYukle);
            this.Controls.Add(this.bSec);
            this.Controls.Add(this.tDosya);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(550, 160);
            this.MinimumSize = new System.Drawing.Size(550, 160);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BARKODLU SATIŞ PROGRAMI YEDEKTEN YÜKLEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDosya;
        private System.Windows.Forms.Button bSec;
        private System.Windows.Forms.Button bYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

