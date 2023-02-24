using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface.VASITA_Sorusu
{
    class Sigorta
    {
        static int sayac = 0;
        private string _SigortaN { get; set; }
        public string SigortaN { get { return this._SigortaN; } }

        private DateTime _BitisTarihi {get;set;}
        public DateTime BitisTarihi { get { return this._BitisTarihi; } }

        public Sigorta() // new Sigorta();
        {
            sayac += 1; // her nesne oluştutulduğunda sayac 1 artar.
            SigortaGuncelle(); // nesne oluşutulunca bilgiler otomatik oluşturulur.
        }

        private string SigortaNUret()
        {
            string strSayac = sayac.ToString();
            if (strSayac.Length < 2)
                strSayac = "00" + strSayac;
            else if (strSayac.Length < 3)
                strSayac = "0" + strSayac;

            string sigortaN = "";
            sigortaN += DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + strSayac;

            return sigortaN;
        }
        public void SigortaGuncelle()
        {
            this._SigortaN = SigortaNUret();
            this._BitisTarihi = DateTime.Now.AddYears(1);
        }







    }
}
