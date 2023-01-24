using System;
using System.Linq;

namespace Ders5_Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //// tip[] diziİsmi = new tip[boyut];
            //// int[] sayilarr = new int[10];
            //int[] rakamlar = {0,1,2,3,4,5,6,7,8,9};
            //// indis numaraları 0'dan başlar 1 er 1 er artarak devam eder.
            //Console.WriteLine($"rakamlar dizisinin ilk elemanı : {rakamlar[0]}");
            //Console.WriteLine($"rakamlar dizisinin 6. elemanı : {rakamlar[5]}");

            //rakamlar[0] = 100;
            //rakamlar.SetValue(100, 0); // yukarıdaki işlemi böyle de yapabiliriz.
            //Console.WriteLine(rakamlar[0]);

            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };
            //Console.WriteLine(sehirler);
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.WriteLine("");
            //// yukarıdaki döngü ile aynı işi yapar. İndis yerine doğrudan şehir bilgisine ulaşır.
            //foreach (var sehir in sehirler) // sehirler disizindeki her bir sehir için...
            //{
            //    Console.WriteLine(sehir);
            //}

            //// Kullanıcıdan alınan 10 adet isim bilgisini string bir diziye kaydedip. Dha sonra dizi elemanlarını ekrana yazdırın.
            //string[] isimler = new string[10]; // 10 elemanlı bir string dizisi tanımladık.
            //for (int i = 0; i < isimler.Length; i++) // isimler.Length = 10
            //{
            //    Console.Write("İsim giriniz: ");
            //    isimler[i] = Console.ReadLine();
            //}
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //    //int indis = Array.IndexOf(isimler, isim); // IndexOf indis numarasını getirir.
            //}


            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            //////int indis10 = Array.IndexOf(puanlar, 10); // 0
            //////int indis10 = Array.IndexOf(puanlar, 10,1); //4  1=> startindex başlama indisi.
            //////int indis10 = Array.IndexOf(puanlar, 10,5); // 6
            ////Console.WriteLine(indis10);
            //Array.Sort(puanlar); // sıralama. Küçükten büyüğe sıralar.
            //Array.Reverse(puanlar); // sıralmasını terse çevirir.

            //object[] karisikDizi = new object[10];
            //karisikDizi[0] = 10;
            //karisikDizi[1] = "Ayşe";
            //karisikDizi[2] = 15.4F;
            //karisikDizi[3] = 15.0D;

            //// 0-100 arasında rastgele 10 sayı üretip bir diziye atın ve son olarak diziyi ekrana yazdırın.
            //Random rastGele = new Random();
            //int[] arraySayilar = new int[10];
            //for (int i = 0; i < arraySayilar.Length; i++)
            //{
            //    arraySayilar[i] = rastGele.Next(0, 100);
            //}
            //Array.Sort(arraySayilar);
            //Array.Reverse(arraySayilar);
            //Console.WriteLine($"*** Sayılar **");
            //foreach (var item in arraySayilar)
            //{
            //    Console.Write(item + " ");
            //}

            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            //int indis100 = Array.IndexOf(puanlar, 10, 0); // 0
            //int indis101 = Array.IndexOf(puanlar, 10, 1); //4  1=> startindex başlama indisi.
            //int indis102 = Array.IndexOf(puanlar, 10, 5); // 6

            //int adet10 = puanlar.Count(sayi => sayi == 10); // her bir elemanı sayi değişlkenine al. Koşul olarak sayi 10'a eşitse.
            //Console.WriteLine($"dizide {adet10} tane 10 değeri var.");

            // dizideki 10 değerlerinin index numaralarını ekrana yazdırın. For döngüsü ile.
            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            //int startIndex = 0;
            //int count10 = puanlar.Count(sayi => sayi == 10); // kaç tane 10 değeri var?
            //for (int i = 0; i < count10; i++)
            //{
            //    startIndex = Array.IndexOf(puanlar, 10, startIndex);
            //    Console.WriteLine($"10 değeri {startIndex}. indexte var.");
            //    startIndex += 1;
            //}

            //int bulunmayanEleman = Array.IndexOf(puanlar, 100);
            //Console.WriteLine(bulunmayanEleman); // aranan eleman dizide yoksa -1 döndürür.



            //// Diziden diziye kopyalama
            //int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            //int[] dizi2 = new int[10];

            //// dizi1'i dizi2'ye 0. indisten itibaren kopyala.
            //dizi1.CopyTo(dizi2, 0);

            //foreach (var item in dizi2)
            //{
            //    Console.WriteLine(item);
            //}

            int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };

            int[] dizi2 = { 44, 55, 13, 14, 12, 54, 21, 33, 57, 56 };

            //// dizi1'in dizi2'ye 0. indisten itibaren 3 elemanını kopyala.
            //// 2. dizide ilk 3 eleman değişir.
            Array.Copy(dizi1, dizi2, 3);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dizi2[i]);
            }

            //// dizi1'in 3. indisinden itibaren 5 elemanı kopyala
            //// dizi2'ye 0. indisten itibaren yapıştır.

            //Array.Copy(dizi1, 3, dizi2, 0, 5);

            //foreach (var item in dizi2)
            //{
            //    Console.WriteLine(item);
            //}


            //////////////////////////////
            //// ÇOK BOYUTLU DİZİLER  ////
            //////////////////////////////

            //int[,] matris = new int[5, 5]; // 5x5 lik bir matris tanımlar.
            //matris[0, 0] = 10;
            //matris[0, 4] = 20;
            //matris[4, 4] = 30;


            //for (int i = 0; i < 5; i++) // i: satıları temsil eder.
            //{
            //    for (int j = 0; j < 5; j++) // j: sütunlları temsil eder.
            //    {
            //        Console.Write(matris[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            // Aşağıdaki çıktıyı veren matrisi döngü ile oluşturunuz.
            /*
            2 0 0 0 2
            1 0 0 0 1
            2 0 0 0 2
            1 0 0 0 1
            2 0 0 0 2
             */
            //// Analiz: satır indexi tek ise: 0. ve 4. kolonlar 1 olur.
            ////         satır indexi çift ise: 0. ve 4. kolonlar 2 olur.
            //int[,] matris = new int[5, 5];

            //// Değer ataması
            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int kolon = 0; kolon < 5; kolon++)
            //    {
            //        if(satir%2==0 && (kolon==0 || kolon == 4))
            //        {
            //            matris[satir, kolon] = 2;
            //        }
            //        else if(satir % 2 == 1 && (kolon == 0 || kolon == 4))
            //        {
            //            matris[satir, kolon] = 1;
            //        }
            //    }
            //    Console.WriteLine(); // içteki döngü tamamlandığında satır sonu olur.
            //    // her satır sonunda alt satıra geç.
            //}




            //for (int satir = 0; satir < 5 ; satir++)
            //{
            //    for (int kolon = 0; kolon < 5; kolon++)
            //    {
            //        Console.Write(matris[satir,kolon]+ " ");
            //    }
            //    Console.WriteLine(); // içteki döngü tamamlandığında satır sonu olur.
            //    // her satır sonunda alt satıra geç.
            //}


            //   

            /*
            1 0 0 0 0
            0 1 0 0 0
            0 0 1 0 0
            0 0 0 1 0
            0 0 0 0 1
            */
            /*
            1 0 0 0 1
            0 1 0 1 0
            0 0 1 0 0
            0 1 0 1 0
            1 0 0 0 1
            */
            //// Analiz: satır indexi ve sütun indexi eşitse 1.
            ////         satır ve sütun indexleri toplamı 4 ise 1.
            //int[,] matris = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i == j || i+j == 4)
            //            matris[i, j] = 1;
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //    {      0 1 2 3 4
            //    0    { 1,2,3,4,5},
            //    1    { 1,2,3,4,5},
            //    2    { 1,2,3,4,5},
            //    3    { 1,2,3,4,5},
            //    4    { 1,2,3,4,5}
            //    }


            //ÖRNEK
            //{ 0,0,0 }
            //{ 0,0,0 }
            int[,] dizi2B = new int[2, 3];
            // diziye değer atadık
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dizi2B[i, j] = 5;
                }
            }
            // diziyi ekrana yazdırdık.
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dizi2B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            // 2x4'luk bir dizi tanımlayın.
            // Bu dizinin her bir elemanı içi klavyeden sayı alıp atayın.
            // Bu diziyi ekrana yazdırın.
            //{
            //    { 0,0,0,0}
            //    { 0,0,0,0}
            //}

            //int[,] dizi24 = new int[2, 4];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("sayı = ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        dizi24[i, j] = sayi;
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(dizi24[i, j]+ " ");
            //    }
            //    Console.WriteLine();
            //}

            // Her satırın son değeri hariç klavyeden alınsın.
            // son kolon satırdaki sayıların toplamını tutsun.


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        dizi2B[i, j] = 5;
            //    }
            //}

            //int[,] dizi24 = new int[2, 4];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (j != 3) 
            //        {
            //            Console.Write("sayı = ");
            //            int sayi = Convert.ToInt32(Console.ReadLine());
            //            dizi24[i, j] = sayi;
            //        }
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    int satirToplam = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        satirToplam += dizi24[i, j];
            //    }
            //    dizi24[i, 3] = satirToplam;
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(dizi24[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Random rnd = new Random();
            //////// 3 BOYUTLU DİZİ //////
            //int[,,] dizi3B = new int[2, 3,3];
            //for (int z = 0; z < 2;z++) // 3x3 lük diziler.
            //{
            //    for (int i = 0; i < 3; i++) // satırlar
            //    {
            //        for (int j = 0; j < 3; j++) // sütunlar.
            //        {
            //            dizi3B[z, i, j] = rnd.Next(1000);
            //        }
            //    }
            //}
            ////ekrana yazdıralımç
            //for (int z = 0; z < 2; z++) // 3x3 lük diziler.
            //{
            //    for (int i = 0; i < 3; i++) // satırlar
            //    {
            //        for (int j = 0; j < 3; j++) // sütunlar.
            //        {
            //            Console.Write(dizi3B[z, i, j]+" ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("**********************");
            //    Console.WriteLine("**********************");
            //}


        }
    }
}


// https://codeshare.io/NA203
