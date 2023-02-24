using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım
{
    class EnAltClass:AltClass
    {
        private string _Ozellik;

        public string Ozellik { get => _Ozellik; set => _Ozellik = value; }

        public EnAltClass() { }
        public EnAltClass(int id, DateTime kayitTarihi, string adSoyad,string ozellik):base(id,kayitTarihi,adSoyad)
        {
            this._Ozellik = ozellik;
        }
        public EnAltClass(string ozellik)
        {
            this._Ozellik = ozellik;
        }

        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine(base.Test); 
            Console.WriteLine($"Özellik : {this.Ozellik}");
        }

    }
}
