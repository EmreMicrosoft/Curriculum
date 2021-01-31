using System;

namespace UI.ConsoleCore
{
    public class Client
    {
        public void KonsolaYazdır()
        {
            User mahmut = UsersDatabese.CreateUser();
            string mahmutİsim = mahmut.FirstName;
            var mahmutDoğumTarihi =
                mahmut.DateOfBirth.Day + "-" +
                mahmut.DateOfBirth.Month + "-" +
                mahmut.DateOfBirth.Year;

            Console.WriteLine(mahmut.FirstName);
            Console.WriteLine(mahmut.LastName);
            Console.WriteLine(mahmut.Gender ? "Erkek" : "Kadın");

            //Console.WriteLine(mahmut.DateOfBirth);
            Console.WriteLine(mahmutDoğumTarihi);

            Console.WriteLine("kullanıcı adı: " + mahmut.Username);

            Console.WriteLine("kullanıcı adı değiştirilsin mi?");
            var cevap = Console.ReadLine()?.ToUpper();
            if (cevap == "E")
            {
                Console.Write("yeni kullanıcı adı? ");
                mahmut.Username = Console.ReadLine()?.ToLower();

                Console.WriteLine("yeni kullanıcı adınız: " + mahmut.Username);
            }
        }
    }
}