using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_001_Inheritance
{
    public enum Alan
    {
        Sayısal,
        Sözel,
        Eşit_Ağırlık,
        Dil
    }
    class Ogrenci : Insan
    {
        public string Sinif { get; set; }
        public int OkulNo { get; set; }
        public Alan Alani { get; set; }
    }
}
