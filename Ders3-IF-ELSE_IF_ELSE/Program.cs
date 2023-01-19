using System;

namespace Ders3_IF_ELSE_IF_ELSE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Burası -2
            //bool kosul = true;
            //if (kosul==true)
            //{
            //    Console.WriteLine("Koşul sağlanıyorsa(true ise) bu kod bloğu çalışır!");
            //}
            //else
            //{
            //    Console.WriteLine("Koşul sağlanmıyorsa bu blok çalışır.");
            //}



            // ÖRNEK: Klavyeden alınan sayı 5'den büyükse sayının kendisini değilse
            // sayının karesini ekrana yazdıran programı yazınız.

            //Console.Write("sayi : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //bool kontrol = sayi > 5;
            //if (kontrol==true)
            //{
            //    Console.WriteLine($"Sayı 5'den büyüktür. {sayi}");
            //}
            //else
            //{
            //    Console.WriteLine($"Sayı 5'den küçük veya eşittir. {Math.Pow(sayi,2)}");
            //}




            //// Klavyeden girilen 2 sayıdan büyük olanı ekrana yazdıran programı yazınız.
            //Console.Write("s1 :");
            //int s1 = int.Parse(Console.ReadLine());

            //Console.Write("s2 :");
            //int s2 = int.Parse(Console.ReadLine());
            //if (s1 > s2)
            //{
            //    Console.WriteLine($"s1 büyük {s1}");
            //}
            //else if (s2 > s1)
            //{
            //    Console.WriteLine($"s2 büyük {s2}");

            //}
            //else if (s1 == s2)
            //{
            //    Console.WriteLine($"Sayılar eşittir.");
            //}

            //Console.WriteLine("asdasd");




            // Klavyeden girilen 3 sayıdan 100'den küçük olanları toplayıp ekrana yazdıran programı yazınız.

            //Console.Write("s1 :");
            //int s1 = int.Parse(Console.ReadLine());

            //Console.Write("s2 :");
            //int s2 = int.Parse(Console.ReadLine());

            //Console.Write("s3 :");
            //int s3 = int.Parse(Console.ReadLine());

            //int toplam = 0;
            //if (s1 < 100)
            //    toplam += s1;
            //if (s2 < 100)
            //    toplam += s2;
            //if (s3<100)
            //{
            //    toplam += s3;
            //}
            //Console.WriteLine($"toplam = {toplam}");




            // ÖRNEK: Aşağıdaki koşullara göre notu harf'e çeviren programı yazınız.
            /*
             * 0-49 : F
             * 50-64: D
             * 65-69: C
             * 70-84: B
             * 85-100: A
             */



            //Console.Write("Notu giriniz: ");
            //int not = int.Parse(Console.ReadLine());

            //if (not >= 0 && not <= 49)
            //    Console.WriteLine("F");
            //else if (not >= 50 && not <= 64)
            //    Console.WriteLine("D");
            //else if (not >= 65 && not <= 69)
            //    Console.WriteLine("C");
            //else if (not >= 70 && not <= 84)
            //    Console.WriteLine("B");
            //else if (not >= 85 && not <= 100)
            //    Console.WriteLine("A");
            //else
            //    Console.WriteLine("HATALI NOT ARALIĞI!");



            // SORU: Aşağıdaki kontrol programını yazınız.
            // Klavyeden 2 sayı alınız.
            // Klavyeden işlem bilgisi alınız.
            // (islem => topla,cikar,carp,bol )
            // İşleme göre girilen değerleri işleme sokan prog.

            //Console.Write("sayi1: ");
            //float sayi1 = float.Parse(Console.ReadLine());

            //Console.Write("sayi2: ");
            //float sayi2 = Convert.ToSingle(Console.ReadLine());

            //Console.Write("islem: ");
            //string islem = Console.ReadLine(); // string olduğu için değiştirmedik.

            // //   sayi2 0 olursa bölmede hata alırız. !!!

            //if(islem=="topla")
            //{
            //    Console.WriteLine(sayi1+sayi2);
            //}
            //else if(islem=="cikar")
            //    Console.WriteLine(sayi1-sayi2);
            //else if(islem=="carp")
            //    Console.WriteLine((sayi1*sayi2));
            //else if(islem=="bol")
            //    Console.WriteLine(sayi1/sayi2);
            //else
            //    Console.WriteLine("Hatalı islem girdiniz.!!!");


            //// Bölme seçildiğinde 2. sayının olmadığından emin ol.
            //if (islem == "topla")
            //{
            //    Console.WriteLine(sayi1 + sayi2);
            //}
            //else if (islem == "cikar")
            //    Console.WriteLine(sayi1 - sayi2);
            //else if (islem == "carp")
            //    Console.WriteLine((sayi1 * sayi2));
            //else if (islem == "bol")
            //    if(sayi2==0)
            //    {
            //        Console.WriteLine("0'a bölme yapılamaz!!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi1 / sayi2);
            //    }
            //else
            //    Console.WriteLine("Hatalı islem girdiniz.!!!");


            //Klavyeden girilen sayı
            //    Çift ise; ekrana yazdırsın.
            //    Tek ise; 3'ün katı mı değil mi kontrol edilsin.
            //    3 ün katı ile kaç katı olduğu ekrana yazdırılsın.'

            //Console.Write("sayi : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if(sayi%2==0) // sayı çift ise
            //{
            //    Console.WriteLine($"ÇİFT => {sayi}");
            //}
            //else // sayı çift değil ise tektir.
            //{
            //    if(sayi%3==0)
            //    {
            //        Console.WriteLine($"{sayi} 3'ün {sayi/3} katıdır.");
            //    }    
            //}






            // SORU: Klavyeden girilen 5 sayıdan kaçının pozitif kaçının negatif olduğunu sayan ayrıca negitfler toplamı ve pozitifler toplamını ekrana yazdıran prog.
            // 1. aşama: toplamları ekrana yazdırın.
            // 2. aşama: kaç negatif kaç pozitif ?
            //ÖRN : sayılar: -5,9,11,-15,10
            // 1. aşama: Negatifler Toplamı: -20, Pozitifler toplamı: 25
            // 2. aşama: 2 negatif,3 pozitif sayı girildi.
            //int s1 = -10;
            //int s2 = 20;
            //int s3 = 90;
            //int s4 = -9;
            //int s5 = -1;

            //int nToplam = 0;
            //int pToplam = 0;
            //int nSayac = 0;
            //int pSayac = 0;

            //if(s1>0)
            //{
            //    pToplam += s1;
            //    pSayac += 1;
            //}
            //else if(s1<0)
            //{
            //    nToplam += s1;
            //    nSayac++;
            //}
            //if (s2 > 0)
            //{
            //    pToplam += s2;
            //    pSayac += 1;
            //}
            //else if (s2 < 0)
            //{
            //    nToplam += s2;
            //    nSayac++;
            //}

            //if (s3 > 0)
            //{
            //    pToplam += s3;
            //    pSayac += 1;
            //}
            //else if (s3 < 0)
            //{
            //    nToplam += s3;
            //    nSayac++;
            //}

            //if (s4 > 0)
            //{
            //    pToplam += s4;
            //    pSayac += 1;
            //}
            //else if (s4 < 0)
            //{
            //    nToplam += s4;
            //    nSayac++;
            //}

            //if (s5 > 0)
            //{
            //    pToplam += s5;
            //    pSayac += 1;
            //}
            //else if (s5 < 0)
            //{
            //    nToplam += s5;
            //    nSayac++;
            //}
            //Console.WriteLine($"{nSayac} adet negatif sayının toplamı: {nToplam}");
            //Console.WriteLine($"{pSayac} adet pozitif sayının toplamı: {pToplam}");

            // Burası -1
            //// rakamları ekrana yazdıran program.
            int rakam = 0;
        Etiket: //label
            Console.WriteLine(rakam);
            rakam++;
            if (rakam < 20)
                goto Etiket;

            // Burası 0
            // İstenilen sayının faktöriyelini hesaplayan prog.
            // 5 faktöriyeli = 5*4*3*2*1 = 120
            //Console.Write("sayi:");
            //int fSayi = Convert.ToInt32(Console.ReadLine());
            //int s = fSayi; 
            //int faktoriyel = 1;

            //fHesap:
            //faktoriyel = faktoriyel * fSayi;
            //fSayi--; // sayıyı 1 eksilttik.
            //if (fSayi > 1)
            //    goto fHesap;
            //Console.WriteLine($"{s} sayısının faktöriyeli: {faktoriyel}");


            // Burası 1
            //// Formül kullanmadan:
            //// Klavyeden taban ve üs bilgisi alın, tabanın. üs bilgisine göre kuvvetini hesaplayın.

            ////ÖRN:
            //int taban = 9;
            //int us = 4;
            //int k = us;
            //int sonuc = 1;
            //kuvvetHesapla:
            //    sonuc *= taban; // 1*9.=> 9*9 => 81*9 ....
            //    us--;
            //    if (us > 0)
            //        goto kuvvetHesapla;

            //Console.WriteLine($"{taban} sayısının {k}. kuvveti : {sonuc}");

            // Burası 2
            // Klavyeden girilen sayı 0-100 arasında değilse tekrar isteyen programı yazınız.
            // Yukarıdaki şekilde 3 sayı alıp bunların aritmetik ortalamasını bulan program.
            //int toplam = 0;
            //int sayac = 1;

            //labelSayiISte:
            //Console.Write($"{sayac}. Sayı : ");
            //int s = Convert.ToInt32(Console.ReadLine());
            //if(s>=0 && s<=100)
            //{
            //    toplam += s;
            //    sayac++;
            //}else
            //{
            //    goto labelSayiISte;
            //}
            //if (sayac < 4)
            //    goto labelSayiISte;

            //Console.WriteLine($"3 sayının ortlaması: {toplam/3}");






            ///////////////////////////////
            ///     SWITCH CASE     ///////
            ///////////////////////////////

            string seviye = "orta";
            switch (seviye)
            {
                case "kolay":
                    Console.WriteLine("Seviye : Kolay");
                    break;  // switch-case'den çıkmak için.
                case "orta":
                    Console.WriteLine("Seviye : Orta");
                    break;
                case "zor":
                    Console.WriteLine("Seviye : Zor");
                    break;
                default:
                    Console.WriteLine("Seviye hatalı !");
                    break;
            }
            // Klavyeden 2 sayı ve işlem bilgisi alıp.
            // switch kullanarak seçilen işleme göre sonucu gösterecek prog. yazınız.
            // topla, bol, carp, cıkar

            Console.Write("Sayı 1:");
            float sayi1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Sayı 2:");
            float sayi2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("İşlem :");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "toplama":
                    Console.WriteLine($"Toplam = {sayi1 + sayi2}");
                    break;
                case "çıkarma":
                    Console.WriteLine($"Fark = {sayi1 - sayi2}");
                    break;
                case "çarpma":
                    Console.WriteLine($"Çarpım = {sayi1 * sayi2}");
                    break;
                case "bölme":
                    if (sayi2 != 0)
                    {
                        Console.WriteLine($"Bölüm = {sayi1 / sayi2}");
                        break;
                    }
                    Console.WriteLine("Bölen 0 olamaz !");
                    break;
                default:
                    Console.WriteLine("Hatalı İşlem!");
                    break;
            }
            Console.ReadLine();


        }
    }
}