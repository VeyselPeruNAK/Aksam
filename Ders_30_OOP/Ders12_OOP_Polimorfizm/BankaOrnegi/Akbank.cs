using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BankaOrnegi
{
    class Akbank:Banka
    {
        public Akbank()
        {
            base._EFTUcreti = 30.0D;
        }
        public override void EFT()
        {
            Console.WriteLine($"Akbank: EFT {this._EFTUcreti}");
        }
    }
}
