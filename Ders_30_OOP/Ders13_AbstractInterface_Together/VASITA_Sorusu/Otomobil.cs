using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_AbstractInterface_Together.VASITA_Sorusu
{
    enum YakitTipi { elektrik,benzin,dizel,hibrit,benzin_lpg }
    enum VitesTipi { manuel,otomatik,yarı_otomatik,triptonik}
    enum KasaTipi { sedan,hatcback,station,kamyon,kamyonet}
    class Otomobil : Arac
    {
        public Otomobil()
        {
            this.IlanTarihi = DateTime.Now;
        }

        public override void kaskoYap()
        {
            Console.WriteLine("otomobil kasko yapıldı.");
        }

        public override void vergiHesapla()
        {
            Console.WriteLine("otomobil vergisi hesaplandı.");
        }
    }
}
