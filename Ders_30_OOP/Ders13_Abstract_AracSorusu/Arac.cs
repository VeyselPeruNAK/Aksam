using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Abstract_AracSorusu
{
    abstract class Arac
    {
        private int _ID;
        private short _MotorHacmi;
        private byte _VitesSayisi;
        private float _Fiyat;
        private float _OTVFiyat;
        private short _UretimYili;
        private float _YillikVergi;

        public int ID { get => _ID; set => _ID = value; }
        public short MotorHacmi { get => _MotorHacmi; set => _MotorHacmi = value; }
        public byte VitesSayisi { get => _VitesSayisi; set => _VitesSayisi = value; }
        public float Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public float OTVFiyat { get => _OTVFiyat; set => _OTVFiyat = value; }
        public short UretimYili { get => _UretimYili; set => _UretimYili = value; }
        public float YillikVergi { get => _YillikVergi; set => _YillikVergi = value; }


        public void IndirimYap(byte indirimOrani)
        {
            this.Fiyat = this.Fiyat - (this.Fiyat * indirimOrani / 100);
        }
        public float GetFiyat()
        {
            return this.Fiyat;
        }

        abstract public float OTVHesapla();
        abstract public float YillikVergiHesapla();
    }
}
