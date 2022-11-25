using BankaApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaApp.Abstract
{
    public interface IBanka
    {

        string BankaAdi { get; set; }
        string BankaSahibi { get; set; }
        string BankaAdres { get; set; }
        List<IMusteri> Musteriler { get; set; }
    }
}
