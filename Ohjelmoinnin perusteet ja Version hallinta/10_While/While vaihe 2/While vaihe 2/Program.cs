using System;

namespace Tehtävä_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 46);
            int quess;
            bool gameover = false;

            Console.WriteLine("Arvaa luku 1 - 45 välillä. Jos haluat lopettaa ohjelman kirjoita 9000");

            while (gameover == false)
            {
                quess = Convert.ToInt32(Console.ReadLine());

                if (quess != randomnumber && quess == 9000)
                {
                    Console.WriteLine("Lopetetaan ohjelma.");
                    gameover = true;
                }
                else if (quess == randomnumber)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    gameover = true;
                }
                else if (quess > randomnumber)
                {
                    Console.WriteLine("Numero on pienempi.");
                }
                else if (quess < randomnumber)
                {
                    Console.WriteLine("Numero on suurempi.");
                }
            }
        }
    }
}