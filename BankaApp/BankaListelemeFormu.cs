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
    public partial class BankaListelemeFormu : Form
    {
        public BankaListelemeFormu()
        {
            InitializeComponent();
            bankaListelemeFormu = this;
        }

        private void BankaListelemeFormu_Load(object sender, EventArgs e)
        {
            ListViewAyarla(this.lstBankalar);
            ListViewBankalariGoruntule(Form1.bankaListesi, this.lstBankalar);
        }
        
        private void ListViewAyarla(ListView listView)
        {
            listView.Items.Clear();
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.View = View.Details;
            listView.Columns.Add("Banka Adı", 100, HorizontalAlignment.Center);
            listView.Columns.Add("Banka Sahibi", 100, HorizontalAlignment.Center);
            listView.Columns.Add("Banka Adresi", 100, HorizontalAlignment.Center);
        }

        private void ListViewBankalariGoruntule(List<Banka> bankaListesi , ListView listView)
        {
            foreach (var item in bankaListesi)
            {
                ListViewItem eklenecekBanka = new ListViewItem();
                eklenecekBanka.Text = item.BankaAdi;
                eklenecekBanka.SubItems.Add(item.BankaSahibi);
                eklenecekBanka.SubItems.Add(item.BankaAdres);
                listView.Items.Add(eklenecekBanka);
            }
        }

        public static int secilenBankaIndex = 0;
        public static BankaListelemeFormu bankaListelemeFormu;

        private void lstBankalar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            secilenBankaIndex = e.ItemIndex;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Hide();
        }

        private void btnMusteriGoruntule_Click(object sender, EventArgs e)
        {
            BankaMusterileriGoruntule bankaMusterileriGoruntule = new BankaMusterileriGoruntule();
            bankaMusterileriGoruntule.Show();
            this.Hide();
        }
    }
}
