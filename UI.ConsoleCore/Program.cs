using System;

namespace UI.ConsoleCore
{
    public static class Program
    {
        public static void Main()
        {
            var client = new Client();
            client.KonsolaYazdır();

            // bitti:
            Console.ReadKey();
        }
    }
}