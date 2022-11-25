using BankaApp.Abstract;
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
    public partial class BankaMusterileriGoruntule : Form
    {
        public BankaMusterileriGoruntule()
        {
            InitializeComponent();
        }

        private void BankaMusterileriGoruntule_Load(object sender, EventArgs e)
        {
            ListViewAyarla(this.lstMusteriler);
            ListViewMusterileriGoruntule(Form1.bankaListesi[BankaListelemeFormu.secilenBankaIndex].Musteriler,this.lstMusteriler);
        }

        private void ListViewAyarla(ListView listviewAdi)
        {
            listviewAdi.Items.Clear();
            listviewAdi.FullRowSelect = true;
            listviewAdi.GridLines = true;
            listviewAdi.View = View.Details;
            listviewAdi.Columns.Add("Müşteri Adı", 150, HorizontalAlignment.Center);
            listviewAdi.Columns.Add("Müşteri Soyad", 150, HorizontalAlignment.Center);
            listviewAdi.Columns.Add("Müşteri Tc No", 150, HorizontalAlignment.Center);
            listviewAdi.Columns.Add("Müşteri Hesap No", 150, HorizontalAlignment.Center);
            listviewAdi.Columns.Add("Müşteri Bakiye", 150, HorizontalAlignment.Center);
        }

        private void ListViewMusterileriGoruntule(List<IMusteri> musteriListesi , ListView listviewAdi)
        {
            foreach (var item in musteriListesi)
            {
                ListViewItem eklenecekMusteri = new ListViewItem();
                eklenecekMusteri.Text = item.Ad;
                eklenecekMusteri.SubItems.Add(item.Soyad);
                eklenecekMusteri.SubItems.Add(item.TcNo);
                eklenecekMusteri.SubItems.Add(item.MusteriNo);
                eklenecekMusteri.SubItems.Add(item.Bakiye.ToString());
                listviewAdi.Items.Add(eklenecekMusteri);
                
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBankaListele_Click(object sender, EventArgs e)
        {
            BankaListelemeFormu.bankaListelemeFormu.Show();
            this.Hide();
        }

        private void btnMusteriEkleDon_Click(object sender, EventArgs e)
        {
            MusteriEkle.musteriEkleFormu.Show();
            this.Hide();
        }

        private void btnAnaSayfaDon_Click(object sender, EventArgs e)
        {
            Form1.form1.Show();
            this.Hide();
        }
    }
}
