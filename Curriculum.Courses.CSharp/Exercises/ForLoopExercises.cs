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
    }
}