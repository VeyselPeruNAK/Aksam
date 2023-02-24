using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Daire:Sekil
    {
        public int yariCap;
        public float pi=3.14f;

        public override void AlanHesapla()
        {
            Console.WriteLine($"Daire Alanı: {this.pi*this.yariCap*this.yariCap}");
        }

        public override void CevreHesapla()
        {
            Console.WriteLine($"Daire Çevresi: {this.pi * this.yariCap * 2}");

        }
    }
}
