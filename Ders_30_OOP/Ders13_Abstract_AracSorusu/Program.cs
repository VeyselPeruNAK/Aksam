using System;

namespace Ders13_Abstract_AracSorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil();
            oto.Fiyat = 200000;
            oto.KapiSayisi = 5;
            oto.MotorHacmi = 1599;
            oto.UretimYili = 2010;
            oto.Renk = Renk.Kırmızı;
            oto.IndirimYap(50);
            Console.WriteLine("Güncel Fiyat : " + oto.GetFiyat());

            Console.WriteLine("Yıllık Vergi : "+oto.YillikVergiHesapla());
            Console.WriteLine("ÖTV li Fiyat : "+oto.OTVHesapla());

        }
    }
}
