using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_40_OOP1
{
    public enum Cinsiyet
    {
        Kadın, Erkek
    }
    internal class Kisi
    {
        public string Ad   { get; set; }
        public string Soyad 
        {
            get; set;
        }
        public DateTime DogumTarihi
        {
            get; set;
        }
        public Cinsiyet Cinsiyeti
        {
            get; set;
        }
        public string TCKimlikNo
        {
            get; set;
        }
        public string Ili
        {
            get; set;
        }


        //YAPICI METOTLAR: Constructor
        //Metot adı sınıf adı ile aynı olmalıdır! public olmalıdır.
        //Tanımlanmasa da boş hali arka planda çalışır. 
        public Kisi()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }

        public string kisiBilgileri()
        {
          StringBuilder sbd = new StringBuilder();
            sbd.AppendLine("Ad:" + Ad);
            sbd.AppendLine("Soyad:" + Soyad);
            sbd.AppendLine("Doğum Tarihi:" + DogumTarihi.ToShortDateString());
            sbd.AppendLine("TC Kimlik No:" + TCKimlikNo);
            sbd.AppendLine("Cinsiyeti:" + Cinsiyeti);
            //sbd.AppendLine(Cinsiyeti.ToString());
            sbd.AppendLine("İli:" + Ili);

            return sbd.ToString();


        }

    }
}
