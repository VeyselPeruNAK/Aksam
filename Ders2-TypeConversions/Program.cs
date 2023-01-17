using System;

namespace Ders2_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
        ////////////////////////////
        // Bilinçsiz Tür Dönüşümü //
        ////////////////////////////

        // Küçük Tür Bütük Türe Otomatik olarak dönüştürülür.

        //byte byteSayi = 58;
        //int intSayi = byteSayi;

        //short shortSayi = 34;
        //long longSayi = shortSayi;

        //float floatSayi = 29.45f;
        //double doubleSayi = floatSayi;

        //Console.WriteLine("Sorunsuz Çalıştı.");


        ////////////////////////////////////
        // Kasıtlı Tür Dönüşümü : Casting //
        ////////////////////////////////////



        //int intSayi = 305;
        //byte byteSayi = (byte)intSayi;
        //Console.WriteLine("Sorunsuz çalıştı."+ byteSayi);
        //// int sayi 255'den büyük olursa. 32 bitlik değerin sadece son 8 biti alınacağından veri kaybı olur.

        //double doubleSayi = 45000.78D;
        //float floatSayi = (float)doubleSayi;

        //float fSayi = 77.345f;
        //int iSayi = (int)fSayi;
        //Console.WriteLine($"fSayi = {fSayi}, iSayi = {iSayi}");
        //// fSayi = 77,345, iSayi = 77


        // Veri Kaybı Var !!!
        //int intSayi = 256; // 00000000 00000000 00000001 00000000 = 256
        //byte byteSayi = (byte)intSayi; // En sağdaki 8 biti alır.
        //Console.WriteLine($"byteSayi = {byteSayi}");

        // Yukarıdaki veri kaybı önlemek.
        // Veri Kaybı Durumunda Hata Var!
        //checked
        //{
        //    //int intSayi = 256; // 00000000 00000000 00000001 00000000 = 256
        //    //byte byteSayi = (byte)intSayi; // En sağdaki 8 biti alır.
        //    //Console.WriteLine($"byteSayi = {byteSayi}");
        //    //// System.OverflowException hatası verir.
        //    unchecked
        //    {
        //        // Veri kaybı olmasına rağmen işlem yapılacak.
        //        int intSayi2 = 256;
        //        byte byteSayi2 = (byte)intSayi2;
        //        Console.WriteLine($"byteSayi2 = {byteSayi2}");
        //    }
        //}




        ///////////////////////////////////////////////
        // Convert sınıfı metotları ile tür dönüşümü //
        ///////////////////////////////////////////////

        //double dSayi = 678.456d;
        //string sSayi = Convert.ToString(dSayi);
        //Console.WriteLine($"sSayi tipi {sSayi.GetType()}");

        //string postaKodu = "34460";
        //int postaKoduInt = Convert.ToInt32(postaKodu);
        //Console.WriteLine($"postKoduInt tipi {postaKoduInt.GetType()}");


        //SORU: Klavyeden girilen 2 sayıyı toplayıp toplamı ekrana yadzıran programı yazınız.
        //     Klavyeden s1'i alıp int'e tip dönüşümü yaptık.
            //Console.Write("S1 = ");
            //string stringS1 = Console.ReadLine();
            //int intS1 = Convert.ToInt32(stringS1);


            //// Klavyeden s2'yi alıp int'e tip dönüşümü yaptık.
            //Console.Write("S2 = "); // ekrana 'S2 =' yazdırdık
            //string stringS2 = Console.ReadLine(); // sayı girişini sağladık.
            //int intS2 = Convert.ToInt32(stringS2); // string tipindeki veriyi int'e çevirdik.

            //// int tipine çevirdiğimiz değerleri topladık.
            //int toplam = intS1 + intS2;
            //Console.WriteLine($"{intS1} ve {intS2} sayılarının toplamı = {toplam}");

            // SORU: Klavyeden Fahrenayt olarak girilen sıcaklık bilgisini Santigrat
            // cinsine çevirip aşağıdaki formatta ekrana yazdıran prog.
            // "32 Fahrenayt = > 0 Santigrat derecedir"
            // C = (F-32)/1.8

            //Console.Write("Fahrenayt bilgisi : ");
            //string sFah = Console.ReadLine();
            //double dFah = Convert.ToDouble(sFah);

            //double dSan = (dFah - 32) / 1.8;
            //dSan = Math.Round(dSan, 2); // virgülden sonra 2 basamak.
            //Console.WriteLine($"{dFah} fahrenayt = > {dSan} santigrat derecedir.");



            //// Karakterin ASCII tablosundaki sayı değerini yazdırır.
            //char karakter1 = 'A';
            //int sayi1 = Convert.ToInt32(karakter1);  // 65
            //Console.WriteLine(sayi1);


            ///////////////////////////////////////
            ///  Parse Metodu ile Tip Dönüşümü  ///
            ///////////////////////////////////////

            // Parse metodu string ifadeleri sayısal değerlere dönüştürür.
            //int degisken1 = int.Parse("365");
            //double degisken2 = double.Parse("34");
            //short degeisken3 = short.Parse("4321");
            //char degisken4 = char.Parse("B");
            //Console.WriteLine(degisken4);







            ///////////////////////////////////
            ///     Boxing & Unboxing       ///
            ///////////////////////////////////

            // BOXING

            // object veri tip tüm tiplerin üst tipidir.
            // dolayısıyla sorunsuz dönüştürülebilir.

            // Kasıtsız boxing.
            int limit = 120;
            //object kutu = limit;

            // casting ile boxing
            object kutu = (object)limit;

            // UNBOXING
            // 1. Kural: Unboxing uygulanacak nesneye daha önceden boxing uygulanmış olmalıdır.
            // 2. Kural: Nesne içerisindeki değer hedef tipte olmalıdır.

            //float ondalikliSayi = 94.23f;
            ////boxing
            //object nesne = ondalikliSayi;
            ////unboxing 
            //ondalikliSayi = (float)nesne;

            // ÖRNEK: Klavyeden alınan 2 sayının toplamının karesini
            // ekrana yazdıran programı yazınız.

            Console.Write("s1 = ");
            string sSayi1 = Console.ReadLine();
            short sayi1 = Convert.ToInt16(sSayi1);

            Console.Write("s2 = ");
            short sayi2 = Convert.ToInt16(Console.ReadLine());

            int kare = (sayi1 + sayi2) * (sayi1 + sayi2);
            Console.WriteLine($"{sayi1} ve {sayi2} toplamının karesi = {kare}");

        }
    }
}
