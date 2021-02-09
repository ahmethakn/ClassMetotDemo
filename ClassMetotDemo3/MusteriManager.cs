using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo3
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Kaydınız Alınmıştır.");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Kaydınız Silinmiştir.");
        }
    }
}
