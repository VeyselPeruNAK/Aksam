using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Ucgen:Sekil
    {
        public int yukseklik, taban, kenar1, kenar2;

        public override void AlanHesapla()
        {
            Console.WriteLine($"Üçgen Alanı: {this.taban *(this.yukseklik /2)}");
        }

        public override void CevreHesapla()
        {
            Console.WriteLine($"Üçgen Çevresi: {taban+kenar1+kenar2}");    
        }
    }
}
