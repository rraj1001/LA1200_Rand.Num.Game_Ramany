using System;

namespace Random_num._Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Random num = new Random();
            int tries = 0;
            int Geheimzahl = num.Next(1, 100);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("Nenne eine Zahl zwischen 1 und 100");

            while (!correct)
            {
                Console.Write("Rate: ");
                string userinput = Console.ReadLine();

                if (int.TryParse(userinput, out guess))
                {
                    tries++;
                } else
                {
                 Console.WriteLine("Falsch");

                }

                if (guess < Geheimzahl)
                {
                    Console.WriteLine("Nein, die Nummer ist hocher als deine Zahl");
                }
                else if (guess > Geheimzahl)
                {
                    Console.WriteLine("Nein, die Nummer ist tiefer als deine Zahl");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Du hast Richtig geraten!");
                    Console.WriteLine("Du brauchtestn nur " + tries + " Versuche"); 
                }
                



            }


        }
    }
}
