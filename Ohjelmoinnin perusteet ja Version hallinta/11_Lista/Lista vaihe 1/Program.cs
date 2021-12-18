using System;
using System.Collections.Generic;

namespace Tehtävä_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int x;
            string userName, aakkoset, exit = "x";
            bool oppilaat = false;

            Console.WriteLine("Anna oppilaan nimi. Jos haluat lopettaa nimien annon, paina X näppäintä. ");
            userName = Console.ReadLine();
            names.Add(userName);

            while (oppilaat == false)
            {
                if (userName == exit)
                {
                    Console.WriteLine();
                    oppilaat = true;
                }
                else
                {
                    Console.WriteLine("Anna oppilaan nimi: ");
                    userName = Console.ReadLine();
                    names.Add(userName);
                }
            }

            Console.WriteLine("Kuinka monen oppilaan nimet haluat nähdä?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Näytetäänkö oppilaat aakkosten alku- vai loppupäästä. A = alkupää. L = loppupää");
            aakkoset = Console.ReadLine();

            if (aakkoset == "a")
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }

            else if (aakkoset == "l")
            {
                names.Reverse();
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
            
        }
    }
}
