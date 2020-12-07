using System;

namespace Curriculum.UI.ConsoleCore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vize notunu giriniz: ");
            int vizeNotu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunu giriniz: ");
            int finalNotu = Convert.ToInt32(Console.ReadLine());

            double hesaplama = vizeNotu * 0.3 + finalNotu * 0.7;

            int gecmeNotu = Convert.ToInt32(hesaplama);

            if (gecmeNotu >= 60)
            {
                Console.WriteLine(gecmeNotu + " ile geçti.");
            }
            else if (gecmeNotu > 39)
            {
                Console.WriteLine(gecmeNotu + " ile büte kaldı.");
            }
            else
            {
                Console.WriteLine(gecmeNotu + " ile kaldı.");
            }
        }
    }
}