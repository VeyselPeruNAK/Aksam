using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Abstract.SekilSorusu
{
    class Dortgen:Sekil
    {
        public int en;
        public int boy;


        // Miras alınan sınıfta Abstract olarak ismi belirtilmiş ancak metohod gövdesi tanımlanmamış olan metotların gövdesini tanımlamak zorundayız.
        public override void AlanHesapla()
        {
            Console.WriteLine($"Dörtgen Alanı : {this.en*this.boy}");
        }

        public override void CevreHesapla()
        {
            Console.WriteLine($"Dörtgen Cevresi : { 2*(this.en + this.boy)}");
        }
    }
}
