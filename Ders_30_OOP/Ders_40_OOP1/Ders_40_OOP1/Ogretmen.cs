using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40_OOP1
{
    internal class Ogretmen
    {
        public int ID;
        public string ad;
        public string soyad;
        public List<Ogrenci> ogrenciler;
        //public List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public Ogretmen()
        {
            this.ogrenciler = new List<Ogrenci>();
            //Nesne oluştuğu anda RAM'de liste için alan açılır, 
            //liste oluşturulur. 
        }

        public void OgrenciListele()
        {
            Console.WriteLine("*****" + this.ad + " " + this.soyad + " öğretmeninin öğrencileri *****");
            foreach (Ogrenci ogr in this.ogrenciler)
            {
                Console.WriteLine(ogr.okulNo + " " + ogr.ad +  " " + ogr.soyad);
            }
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Öğretmen adı:" + this.ad);
            Console.WriteLine("Öğretmen soyadı:" + this.soyad);
        }
    }
}
