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
    public partial class BankaEklemeFormu : Form
    {
        public BankaEklemeFormu()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka()
            {
                BankaAdi = txtAdi.Text,
                BankaAdres = txtAdresi.Text,
                BankaSahibi = txtSahibi.Text
            };

            Form1.bankaListesi.Add(banka);
            Form1.form1.Show();
            this.Hide();
        }
    }
}
