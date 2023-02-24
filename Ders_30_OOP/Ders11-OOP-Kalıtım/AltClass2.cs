using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım
{
    class AltClass2:AnaClass
    {
        public string Baslik;

        public void BaslikYaz()
        {
            Console.WriteLine($"Başlık: {this.Baslik}");
        }

    }
}
