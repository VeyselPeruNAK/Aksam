using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_001_Inheritance
{
    public enum Cinsiyet
    {
        Kadın, Erkek
    }

    public class Kisi
    {
        public string Ili { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TcKimlikNo { get; set; }

        public string kisiBilgileri()
        {
            StringBuilder sbd = new StringBuilder();
            sbd.Append("Ad:");
            sbd.AppendLine(Ad);
            sbd.Append("Soyad:");
            sbd.AppendLine(Soyad);
            sbd.Append("Doğum Tarihi:");
            sbd.AppendLine(DogumTarihi.ToShortDateString());
            sbd.Append("TC Kimlik No:");
            sbd.AppendLine(TcKimlikNo);

            return sbd.ToString();
        }
    }
}