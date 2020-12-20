using System;

namespace Curriculum.UI.ConsoleCore
{
    public static class Program
    {
        public static void Main()
        {
            var rastgele = new Random();
            var sayi = rastgele.Next(50, 100);

            Console.WriteLine("Tek mi çift mi?");
            Console.WriteLine("Tek için '1', çift için '2' yazın.");
            var tercih = Console.ReadLine();

            // SWITCH-CASE STATEMENT
            switch (sayi % 2)
            {
                case 0 when tercih == "2":
                    Console.WriteLine("evet, sayı çift: " + sayi);
                    break;
                case 0 when tercih == "1":
                    Console.WriteLine("hayır, sayı çift: " + sayi);
                    break;
                case 1 when tercih == "2":
                    Console.WriteLine("hayır, sayı tek: " + sayi);
                    break;
                case 1 when tercih == "1":
                    Console.WriteLine("evet, sayı tek: " + sayi);
                    break;
                default:
                    Console.WriteLine("Bişeyler ters gitti.");
                    break;
            }




            // ends:
            Console.ReadKey();
        }
    }
}