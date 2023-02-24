using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.PersonelSorusu
{
    enum Bolum
    {
        Muhasebe,Yazılım,IT,IK,Satın_Alma,Hukuk,Satış
    }
    class Personel
    {
        static int ID_Counter = 0;
        // BU SORUDA POLIMORFIZM YOKTUR !!!

        

        public int ID { get => _ID; set => _ID = value; }
        public string AdSoyad { get => _AdSoyad; set => _AdSoyad = value; }
        public DateTime DogumTarihi { get => _DogumTarihi; set => _DogumTarihi = value; }
        internal Bolum Bolum { get => _Bolum; set => _Bolum = value; }

        private int _ID;
        private string _AdSoyad;
        private DateTime _DogumTarihi;
        private Bolum _Bolum;

        public void BilgiYaz()
        {
            int yas = DateTime.Now.Year - DogumTarihi.Year;
            Console.WriteLine(this.ID);
            Console.WriteLine(this.AdSoyad);
            Console.WriteLine(yas);
            Console.WriteLine(this.Bolum);
        }

        public Personel() { 
            this.ID = ID_Counter;
            ID_Counter += 1;
        }
        public Personel(string adSoyad,DateTime dogumTarihi,Bolum bolum)
        {
            this.AdSoyad = adSoyad;
            this.DogumTarihi = dogumTarihi;
            this.Bolum = bolum;
            this.ID = ID_Counter;
            ID_Counter += 1;
        }

    }
}
