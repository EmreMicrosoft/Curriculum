using System;
using System.Collections.Generic;

namespace Curriculum.Courses.CSharp.Exercises
{
    public class ForLoopExercises
    {
        /// <summary>
        /// Returns prime numbers list between min and max value.
        /// min and max values are included.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
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

        public void UserPassWithArrays()
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
                if (username?.ToLower() == usernames[i] && password == passwords[i])
                {
                    Console.WriteLine("Hoşgeldin " + usernames[i] + "!");
                    kontrol = true;
                    break;
                }
            }

            if (kontrol == false)
            {
                Console.WriteLine("Kullanıcı adı ya da şifre hatalı..!");
            }
        }
    }
}