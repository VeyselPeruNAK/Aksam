using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.Konu
{
    // sealed anahtar kelimesi miras alınmasını engeller.
    //sealed class Hayvan
    class Hayvan
    {

        virtual public void SesCikar()
        {
            Console.WriteLine("Benim hangi hayvan olduğum belli değil. Ses çıkaramam.");
        }

    }
}
