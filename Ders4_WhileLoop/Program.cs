using System;

namespace Ders4_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int prim = 3500;
            while (prim < 7200)
            {
                Console.WriteLine("Emekliliğe daha var. çalışmaya devam.");
                prim += 360;
            }
            Console.WriteLine("Tebrikler. Emekli oldunuz.");

            //// 1-10 arasındaki
            //byte sayi = 1;
            //while(sayi<=10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}

            // SORU : 1'den klavyeden girilen sayıya kadar olan sayıları ekrana yazdıran prog. yaz.

            //Console.Write("Üst sınırı giriniz: ");
            //int limit = Convert.ToInt32(Console.ReadLine());
            //int sayi = 1;
            //while(sayi<=limit)
            //{
            //    Console.WriteLine($"Sayı = {sayi}");
            //    sayi++;
            //}

            // Klavyeden girilen değer "çık" olmadığı sürece ekrana yazılanları ekrna yazdıran programı yazınız.
            //Console.Write("Mesajınızı yazınız (Çıkmak için ÇIK yazınız) : ");
            //string yazi = Console.ReadLine();
            //while (yazi.ToLower() !="çık")
            //{
            //    Console.WriteLine(yazi);
            //    Console.Write("Mesajınızı yazınız (Çıkmak için ÇIK yazınız) : ");
            //    yazi = Console.ReadLine();
            //}
            //Console.WriteLine("Program Sonlandı!.");

            // Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları toplayıp en son ekrana toplamı yazdıran programı yazınız.
            // Basit Hali.

            //Console.Write("Sayı giriniz : ");
            //string str = Console.ReadLine();
            //int toplam = 0;
            //int sayi = 0;
            //while (str.ToLower() != "bitir")
            //{
            //    sayi = Convert.ToInt32(str);
            //    toplam += sayi;
            //    Console.Write("Sayı giriniz : ");
            //    str = Console.ReadLine();
            //}
            //Console.WriteLine($"TOPLAM = {toplam}");

            // Detaylı Hali

            //Console.Write("Sayı giriniz : ");
            //string str = Console.ReadLine();
            //bool isNumeric = int.TryParse(str, out _);
            //int toplam = 0;
            //int sayi = 0;
            ////Console.WriteLine($"{str} -> {isNumeric}");
            //while (str.ToLower() != "bitir")
            //{
            //    if (isNumeric == true)
            //    {
            //        sayi = Convert.ToInt32(str);
            //        toplam += sayi;
            //    }
            //    Console.Write("Sayı giriniz : ");
            //    str = Console.ReadLine();
            //    isNumeric = int.TryParse(str, out _);
            //}
            //Console.WriteLine($"TOPLAM = {toplam}");




            // TRY CATCH ile tip dönüştürme hatasını yakalama.

            string sSayi = "65836LKJSADL";
            bool kontrol = false;
            int iSayi = 0;
            try
            {
                iSayi = Convert.ToInt32(sSayi);
                kontrol = true;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Metin formatı hatalı !!! Tip dönüşümü yapılamadı!");
            }


            // break kavramı


            // SORU : Klavyeden girilen ifade "bitir" değil ise girilen sayıların karesini toplayıp ekrana yazdıran programı yazınız.
            // Koşul: girilen sayı 5 ve 5'in katı ise de programdan çıkılacak.
            //Console.Write("Sayı giriniz : ");
            //string str = Console.ReadLine();
            //int toplam = 0;
            //int sayi = 0;
            //while (str.ToLower() != "bitir")
            //{
            //    sayi = Convert.ToInt32(str);
            //    if (sayi % 5 == 0)
            //    {
            //        Console.WriteLine("5'in katı girildiği için çıkış yapıldı!");
            //        //str = "bitir"; Bu satır yerine aşağıdaki girilebilir.
            //        break; // Döngüyü sonlandırır.
            //    }
            //    else
            //    {
            //        toplam += (sayi * sayi);
            //        Console.Write("Sayı giriniz : ");
            //        str = Console.ReadLine();
            //    }
            //}
            //Console.WriteLine($"TOPLAM = {toplam}");

            // SORU: 1-100 arasındaki sayıların tek mi çift mi olduğunu ekrana yazan programı yazınız.

            //byte i = 1;
            //while(i<=100)
            //{
            //    if (i%2==0)
            //        Console.WriteLine($"{i} çifttir.");
            //    else
            //        Console.WriteLine($"{i} tektir.");
            //    i++;
            //}


            // SORU : Klavyeden girilen sayıları ekrana yazdıran programı yazınız.
            // koşullar: 5'in katlarında "BOM" yazsın. 19'un katı girilince programdan çıkılsın.
            //int sayi;
            //while(true) // Sonsuz döngü
            //{
            //    Console.Write("sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if(sayi%5==0)
            //        Console.WriteLine("BOM");
            //    else if(sayi%19==0)
            //    { 
            //        Console.WriteLine("19'un katı girildi. Çıkış yapılıyor.");
            //        break; // Döngüden çık.
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sayı : {sayi}");
            //    }
            //}



            // break ve continue kavramları

            // SORU: 1-10 arasındaki sayıları ekrana yazdıran  prog. yaz.
            // 7 yegeldiğinde birşey yazdırmasın.
            // 9 geldiğinden programdan çıksın.
            //int i = 1;
            //while (i<=10)
            //{
            //    if (i == 7)
            //    { 
            //        i++;
            //        continue; // bu aşamadan döngü başına atlar.
            //    }
            //    else if (i == 9)
            //        break; // döngüyü sonlandır.
            //    Console.WriteLine(i);
            //    i++;
            //}

        }
    }
}

