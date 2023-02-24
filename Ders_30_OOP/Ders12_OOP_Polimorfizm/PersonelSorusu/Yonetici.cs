using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.PersonelSorusu
{
    class Yonetici:Personel
    {
        private short _PersonelSayisi;

        public short PersonelSayisi { get => _PersonelSayisi; set => _PersonelSayisi = value; }

        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine(this.PersonelSayisi);
        }

        public Yonetici() { }
        public Yonetici (string adSoyad, DateTime dogumTarihi, Bolum bolum,short personelSayisi):base(adSoyad, dogumTarihi,bolum)
        {
            this.PersonelSayisi = personelSayisi;
        }

    }
}
