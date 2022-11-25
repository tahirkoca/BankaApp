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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bankaListesi = new List<Banka>();
            form1 = this;
        }

        public static Form1 form1; //değişken
        public static List<Banka> bankaListesi;
        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            BankaEklemeFormu bankaEklemeFormu = new BankaEklemeFormu();
            bankaEklemeFormu.Show();
            this.Hide();
        }

        private void btnBankaListele_Click(object sender, EventArgs e)
        {
            BankaListelemeFormu bankaListelemeFormu = new BankaListelemeFormu();
            bankaListelemeFormu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
