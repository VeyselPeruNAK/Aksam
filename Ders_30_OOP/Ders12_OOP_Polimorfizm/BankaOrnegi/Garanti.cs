using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BankaOrnegi
{
    class Garanti:Banka
    {
        public Garanti()
        {
            base._EFTUcreti = 20.0D;
        }

        public override void EFT()
        {
            Console.WriteLine($"Garanti EFT Ücreti : {this._EFTUcreti}");
        }
    }
}
