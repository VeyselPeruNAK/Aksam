using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım
{
    class AltClass : AnaClass  // Kalıtım yolu ile Miras aldık.
    {
        private string _AdSoyad;
        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set { this._AdSoyad = value; }
        }



        public AltClass()
        {

        }
        public AltClass(int id, DateTime kayitTarihi, string adSoyad) : base(id, kayitTarihi)
        {
            this._AdSoyad = adSoyad;
        }






        //new public DateTime KayitTarihi; // üst sınıftaki özelliği bastırır.

        public void AdSoyadYaz()
        {
            Console.WriteLine($"Ad Soyad: {this.AdSoyad}");
        }


        new public void BilgiYaz() // üst sınıftaki metodu bastırır.
        {
            //Console.WriteLine($"ID: {base.ID}"); //AltClass'tan AnaClass'taki özelliğe erişim.
            //Console.WriteLine($"Kayit Tarihi: {base.KayitTarihi}");  //AltClass'tan AnaClass'taki özelliğe erişim.
            base.BilgiYaz();  // Ana sınıftaki BilgiYaz metodunu çağırdık.
            Console.WriteLine(base.Test);
            Console.WriteLine($"Ad Soyad: {this.AdSoyad}");
        }
    }
}
