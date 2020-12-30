using System;

namespace Curriculum.UI.ConsoleCore
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("İsminiz? ");
            string isim = Console.ReadLine();

            // METHOD OVERLOAD
            KonsolUygulamaları.KarşılamaMetodu();
            KonsolUygulamaları.KarşılamaMetodu(isim);

            Console.WriteLine();

            string sonuç = KonsolUygulamaları
                .OturumAçmaBilgisi(isim, true);

            Console.WriteLine(sonuç);
        }
    }
}