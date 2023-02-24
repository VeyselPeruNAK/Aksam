using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.VASITA_Sorusu
{
    enum YakitTipi { elektrik,benzin,dizel,hibrit,benzin_lpg }
    enum VitesTipi { manuel,otomatik,yarı_otomatik,triptonik}
    enum KasaTipi { sedan,hatcback,station}
    class Araba : IVasita, IIlan
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public long IlanN { get; set; }
        public DateTime IlanTarihi { get; set; }
        public Kullanici Satici { get; set; }
        public short MotorHacmi { get; set; }
        public Sigorta Sigorta { get; set; }

        public Araba()
        {
            this.IlanTarihi = DateTime.Now;
        }

        public void SigortaYap()
        {
            this.Sigorta = new Sigorta();
        }
    }
}
