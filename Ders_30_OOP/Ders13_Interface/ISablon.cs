using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface
{
    interface ISablon
    {
        string Marka { get; set; }
        string Model { get; set; }
        void BilgiYaz();
    }
}
