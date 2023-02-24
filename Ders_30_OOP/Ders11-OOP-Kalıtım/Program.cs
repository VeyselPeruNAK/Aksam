using System;
using System.Threading;
using Ders11_OOP_Kalıtım.Sahibinden;
namespace Ders11_OOP_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            AltClass nesne = new AltClass();
            nesne.AdSoyad = "Salih Uçan"; // AltClass özelliği
            nesne.KayitTarihi = DateTime.Now; // AnaClass özelliği

            nesne.IlanTarihiYaz(); // AnaClass metodu.
            nesne.AdSoyadYaz();    // AltClass metodu.

            nesne.BilgiYaz();

            Thread.Sleep(5000);
            AltClass2 nesne2 = new AltClass2();
            nesne2.KayitTarihi = DateTime.Now;
            nesne2.Baslik = "uygun fiyatlı olta takımı.";

            nesne2.IlanTarihiYaz(); // AnaClass metodu.
            nesne2.BaslikYaz();     // AltClass2 metodu.

            AnaClass anaNesne = new AnaClass();
            anaNesne.KayitTarihi = DateTime.Parse("10.10.2020 15:00:00");
            anaNesne.IlanTarihiYaz();

            Kullanici Shakir = new Kullanici();
            Shakir.AdSoyad = "Şakir Demir";
            Shakir.Telefon = "0500000000";

            // TEST AMAÇLI TANIMLANDI.
            //Ilan ilan = new Ilan();
            //ilan.IlanN = 123123;
            //ilan.Fiyat = 100;
            //ilan.Baslik = "Şok İndirimler.";
            //ilan.IlanTarihi = DateTime.Now;
            //ilan.Satici = Shakir;
            //ilan.BilgiYaz();
            //ilan.IndirimYap(50);
            //Console.WriteLine(ilan.IlanN);

            Dizustu dzb = new Dizustu();
            dzb.Satici = Shakir;
            dzb.Kategori = Kategori.Dizüstü_Bilgisayar;
            dzb.IlanN = 1;
            dzb.IlanTarihi = DateTime.Now;
            dzb.Baslik = "Sağlam Disüstü Bilgisayar";
            dzb.Agirlik = 2.3f;
            dzb.Islemci = "AMD Ryzen 7";
            dzb.Fiyat = 10000.0D;
            dzb.Marka = "lenovo";
            dzb.Bellek = "32GB";
            dzb.HDD = 0;
            dzb.SSD = 1024;
            dzb.EthernetVarMi = true;
            dzb.WifiVarMi = true;
            dzb.EkranBoyutu = "14'";

            dzb.BilgiYaz();
            dzb.IndirimYap(10);

            Masaustu mst = new Masaustu();

            mst.Satici = Shakir;
            mst.Kategori = Kategori.Dizüstü_Bilgisayar;
            mst.IlanN = 1;
            mst.IlanTarihi = DateTime.Now;
            mst.Baslik = "Sağlam Masaüstü Bilgisayar";
            mst.Islemci = "AMD Ryzen 7";
            mst.Fiyat = 10000.0D;
            mst.Marka = "Lenovo";
            mst.Bellek = "32GB";
            mst.HDD = 0;
            mst.SSD = 1024;
            mst.EthernetVarMi = true;
            mst.WifiVarMi = true;
            mst.MonitorVarMi = false;
            mst.KasaTipi = KasaTipi.Yatay;

            mst.BilgiYaz();







            //AltClass altNesne = new AltClass(5, DateTime.Now, "Serhat KOŞAN");
            //Console.WriteLine(altNesne.ID);
            //Console.WriteLine(altNesne.KayitTarihi);
            //Console.WriteLine(altNesne.AdSoyad);
            //altNesne.BilgiYaz();



            EnAltClass enAltNesne = new EnAltClass(23, DateTime.Now, "Neslihan KARACA", "Uzun");
            //Console.WriteLine(enAltNesne.ID);
            //Console.WriteLine(enAltNesne.KayitTarihi);
            //Console.WriteLine(enAltNesne.AdSoyad);
            enAltNesne.BilgiYaz();

            //AnaClass test = new AnaClass();


        }
    }
}
