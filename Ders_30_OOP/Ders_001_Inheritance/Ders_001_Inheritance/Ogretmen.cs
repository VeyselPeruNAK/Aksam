using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_001_Inheritance
{
    class Ogretmen : Memur
    {
        public string Bransi { get; set; }
        public string Sinifi { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi + " " + TCKN + " " + DogumTarihi.ToShortDateString() + " " + Bransi + " " + Sinifi;
        }

    }
}
