using System;

namespace Curriculum.UI.ConsoleCore
{
    public class LectureNotes
    {
        public void Notes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //-----------------------------------------//



            string isim = "mustafa kemâl";
            string[] isimler = { "can", "evrim", "muh4mmed", "emre", "hüseyin" };
            int toplam = 0;

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }

            for (int i = 0; i < isim.Length; i++)
            {
                Console.Write(isim[i]);
            }

            for (int i = 0; i <= 100; i++)
            {
                toplam = toplam + i;
            }

            Console.WriteLine(toplam);
        }
    }
}