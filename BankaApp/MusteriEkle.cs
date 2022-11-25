using BankaApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaApp
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
            musteriEkleFormu = this;
        }

        public static MusteriEkle musteriEkleFormu;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form1.bankaListesi[BankaListelemeFormu.secilenBankaIndex].Musteriler.Add(new Musteri()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bakiye = Convert.ToDecimal(txtBakiye.Text),
                TcNo = txtTcNo.Text
            });

            BankaListelemeFormu.bankaListelemeFormu.Show();
            this.Hide();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            lblBankaAdi.Text = Form1.bankaListesi[BankaListelemeFormu.secilenBankaIndex].BankaAdi + " " + "HOŞGELDİNİZ";
        }
    }
}
