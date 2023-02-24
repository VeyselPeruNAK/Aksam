using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.LokantaOrnegi
{
    class LokantaMersin : Lokanta
    {
        public LokantaMersin()
        {
            this._HarcMiktari = 3500.0D;
        }
        public override void HarcOde()
        {
            Console.WriteLine($"LokantaMersin Sınıfı: Harç Miktarı : {this._HarcMiktari}");
        }
    }
}
