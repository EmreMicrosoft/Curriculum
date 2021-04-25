using System;
using System.Collections.Generic;

namespace CSharp.Exercises
{
    public class ForLoopExercises
    {
        /// <summary>
        /// Returns prime numbers list between min and max value.
        /// min and max values are included.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>list of integer</returns>
        public List<int> PrimeNumbers(int min, int max)
        {
            var primeNumbers = new List<int>();

            for (var i = min; i <= max; i++)
            {
                var isPrime = 1;
                for (var j = 2; j < i; j++)
                {
                    if (i % j != 0) continue;

                    isPrime = 0;
                    break;
                }

                if (isPrime == 1)
                    primeNumbers.Add(i);
            }

            return primeNumbers;
        }

        public static void UserPassWithArrays()
        {
            string[] usernames = { "ahmet", "mehmet", "hasan", "huseyin" };
            string[] passwords = { "Ah1234", "Me1234", "Ha1234", "Hu1234" };

            Console.WriteLine("Kullanıcı Adı?");
            var username = Console.ReadLine();

            Console.WriteLine("Şifre?");
            var password = Console.ReadLine();

            var kontrol = false;

            for (var i = 0; i < usernames.Length; i++)
            {
                if (username?.ToLower() != usernames[i] || password != passwords[i])
                    continue;

                Console.WriteLine("Hoşgeldin " + usernames[i] + "!");
                kontrol = true;
                break;
            }

            if (kontrol == false)
            {
                Console.WriteLine("Kullanıcı adı ya da şifre hatalı..!");
            }
        }
        
        public static void TestRandomClass()
        {
            var random = new Random();

            var array = new int[100, 2];
            for (var i = 0; i < 100; i++)
            {
                array[i, 0] = i + 1;
                array[i, 1] = 0;
            }

            for (var i = 0; i < 1000000; i++)
            {
                var randomNumber = random.Next(1, 101);
                for (var j = 0; j < 100; j++)
                {
                    if (array[j, 0] == randomNumber)
                    {
                        array[j, 1]++;
                    }
                }
            }

            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine("Sayı: " + array[i, 0] + ", Miktar: " + array[i, 1]);
            }
        }
    }
}