using System;
using System.Collections.Generic;

namespace Curriculum.UI.ConsoleCore
{
    public static class Listeler
    {
        public static void Listele()
        {
            string[] isimler = { "Ahmet", "Mehmet", "Hasan", "Hüseyin" };

            List<string> users = new List<string>();

            for (var i = 0; i < isimler.Length; i++)
            {
                users.Add(isimler[i]);
            }


            //for (int i = 0; i < users.Count; i++)
            //{
            //    Console.WriteLine(users[i]);
            //}
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}