using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaApp.Abstract
{
    public interface IMusteri
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        string TcNo { get; set; }
        decimal Bakiye { get; set; }
        string MusteriNo { get; set; }


    }
}
