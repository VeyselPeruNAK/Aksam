using System;

namespace Ders4_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i + "For Döngüsü");
            //}

            //// 1'den 10'a kadar olan sayıların toplamını bulan program.
            //int toplam = 0;
            //for (int i = 1; i < 4; i++)
            //{
            //    // toplama her seferinde i'yi keldik.
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("Toplam : " + toplam);

            //int i;
            //for (i = 1; i <= 10; i++)
            //{

            //}

            ////Sonsuz Döngü
            //for ( ; ; )
            //{
            //    Console.WriteLine("Sonsoz Döngü");
            //}

            //for( ; ; )
            //{
            //    Console.Write("Çıkmak için Ç'ye basın.");
            //    string harf = Console.ReadLine();
            //    if (harf.ToUpper() == "Ç")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Başka harfe bastınız.");
            //}
            //Console.WriteLine("Ç harfine bastınız tebrikler.");


            //for (int i = 0; i <= 10;i++)
            //{
            //    Console.WriteLine(i);
            //};

            //// 1'den klavyeden girilen sayıya kadar olan çift sayıları yazan program.
            //Console.Write("Sayı = ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    if(i%2==0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("Program sonlandı.");


            //// Klavyeden girilen sayıdan 1'e kadar olan çift sayıları yazan program.(AZALAN)
            //Console.Write("Sayı = ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = sayi; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //},
            //Console.WriteLine("Program sonlandı.");

            // Klavyeden girilen 2 sayı arasındaki sayıları azalan şekilde ekrana yazan programı yazınz.
            // büyük ve küçük sayıyı sırasız girilebilecek.
            //int kucuk = 0;
            //int buyuk = 0;

            //Console.Write("sayı 1 = ");
            //int kgs1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("sayı 2 = ");
            //int kgs2 = Convert.ToInt32(Console.ReadLine());

            //if (kgs1 > kgs2)
            //{
            //    buyuk = kgs1;
            //    kucuk = kgs2;
            //}
            //else
            //{
            //    buyuk = kgs2;
            //    kucuk = kgs1;
            //}

            //for (int i = buyuk; i > kucuk; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // SORU: Marketteki her ürünün fiyatının tek tek girilip her biri için %18 KDV li fiyatını ekrana yazdıran program.

            // Tüm ürünlerin toplam fiyatını kdv dahil olarak ekrana yazdıran program.
            // 5 ürün.

            // ÖRN: 1. ürünün fiyatını girin = 100 => 118
            //      2. ürünün fiyatını girin = 200 => 236

            //double toplam = 0;
            //double kdvSizF;
            //double kdvLiF;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"{i}. ürünün fiyatı : ");
            //    kdvSizF = Convert.ToDouble(Console.ReadLine());
            //    kdvLiF = kdvSizF * 1.18;
            //    Console.WriteLine($"\bÜrünün KDV li fiyatı {kdvLiF}");
            //    toplam += kdvLiF;
            //}
            //Console.WriteLine($"Toplam KDV'li fiyat = {toplam}");

            /////////////   ÖDEVLER   ///////////

            ////1)  Klavyeden çık değeri alınana kadar alınan negatif ve pozitif sayıları ayrı ayrı toplayıp program sonunda ekrana yazdıran programı yazınız. 
            ///(34 ve - 34) değerleri gelirse işleme alınmadan sıradaki sayıyı istesin)

            //int negToplam = 0;
            //int pozToplam = 0;
            //for (; ;)
            //{
            //    Console.Write("Sayı giriniz:");
            //    string giris = Console.ReadLine();
            //    if (giris.ToLower()=="çık")
            //    {
            //        Console.WriteLine($"Pozitif sayıların toplamı = {pozToplam}");
            //        Console.WriteLine($"Negatif sayıların toplamı = {negToplam}");
            //        break;
            //    }
            //    else if(giris=="34" || giris=="-34")
            //    {
            //        Console.WriteLine("Geçersiz sayı girdiniz.");
            //        continue;
            //    }
            //    else
            //    {
            //        int sayi = Convert.ToInt32(giris);
            //        if (sayi > 0)
            //            pozToplam += sayi;
            //        else
            //            negToplam += sayi;
            //    }
            //}

            //// 2) Klavyeden çık değeri alınana kadar girilen ifadeleri bir string değişkende alt alta birleştirip. 
            ///     Program sonlanırken string değişkeni ekrana yazdıran programı yazınız.
            //string satirlar = "";
            //while (true)
            //{
            //    Console.Write("yaz dostum: ");
            //    string satir = Console.ReadLine();
            //    if(satir.ToLower()=="çık")
            //    {
            //        Console.WriteLine($"Girilen değerler : {satirlar}");
            //        break;
            //    }
            //    else
            //        satirlar += satir + "\n";
            //}



            //3) 1 - 10 arasındaki sayıların faktöriyellerini hesaplayıp tüm bu sayıların faktöriyellerini toplayıp toplamı ekrana yazdıran programı yazınız.
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    int araToplam = 1;
            //    // 4F = 4.3.2.1
            //    for (int j = i; j >=1 ; j--)
            //    {
            //        araToplam *= j;
            //    }
            //    toplam += araToplam;
            //    Console.WriteLine($"{i} sayısının faktöriyeli = {araToplam}");
            //}
            //Console.WriteLine($"Tüm sayların faktöriyellerinin toplamı = {toplam}");

            // Çözüm 2

            int faktoriyel = 1;
            int sayi = 0;
            int i = 1, toplam = 0;

            Console.WriteLine("1-10 arasındaki sayıların faktoriyellerini hesaplamak için herhangi bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= sayi; i++)
            {

                faktoriyel = i * faktoriyel;
                toplam += faktoriyel;
                Console.WriteLine($"{i} Sayısının faktöriyeli={faktoriyel} ");
            }
            Console.WriteLine($"1-10 arasındaki sayıların faktöriyeller toplamı= {toplam}");






        }
    }
}
