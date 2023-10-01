using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarkodluSatis
{
    public partial class fBarkodYazdir : Form
    {
        public fBarkodYazdir()
        {
            InitializeComponent();
        }
        private void fBarkodYazdir_Load(object sender, EventArgs e)
        {
            tBarkod.Focus();
        }

        private void bOlustur_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //  pictureBox1.Image = brc.Draw(urunadi.Text, 35);
            Image testimage = brc.Draw(tBarkod.Text, 35);
            pictureBox1.Image = brc.Draw(tBarkod.Text, 35);
            var img = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (var g = Graphics.FromImage(img))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;


                g.DrawImage(testimage, 0, 0, 215, 90);
                var testinteger = 0;
                testinteger = ((215 / 2) - ((tBarkod.Text.Length * 7) / 2));
                var testinteger2 = ((215 / 2) - ((tUrunAdi.Text.Length * 5) / 2));
                g.DrawString(tBarkod.Text, new Font(tBarkod.Font, FontStyle.Regular), Brushes.Black, new PointF(testinteger, 92));
                g.DrawString(tUrunAdi.Text /*+ Environment.NewLine + tUrunAdi.Text*/, new Font(tBarkod.Font, FontStyle.Regular), Brushes.Black, new PointF(testinteger2, 103));

            }

            // Dispose the existing image if there is one.'
            //pictureBox1.Image?.Dispose();

            pictureBox1.Image = img;
        }
        private void bBarkodCikar_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            doc.Print();
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            {
                Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

                int urunMiktari = Convert.ToInt32(tUrunMiktari.Text);

                for (int i = 0; i < urunMiktari; i++)
                {
                    e.Graphics.DrawImage(bm, 5, (i * 140) + 5);
                }

                bm.Dispose();
            }
        }
    }
}
