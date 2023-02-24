using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ders12_OOP_Polimorfizm.LokantaOrnegi
{
    class Lokanta
    {
        protected double _HarcMiktari;

        public Lokanta()
        {
            this._HarcMiktari = 3000.0D;
        }

        virtual public void HarcOde()
        {
            Console.WriteLine($"Lokanta Sınıfı: Harç Miktarı : {this._HarcMiktari} ");
        }
    }
}
