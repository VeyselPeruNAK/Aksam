using System;
using Ders13_Interface.VASITA_Sorusu;
namespace Ders13_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTest nesne = new ClassTest();
            //nesne.Marka = "Honda";
            //nesne.Model = "Civic";
            //nesne.Fiyat = 1000;
            //Console.WriteLine(nesne.GetFiyat());


            //Kullanici k = new Kullanici();
            //k.AdSoyad = "Dilaver Çavuş";
            //k.Eposta = "cavus@gmail.com";
            //k.Telefon = "05558589332";
            //foreach (var bilgi in k.GetKullanici())
            //{
            //    Console.WriteLine(bilgi);
            //}       


            //Sigorta s = new Sigorta();
            //s.SigortaGuncelle();
            //Console.WriteLine("S N   : " + s.SigortaN);
            //Console.WriteLine("Bitiş : " + s.BitisTarihi);


            Araba a = new Araba();
            a.Marka = "Mercedes";
            a.Model = "SLK500";
            a.SigortaYap();

            Console.WriteLine(a.Sigorta.SigortaN);
            Console.WriteLine(a.Sigorta.BitisTarihi);

        }
    }
}
