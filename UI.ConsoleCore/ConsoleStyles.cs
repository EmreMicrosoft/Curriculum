using System;
using System.Threading;

namespace UI.ConsoleCore
{
    /// <summary>
    /// Bu klass konsol ekranı tasarımı için kullanılır.
    /// </summary>
    public static class ConsoleStyles
    {
        /// <summary>
        /// Bu metod konsoldaki metin rengini yeşil yapar.
        /// </summary>
        public static void CanStyle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Beni Can tasarladı.");
        }

        /// <summary>
        /// Bu metod konsolu koyu maviye boyar.
        /// </summary>
        public static void EvrimStyle()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;

            Thread.Sleep(2000);

            Console.WriteLine("Beni Evrim tasarladı.");
        }
    }
}