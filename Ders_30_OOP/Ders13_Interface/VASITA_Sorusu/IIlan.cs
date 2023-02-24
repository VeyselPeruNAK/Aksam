using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.VASITA_Sorusu
{
    interface IIlan
    {
        long IlanN { get; set; }
        DateTime IlanTarihi { get; set; }
        Kullanici Satici { get; set; }

    }
}
