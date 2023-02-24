using System;
using Ders12_OOP_Polimorfizm.PersonelSorusu;
using Ders12_OOP_Polimorfizm.Konu;
using Ders12_OOP_Polimorfizm.BankaOrnegi;
using Ders12_OOP_Polimorfizm.LokantaOrnegi;
using Ders12_OOP_Polimorfizm.SekilSorusu;

namespace Ders12_OOP_Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÖNCEKİ DERSİN ÖRNEĞİ


            //Personel p1 = new Personel("Bahadır Çehov",DateTime.Parse("05.05.1986 12:00:00"),Bolum.Hukuk);
            //p1.BilgiYaz();
            //Personel p2 = new Personel("Mehmet Teker", DateTime.Parse("10.10.1986 12:00:00"), Bolum.Yazılım);
            //p2.BilgiYaz();

            //Yonetici y1 = new Yonetici();
            //y1.PersonelSayisi = 25;
            //y1.Bolum = Bolum.IT;
            //y1.AdSoyad = "Serthat GÜL";
            //y1.DogumTarihi = DateTime.Parse("06.06.1990 12:00:00");
            //y1.BilgiYaz();






            // POLIMORFIZM
            //Tek bir metot çağırarak farklı işlemler yapabilmemizi sağlar.
            // yani: Bir metodu çağırarak o metotun farklı metotları çağırabilmesini sağlar.
            // Bu olaya : LATE BINDING denir.
            // New anahtar kelimesinden farklı olarak üst sınıftaki metodu tamamen silmez. Üst ısnıf emtodu da alt sınıf metodu da kullanılabilr.
            // Üst sınıf nesnesi aracılığı ile alt sınıf metoduna erişilebilir.









            //Kedi tekir = new Kedi();
            ////tekir.SesCikar();

            //Kopek kangal = new Kopek();
            ////kangal.SesCikar();

            //Hayvan hayvan = new Hayvan();
            ////hayvan = tekir;
            ////hayvan.SesCikar();

            //SesCikar(kangal);
            //SesCikar(tekir);

            //Garanti grnt = new Garanti();
            //Akbank akbn = new Akbank();
            //Halkbank hlk = new Halkbank();

            //EFT(grnt);
            //EFT(akbn);
            //EFT(hlk);

            /* Lokanta Yazılımı
                 * BelediyeHarcOde() isminde metot var.
                 * Genelde harç ücreti 6 aylık 3000 TL iken aşağıdaki illerde farklılık göstermekte.
                 * LokantaTokat : 2000
                 * LokantaYozgat: 1500
                 * LokantaMersin: 3500
                 * Bu illler için polimorfizm yapısnı kullanarak farklı metot tanımlayınız.

                 * BelediyeHarcOde()
                 * {
                 *      Console.WriteLine("Harç Ödemesi: 3000 TL'dir.");
                 * } 
                 */

            //Lokanta mersin = new LokantaMersin(); // üst sınıf nesnesine atadık.
            //LokantaTokat tokat = new LokantaTokat();
            //LokantaYozgat yozgat = new LokantaYozgat();


            ////mersin.HarcOde();

            //HarcOde(mersin);
            //HarcOde(tokat);
            //HarcOde(yozgat);


            // Sekil: SekilAd AlanHesapla() CevreHesapla()
            // Ucgen: yukseklik,taban,kenar1,kenar2
            // Dortgen: en,boy
            // Daire: yariCap,pi=3.14   (Ç: )




            Dortgen drt = new Dortgen();
            drt.en = 10;
            drt.boy = 20;

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


        static void HarcOde(Lokanta nesne)
        {
            nesne.HarcOde();
        }
        static void EFT(Banka bnk)
        {
            bnk.EFT();
        }


        static void SesCikar(Hayvan hyvn)
        {
            hyvn.SesCikar();
        }

    }
}
