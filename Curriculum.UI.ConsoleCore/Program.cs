using System;

namespace Curriculum.UI.ConsoleCore
{
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //-----------------------------------------//


            // ************************************ //
            // *  C# FOR LOOP AND STRING METHODS  * //
            // ************************************ //

            string isim = "mustafa kemâl";
            string[] isimler = { "can", "evrim", "muh4mmed", "emre", "hüseyin"};


            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            } 

            Console.ReadKey();
        }
    }
}