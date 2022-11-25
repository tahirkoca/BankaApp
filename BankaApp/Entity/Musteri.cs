using BankaApp.Abstract;
using BankaApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaApp.Entity
{
    public class Musteri : IMusteri
    {
        public Musteri() 
        {
            MusteriNo = MusteriNoUret();
        }


        private decimal _Bakiye;
        public decimal Bakiye
        {
            get { return _Bakiye; }
            set
            {
                if (value < 0)
                {
                    _Bakiye = 0; //Bu adam bankaya borçlu olamaz
                }
                else
                    _Bakiye = value;
            }
        }

        public string MusteriNo { get; set; } //TR + 24 rakam alacak
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }

        //set metodunu private olarak ayarlamamın nedeni bu MusteriNo'su dışarıdan değil içeriden ayarlanması için. Sen bunun değerine dışarıdan ulaşabileceksin fakat bunun değeri değiştiremeyeceksin.
        private string MusteriNoUret()
        {
            Random rnd = new Random(); // Rastgele sayı oluşturması için kullanacağım.
            string uretilenNumara = "TR"; //TR+oluşturulan 24 adet rakamı ekleyeceksin
            for (int i = 0; i < 24; i++)
            {
                uretilenNumara += rnd.Next(0, 9).ToString();
            }

            return uretilenNumara;
        }

        public void ParaCek(decimal cekilecekTutar)
        {
            if (cekilecekTutar > _Bakiye)
            {
                throw new YetersizBakiyeException();
            }
            else
                _Bakiye -= cekilecekTutar;
        }
    }
}
