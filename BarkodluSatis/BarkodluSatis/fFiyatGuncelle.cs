﻿using System;
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
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new BarkodDbEntities())
                {
                    if (db.Urun.Any(x => x.Barkod == tBarkod.Text.Trim()))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == tBarkod.Text).SingleOrDefault();
                        lBarkod.Text = getir.Barkod;
                        lUrunAdi.Text = getir.UrunAd;
                        double mevcutfiyat = Convert.ToDouble(getir.SatisFiyat);
                        lMevcutFiyat.Text = mevcutfiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil");
                    }
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tYeniFiyat.Text != "" && lBarkod.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(tYeniFiyat.Text);
                    int kdvorani = Convert.ToInt32(guncellenecek.KdvOrani);
                    Math.Round(Islemler.DoubleYap(tYeniFiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedilmiştir");
                    lBarkod.Text = "";
                    lUrunAdi.Text = "";
                    lMevcutFiyat.Text = "";
                    tBarkod.Clear();
                    tYeniFiyat.Clear();
                    tBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün Okutunuz");
                tBarkod.Focus();
            }
        }

        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {
            lBarkod.Text = "";
            lUrunAdi.Text = "";
            lMevcutFiyat.Text = "";
            tBarkod.Focus();
        }
    }
}
