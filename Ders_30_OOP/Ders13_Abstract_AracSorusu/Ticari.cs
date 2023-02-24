using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Abstract_AracSorusu
{
    class Ticari:Arac
    {
        private float _TasimaKapasitesi;

        public float TasimaKapasitesi { get => _TasimaKapasitesi; set => _TasimaKapasitesi = value; }

        public override float OTVHesapla()
        {
            if (this.MotorHacmi >= 1000 && this.MotorHacmi < 1600)
                this.OTVFiyat = this.Fiyat * 1.05f;
            else if (this.MotorHacmi < 2000)
                this.OTVFiyat = this.Fiyat * 1.10f;
            else
                this.OTVFiyat = this.Fiyat * 1.15f;

            return this.OTVFiyat;
        }

        public override float YillikVergiHesapla()
        {
            if (this.MotorHacmi < 1000)
                this.YillikVergi = this.Fiyat * 1.02f;
            else if (this.MotorHacmi < 1600)
                this.YillikVergi = this.Fiyat * 1.05f;
            else if (this.MotorHacmi < 2000)
                this.YillikVergi = this.Fiyat * 1.08f;
            else
                this.YillikVergi = this.Fiyat * 1.1f;

            short yil = Convert.ToInt16(DateTime.Now.Year);
            short yas = Convert.ToInt16((yil - this.UretimYili));
            if (yas < 5)
                this.YillikVergi += this.Fiyat * 1.03f;
            else if (yas < 10)
                this.YillikVergi += this.Fiyat * 1.02f;
            else
                this.YillikVergi += this.Fiyat * 1.01f;

            this.YillikVergi *= 2; // 6 ayda bir alındığı için 2 ile çarptık.

            return this.YillikVergi;
        }

    }
}
