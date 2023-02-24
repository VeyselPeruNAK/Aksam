using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.Konu
{
    class Kedi:Hayvan
    {
        // new anahtar kelimesi ile metodu tekrar tanımladığımızda metotu iptal eder. Ve buradaki baskın olur.

        override public void SesCikar() 
        {
            Console.WriteLine("Miyav");
        }
    }
}
