using BankaApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaApp.Entity
{
    public class Banka : IBanka
    {
        public Banka()
        {
            Musteriler = new List<IMusteri>();
        }
        public string BankaAdi { get ; set; }
        public string BankaSahibi { get; set; }
        public string BankaAdres { get; set; }
        public List<IMusteri> Musteriler { get; set; }
    }
}
