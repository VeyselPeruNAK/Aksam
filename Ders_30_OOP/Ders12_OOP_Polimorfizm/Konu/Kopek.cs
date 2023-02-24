using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.Konu
{
    class Kopek:Hayvan
    {
        override public void SesCikar()
        {
            Console.WriteLine("Hav hav");
        }
    }
}
