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
            var ilkSayı = Convert.ToInt32(Console.ReadLine());

            Console.Write("son sayı: ");
            var sonSayı = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;
            var checkFirst = true;

            for (var i = 0; i < sonSayı; i++)
            {
                var c = a + b;

                if (c >= ilkSayı && c <= sonSayı)
                {
                    if (a == 0 && b == 1)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                    }

                    if (checkFirst)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(b);
                        checkFirst = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.WriteLine(c);
                }

                if (c > sonSayı)
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