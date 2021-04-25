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
                        switch (firstValue)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a);
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                        }

                        checkFirst = false;
                    }

                    Console.WriteLine(c);
                }

                if (c > lastValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(a + b);
                    break;
                }

                a = b; b = c;
            }

            // end:
            Console.ReadKey();
        }
    }
}