using System;
using System.Diagnostics;

namespace CSharp.Exercises
{
    public class StopWatchSample
    {
        internal void Run()
        {
            var kronometre = new Stopwatch();
            kronometre.Start();

            TestMethod();

            kronometre.Stop();
            var zaman = kronometre.Elapsed;

            var geçenZaman = $"{zaman.Hours:00}" +
                                $":{zaman.Minutes:00}" +
                                $":{zaman.Seconds:00}" +
                                $".{zaman.Milliseconds / 10:00}";


            Console.WriteLine("--------------------------");
            Console.Write("Süre : ");
            Console.WriteLine(geçenZaman);

            // SON
            Console.ReadKey();
        }

        private static void TestMethod()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Console.Clear();
            }
        }
    }
}