using System;

namespace CSharp.Exercises
{
    public class Fibonacci
    {
        /// <summary>
        /// console'dan girilen iki sayı arasındaki
        /// fibonacci noktalarını verir.
        /// </summary>
        public static void Range()
        {
            Console.Write("ilk sayı: ");
            var firstValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("son sayı: ");
            var lastValue = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            var checkFirst = true;

            for (var i = 0; i < lastValue; i++)
            {
                var c = a + b;

                if (c >= firstValue && c <= lastValue)
                {
                    if (checkFirst)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        checkFirst = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.WriteLine(c);
                }

                if (c > lastValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(c + a);
                    break;
                }

                a = b; b = c;
            }

            // end:
            Console.ReadKey();
        }
    }
}