using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40_OOP1
{
    internal class Derslik
    {
        public int derslikN;
        public string adi;
        public int kapasite;
        public int kat;
        public Ogretmen ogretmen;

        public Derslik()
        {
            //this.ogretmen = new Ogretmen();
        }

        public Derslik(int derslikN, string adi, int kapasite, int kat, Ogretmen ogretmen)
        {
            this.derslikN = derslikN;
            this.adi = adi;
            this.kapasite = kapasite;
            this.kat = kat;
            this.ogretmen = ogretmen;

        }

        public void BilgiYaz()
        {
            Console.WriteLine("*****" + this.adi + " SINIFI BİLGİLERİ  *****");
            Console.WriteLine(" Kapasite:" + kapasite);
            Console.WriteLine(" Kat:" + kat);
            if (this.ogretmen != null)
            {

                Console.WriteLine(" Sınıf Öğretmeni:" + this.ogretmen.ad + " " + this.ogretmen.soyad);
                Console.WriteLine(" Kullanılan Kapasite:" + ogretmen.ogrenciler.Count());
            }
            else
            {
                Console.WriteLine(" Sınıf Öğretmeni: YOK");
                Console.WriteLine(" Kullanılan Kapasite: 0");
            }
        }
        public void OgretmenAta(Ogretmen ogretmen)
        {
            if (ogretmen.ogrenciler.Count() <= this.kapasite)
            {
                this.ogretmen = ogretmen;
                Console.WriteLine(ogretmen.ad + " " + ogretmen.soyad + " ataması başarılı");
            }
            else
            {
                Console.WriteLine("Atama başarısız, sınıf kapasitesi yetersiz!");
            }
        }

    }
}
