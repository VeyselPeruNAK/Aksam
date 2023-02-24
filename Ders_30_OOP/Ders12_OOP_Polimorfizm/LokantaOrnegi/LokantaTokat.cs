using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.LokantaOrnegi
{
    class LokantaTokat:Lokanta
    {
       public LokantaTokat()
        {
            this._HarcMiktari = 2000.0D;
        }

        public override void HarcOde()
        {
            Console.WriteLine($"LokantaTokat Sınıfı: Harç Miktarı : {this._HarcMiktari}");
        }
    }
}
