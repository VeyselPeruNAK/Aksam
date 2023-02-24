
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface
{
    enum Kategori { Otomobil,Emlak,Beyaz_Eşya,Mobilya }
    interface ISablon2
    {
        string ID { get; set; }
        double Fiyat { set; }

        Kategori Kategori { get; set; }
        double GetFiyat();

    }
}


/*
 Interfaceler
--------------
IVasita : Marka,Model
IIlan   : IlanN,IlanTarihi,Satici(Kullanici) 

Sınıflar
--------------
Kullanici: AdSoyad,Eposta,Telefon GetKullanici()=> Bilgilerini döndürsün. Bilgileri Liste ile döndürün.
Sigorta  : SigortaN,BitisTarihi SigortaNumarası: 20211125_001  =>  001 otomatik olarak artsın.
   SigortaGuncelle() => Sigorta Bitis Tarihi: güncellensin

Araba    : enum YakitTipi,enum VitesTipi, enum KasaTipi, float Motorhacmi, Sigorta Nesnesi.

         : SigortaYap()=>Sigorta nesnesi metot çağırıldığında oluşturulsun. Sigorta.SigortaGuncelle() metodu çağırılsın.






*/