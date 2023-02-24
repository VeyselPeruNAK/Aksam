using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Abstract_AracSorusu
{
    enum Renk { Kırmızı,Beyaz,Siyah,Gri,Yeşil,Sarı,Mor,Mavi }
    class Otomobil : Arac
    {
        private byte _KapiSayisi;
        private Renk _Renk;

        public byte KapiSayisi { get => _KapiSayisi; set => _KapiSayisi = value; }
        internal Renk Renk { get => _Renk; set => _Renk = value; }



        public override float OTVHesapla()
        {
            if (this.MotorHacmi < 1000)
                this.OTVFiyat = this.Fiyat * 1.05f;
            else if(this.MotorHacmi<1600)
                this.OTVFiyat = this.Fiyat * 1.01f;
            else if (this.MotorHacmi < 2000)
                this.OTVFiyat = this.Fiyat * 1.15f;
            else
                this.OTVFiyat = this.Fiyat * 1.2f;

            return this.OTVFiyat;
        }

        public override float YillikVergiHesapla()
        {
            if (this.MotorHacmi < 1000)
                this.YillikVergi = this.Fiyat * 0.02f;
            else if (this.MotorHacmi < 1600)
                this.YillikVergi = this.Fiyat * 0.05f;
            else if (this.MotorHacmi < 2000)
                this.YillikVergi = this.Fiyat * 0.08f;
            else
                this.YillikVergi = this.Fiyat * 0.1f;

            short yil = Convert.ToInt16(DateTime.Now.Year);
            short yas = Convert.ToInt16((yil - this.UretimYili));
            if (yas < 5)
                this.YillikVergi += this.Fiyat * 0.05f;
            else if(yas < 10)
                this.YillikVergi += this.Fiyat * 0.04f;
            else
                this.YillikVergi += this.Fiyat * 0.03f;

            this.YillikVergi /= 2; // 2 Yılda bir alındığı için 2'ye böldük.

            return this.YillikVergi;
        }
    }
}

