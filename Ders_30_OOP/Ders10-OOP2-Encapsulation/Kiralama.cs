using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation
{
    class Kiralama
    {
        // ID,Bisiklet,Kullanici,Sure,Ucret=,BaslamaZamani,BitisZamani,
        private int _ID;
        private Bisiklet _Bisiklet;
        private Kullanici _Kullanici;
        private float _Sure;
        private float _Ucret;
        private DateTime _BaslamaZamani;
        private DateTime _BitisZamani;
        //private float _DakikaUcreti;
        private float _SaniyeUcreti;

        public Kiralama()
        {
            this._SaniyeUcreti = 0.25f; // varsayılan değer ataması yapıcı metotta yapılabilir.
        }


        public Bisiklet Bisiklet
        {
            get { return this._Bisiklet; }
            set { this._Bisiklet = value; }
        }
        public Kullanici Kullanici
        {
            get { return this._Kullanici; }
            set { this._Kullanici = value; }
        }

        public void Baslat()
        {
            this._BaslamaZamani = DateTime.Now;
        }
        public void Bitir()
        {
            this._BitisZamani = DateTime.Now;
            this.UcretHesapla();
        }

        public void UcretHesapla()
        {
            TimeSpan zamanFarki = this._BitisZamani - this._BaslamaZamani;
            int farkSaniye = zamanFarki.Seconds;
            Console.WriteLine("Fark" + farkSaniye);
            this._Sure = (float)farkSaniye;
            this._Ucret = this._Sure * this._SaniyeUcreti;
            this.BilgiYaz();
        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Sayın {this.Kullanici.AdSoyad};\nBaşlama zamanı : {this._BaslamaZamani}\nBitiş zamanı : {this._BitisZamani}\nToplam süre : {this._Sure}\nToplam ödemeniz gereken tutar : {this._Ucret} TL dir.");
        }








    }
}
