using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");

            int i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
                Console.WriteLine("Bu sayı 2 ye tam bölünür.");
            if (i % 3 == 0)
                Console.WriteLine("Bu sayı 3 e tam bölünür.");
            if (i % 5 == 0)
                Console.WriteLine("Bu sayı 5 e tam bölünür.");
            Console.ReadLine();
        }
    }
}
