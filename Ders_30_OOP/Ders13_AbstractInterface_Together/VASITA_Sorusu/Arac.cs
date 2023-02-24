using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_AbstractInterface_Together.VASITA_Sorusu
{
    abstract class Arac : IVasita, IIlan
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public long IlanN { get; set; }
        public DateTime IlanTarihi { get; set; }
        public Kullanici Satici { get; set; }

        public Sigorta Sigorta { get; set; }

        public KasaTipi KasaTipi { get; set; }

        public void SigortaYap()
        {
            this.Sigorta = new Sigorta();
        }

        abstract public void vergiHesapla();

        abstract public void kaskoYap();
    }
}
