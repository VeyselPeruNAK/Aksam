using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kisi kisi = new Kisi();
            //Kisi kisi2 = new Kisi();
            //kisi.Ad = "Fevzi";
            //kisi.Soyad = "Kaya";
            //kisi.Ili = "Sivas";
            //kisi.Cinsiyeti = Cinsiyet.Erkek;
            //kisi.DogumTarihi = Convert.ToDateTime("1990.12.25");
            //kisi.TCKimlikNo = "12345678901";

            //Console.WriteLine(kisi.kisiBilgileri());
            //Console.WriteLine("------------------------");
            //Console.WriteLine(kisi2.kisiBilgileri());
            //Console.ReadLine();

            //Araba araba1 = new Araba(1,"Hyundai","Accent Era");
            //Araba araba2 = new Araba();

            //int sayac = 0;
            //Araba[] Arabalar = new Araba[100];
            //Araba araba1 = new Araba();
            //araba1.ID= 1;
            //araba1.Marka= "Hyundai";
            //araba1.Model = "Accent Era";
            //Arabalar[sayac] = araba1;
            ////araba1.BilgiYaz();
            ////Arabalar[sayac].BilgiYaz();

            //sayac++;
            //Araba araba2 = new Araba();
            //araba2.ID = 2;
            //araba2.Marka = "Opel";
            //araba2.Model = "Astra";
            //Arabalar[sayac] = araba2;
            ////araba1.BilgiYaz();

            //sayac++;
            //Araba araba3 = new Araba();
            //araba3.ID = 3;
            //araba3.Marka = "Citroen";
            //araba3.Model = "Cactus";
            //Arabalar[sayac] = araba3;
            ////araba1.BilgiYaz();
            ////Arabalar[sayac].BilgiYaz();

            //for (int i = 0; i <= sayac; i++)
            //{
            //    Arabalar[i].BilgiYaz();
            //}

            Ogretmen ahmetOgretmen = new Ogretmen();
            ahmetOgretmen.ID = 1;
            ahmetOgretmen.ad = "Ahmet";
            ahmetOgretmen.soyad = "Gürbüz";

            Ogrenci mehmet = new Ogrenci("4444444", 144, "Mehmet", "Demir", ahmetOgretmen);
            mehmet.BilgiYaz();
            Ogrenci huseyin = new Ogrenci("5555555", 452, "Hüseyin", "Çelik", ahmetOgretmen);
            huseyin.BilgiYaz();
            Ogrenci murat = new Ogrenci("6666666", 655, "Murat", "Arkın", ahmetOgretmen);
            murat.BilgiYaz();

            Ogretmen hasanOgretmen = new Ogretmen();
            hasanOgretmen.ID = 2;
            hasanOgretmen.ad = "Hasan";
            hasanOgretmen.soyad = "Helvacı";

            mehmet.SinifOgretmenDegistir(hasanOgretmen);
            mehmet.BilgiYaz();

            ahmetOgretmen.ogrenciler.Add(mehmet);
            ahmetOgretmen.ogrenciler.Add(huseyin);
            ahmetOgretmen.ogrenciler.Add(murat);
            //Console.WriteLine(  "ÖĞRENCİ SAYISI=" + ahmetOgretmen.ogrenciler.Count());

            ahmetOgretmen.BilgiYaz();
            ahmetOgretmen.OgrenciListele();

            //Derslik isimli sınıfı aşağıdaki özellik ve metotlarla tanımlayınız:
            //Properties: derslikN, adi, kapasite(int), kat(int), ogretmen
            //OgretmenAta(ogretmen) => Dersliğin öğretmenini değiştir, öğretmenin
            //öğrenci sayısı sınıf kapasitesine sığıyorsa yap yoksa yapma hata ver!
            //BilgiYaz: adi, kapasite(int), kat(int),Sınıf Öğretmeni, Kullanılan
            //Kapasite(=Öğretmenin öğrenci sayısı.)

            Derslik d201 = new Derslik();
            d201.adi = "D201";
            d201.kapasite = 25;
            d201.kat = 2;
            d201.derslikN = 1;
            d201.BilgiYaz();
            d201.OgretmenAta(ahmetOgretmen);
            Console.WriteLine("===============");
            d201.BilgiYaz();

            Derslik d303 = new Derslik(2, "D303", 12, 3, ahmetOgretmen);
            Console.ReadLine();


        }
    }
}
