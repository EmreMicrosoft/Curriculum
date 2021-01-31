using System;
using System.ComponentModel.Design;

namespace UI.ConsoleCore
{
    public static class KonsolUygulamaları
    {
        /// <summary>
        /// Selamlanacak kişinin ismini parametre olarak gönder.
        /// </summary>
        /// <param name="name"></param>
        public static void KarşılamaMetodu(string name)
        {
            Console.WriteLine("Hoşgeldin " + name + "!");
        }

        /// <summary>
        /// Vatandaşı selamlar.
        /// </summary>
        public static void KarşılamaMetodu()
        {
            Console.WriteLine("Hoşgeldin vatandaş!");
        }

        public static string OturumAçmaBilgisi(string name, bool oturumİzniVarMı)
        {
            if (oturumİzniVarMı == true)
            {
                return name + " için oturum açıldı.";
            }
            else
            {
                return name + ", sen bizden değilsin.";
            }
        }
    }
}