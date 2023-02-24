using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_AbstractInterface_Together.VASITA_Sorusu
{
    class Kullanici
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

        public List<string> GetKullanici()
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(this.AdSoyad);
            bilgiler.Add(this.Eposta);
            bilgiler.Add(this.Telefon);
            return bilgiler;
        }
    }
}
