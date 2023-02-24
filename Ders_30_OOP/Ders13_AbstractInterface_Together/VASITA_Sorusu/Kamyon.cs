using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_AbstractInterface_Together.VASITA_Sorusu
{
    class Kamyon : Arac
    {
        public short TasimaKapasitesi { get; set; }
        public override void kaskoYap()
        {
            Console.WriteLine("kamyon kasko yapıldı.");
        }

        public override void vergiHesapla()
        {
            Console.WriteLine("kamyon vergisi hesaplandı.");
        }
    }
}
