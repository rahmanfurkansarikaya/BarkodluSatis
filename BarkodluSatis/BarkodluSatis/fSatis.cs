using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fSatis : Form
    {
        public fSatis()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    tMiktar.Text = barkod;
                    tBarkod.Clear();
                    tBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        int satirsayisi = gridSatisListesi.Rows.Count;
                        double miktar = Convert.ToDouble(tMiktar.Text);
                        bool eklenmismi = false;
                        if (satirsayisi > 0)
                        {
                            for (int i = 0; i < satirsayisi; i++)
                            {
                                if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                                {
                                    gridSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                                    gridSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                                    eklenmismi = true;
                                }
                            }
                        }
                        if (!eklenmismi)
                        {
                            gridSatisListesi.Rows.Add();
                            gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                            gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                            gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                            gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                            gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                            gridSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                            gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                            gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyati"].Value = urun.AlisFiyat;
                            gridSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.KdvTutari;
                            gridSatisListesi.Rows[satirsayisi].Cells["Aciklama"].Value = urun.Aciklama;
                        }
                    }
                }
                gridSatisListesi.ClearSelection();
                GenelToplam();
            }
        }

        private void GenelToplam()
        {
            if (gridSatisListesi.Rows.Count > 0)
            {
                double toplam = 0;
                for (int i = 0; i < gridSatisListesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Toplam"].Value);
                }
                tGenelToplam.Text = toplam.ToString("C2");
                tBarkod.Clear();
                tBarkod.Focus();
            }
        }
    }
}
