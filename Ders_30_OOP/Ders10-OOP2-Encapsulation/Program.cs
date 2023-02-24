using System;
using System.Threading;
namespace Ders10_OOP2_Encapsulation
{
    //enum Gunler
    //{
    //    Pazartesi, // 0
    //    Salı,      // 1
    //    Çarşamba,  // 2
    //    Perşembe,  // 3
    //    Cuma,      // 4
    //    Cumartesi, // 5
    //    Pazar      // 6
    //}
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.setAdSoyad("Mehmet Demir");
            Console.WriteLine(u1.getAdSoyad());
            u1.setAdSoyad("    "); // whitespace yani boşluk gönderdik.
            Console.WriteLine(u1.getAdSoyad());
            u1.Adres = "Çekmeköy";

            u1.Telefon = "05462923058";



            DateTime baslama = DateTime.Now;
            Console.WriteLine(baslama);
            Thread.Sleep(5000); // 5 saniye bekle.
            DateTime bitis = DateTime.Now;
            Console.WriteLine(bitis);
            TimeSpan fark = bitis - baslama;
            Console.WriteLine(fark.Seconds);

            /*
             BİSİKLET KİRALAMA YAZILIMI
            Bisiklet: ID,Marka,Model,JantBoyutu,VitesSayisi 
            Kullanici: ID,AdSoyad,Telefon

            Kiralama: ()ID,Bisiklet,Kullanici,Sure,Ucret=,BaslamaZamani,BitisZamani,
            DakikaUcret=0.25
            
            
            Metotlar: 
            KiralamaBaslat() => BaşlamaZamanini tut. 

            KiralamaBitir() => BitisZamanini tut.
            
            UcretHesapla() => Bitis ve başlangıç arasındaki farkı tutup ücreti hesaplayıp döndürecek.(double)

            BilgiYaz() => Şu zamanda başladınız bu zamanda bitirdiniz.
            Toplam ... dakika kullandınız. Ödemen,z gereken ücret ... liradır.
            
               https://codeshare.io/NA203
            */





            Kullanici ahmet = new Kullanici();
            ahmet.AdSoyad = "Ahmet Yusuf YILMAZ";

            Bisiklet bisan = new Bisiklet();
            bisan.Marka = "Bisan";

            Kiralama kiralama = new Kiralama();
            kiralama.Kullanici = ahmet;
            kiralama.Bisiklet = bisan;

            kiralama.Baslat();
            Thread.Sleep(10000); // 10 saniye bekle.
            kiralama.Bitir();

            Console.ReadLine();

            //Gunler gun = Gunler.Pazartesi;


            Kuafor kuafor = new Kuafor();

            Kullanici kullanici = new Kullanici();
            kullanici.kuafor = kuafor;

            float cilt = kullanici.kuafor.ciltBakimiUcreti;
            float sac = kullanici.kuafor.sacTirasiUcreti;
            float sakal = kullanici.kuafor.sakalTrasiUcreti;

            kullanici.kuafor.SacTrasiYap();
            kullanici.kuafor.SacYika();

            kullanici.kuafor.BilgiYaz();
            Console.ReadLine();

            //

            // Açık artırmanuygulaması:
            // Urun : ID, Ad, BaslamaZ, IlandaKalmaSuresi,List<Teklif>
            // Basla(). Başlama zamanını tutacak.
            // TeklifKontrol() : yayın süresi içindeyse gelen teklifi alıp listeye ekleyecek.
            // Sonuclandir(): süre dolduğuysa teklifleri ekrana yazdıracak. Ve en yüksek teklifi kazanan olarak yazacak.


            // Teklif: ID,Kullanici,Urun,Fiyat

            // Kullanici tanımlı.

















        }
    }
}
