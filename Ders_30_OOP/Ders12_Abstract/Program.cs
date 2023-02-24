using System;
using Ders12_Abstract.SekilSorusu;

namespace Ders12_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {

            // Abstract sınıflardan nesne türetilemez.
            // Abstract sınıflar abstact olmayan metot ve özellikler barındırabilir.
            // Abstract sınıflarda abstract olarak belirtilen metotların gövdesi oluşturulamaz.
            // Abstract olarak belirtilmiş metotlar alt sınıflarda tanımlanmak zorundadır!!!

            Dortgen drt = new Dortgen();
            drt.en = 10;
            drt.boy = 20;
            drt.SekilAd = "Dörtgen";
            drt.SekilAdYaz();

            Ucgen uc = new Ucgen();
            uc.kenar1 = 6;
            uc.kenar2 = 8;
            uc.taban = 10;
            uc.yukseklik = 14;

            Daire dr = new Daire();
            dr.yariCap = 10;



            Alan(drt);
            Alan(uc);
            Alan(dr);

            Cevre(drt);
            Cevre(uc);
            Cevre(dr);
        }

        static void Alan(Sekil sekil)
        {
            sekil.AlanHesapla();
        }
        static void Cevre(Sekil sekil)
        {
            sekil.CevreHesapla();
        }

    }
}
