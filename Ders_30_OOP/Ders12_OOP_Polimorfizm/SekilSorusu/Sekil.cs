using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Sekil
    {
        protected string _SekilAd;

        virtual public void CevreHesapla() { }
        virtual public void AlanHesapla() { }
    }
}
