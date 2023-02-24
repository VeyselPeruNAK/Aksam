using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Abstract.SekilSorusu
{
    abstract class Sekil
    {
        // normal tanımlanmış bir özellik.
        protected string _SekilAd;

        public string SekilAd { get => _SekilAd; set => _SekilAd = value; }

        // Normal ranımlanmış bir metot.
        public void SekilAdYaz()
        {
            Console.WriteLine($"Şekil adı : " + this._SekilAd);
        }

        // Abstract metotlaarın amacı şudur:
        // benden miras alacak alt sınıflarda bu isimde bir metot tanımlanmalıdır.

        abstract public void CevreHesapla();
        abstract public void AlanHesapla();
    }
}
