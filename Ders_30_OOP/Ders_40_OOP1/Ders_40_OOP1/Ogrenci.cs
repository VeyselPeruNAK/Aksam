using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40_OOP1
{
    //Öğrenci sınıfını aşağıdaki özellik ve metotlarrı ile tanımlayınız.
    //Properties: tcKimlikNo, okulNo, ad, soyad, sinifOgretmeni
    //Methods: BilgiYaz()
    //Methods: SinifOgretmenDegistir(Ogretmen ogretmen)
    //Methods: 5 parametreli yapıcı metodu ekleyin. 

    internal class Ogrenci
    {
        public string tcKimlikNo;
        public long okulNo;
        public string ad;
        public string soyad;
        public Ogretmen sinifOgretmeni;

        
        public Ogrenci(string tcKimlikNo, long okulNo, string ad, string soyad, Ogretmen sinifOgretmeni)
        {
            this.tcKimlikNo = tcKimlikNo;
            this.okulNo = okulNo;
            this.ad = ad;
            this.soyad = soyad;
            this.sinifOgretmeni = sinifOgretmeni;
        }

        public void SinifOgretmenDegistir(Ogretmen ogretmen)
        {
            this.sinifOgretmeni = ogretmen;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Öğrenci TC: " + this.tcKimlikNo);
            Console.WriteLine("Öğrenci Okul No: " + this.okulNo);
            Console.WriteLine("Öğrenci Ad: " + this.ad);
            Console.WriteLine("Öğrenci Soyad: " + this.soyad);
            Console.WriteLine("Öğrenci Öğretmen: " + this.sinifOgretmeni.ad + " " + this.sinifOgretmeni.soyad);
        }
    }

}
