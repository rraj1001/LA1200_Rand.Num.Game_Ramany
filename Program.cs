using System;

namespace Random_num.Gamme_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Random num = new Random();
            int tries = 0;
            int Geheimzahl = num.Next(1, 100);
            bool correct = false;






            while (!correct)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Nenne eine Zahl zwischen 1 und 100");
                Console.Write("Rate: ");
                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput > 1 || userinput < 100)
                {
                    tries++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsch");

                }

                if (userinput < Geheimzahl)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nein, die Nummer ist grösser als deine Zahl");
                }
                else if (userinput > Geheimzahl)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nein, die Nummer ist kleiner als deine Zahl");
                }
                else
                {
                    correct = true;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Du hast Richtig geraten!");
                    Console.WriteLine("Du brauchtestn nur " + tries + " Versuche");
                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (userinput > 100 || userinput < 1)
                    Console.WriteLine("Eingabe darf nicht unter 1 und über 100 sein!!!");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("------------------------------------------------");

            }
            Console.ForegroundColor = ConsoleColor.Green;


        }
    }
}