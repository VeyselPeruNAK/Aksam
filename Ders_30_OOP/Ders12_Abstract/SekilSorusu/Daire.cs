using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Abstract.SekilSorusu
{
    class Daire : Sekil
    {
        public int yariCap;
        public double pi = 3.14d;

        public override void AlanHesapla()
        {
            Console.WriteLine($"Daire Alanı: {this.pi * this.yariCap * this.yariCap}");
        }

        public override void CevreHesapla()
        {
            double d = this.pi * this.yariCap * 2;
            string dstr = d.ToString("######.##");

            Console.WriteLine($"Daire Çevresi: " + dstr);

        }
    }
}
