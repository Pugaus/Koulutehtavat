using System;

namespace _08_Array
{
    class Program
    {
        static void Main(string[] args)
        {            
            int maara, i, f;

            Console.WriteLine("Kuinka monta tuotetta haluat lisätä?");
            maara = int.Parse(Console.ReadLine());

            string[] tuoteNimi = new string[maara];
            decimal[] tuoteHinta = new decimal[maara];
            int[] tuoteMaara = new int[maara];

            for (f = 0; f < maara; f++)
            {
                Console.WriteLine("\nAnna tuotteen nimi: ");
                tuoteNimi[f] = Console.ReadLine();

                Console.WriteLine("Anna tuotteen hinta: ");
                tuoteHinta[f] = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Anna tuotteen kappalemäärä: ");
                tuoteMaara[f] = int.Parse(Console.ReadLine());
                {
                    Console.WriteLine();
                }

                for (i = 0; i < 1; i++)
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.Write("Tuote: " + tuoteNimi[f] + "\nHinta: " + tuoteHinta[f] + "€" + "\nkpl: " + tuoteMaara[f]);
                    Console.WriteLine();
                }
            }            
        }
    }
}
