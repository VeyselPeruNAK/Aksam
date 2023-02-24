using System;
using Ders13_AbstractInterface_Together.VASITA_Sorusu;

namespace Ders13_AbstractInterface_Together
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil();
            oto.IlanN = 1;
            oto.KasaTipi = KasaTipi.sedan;
            oto.kaskoYap();

            Kamyon kmy = new Kamyon();
            kmy.IlanN = 2;
            kmy.KasaTipi = KasaTipi.kamyon;
            kmy.kaskoYap();
        }
    }
}
