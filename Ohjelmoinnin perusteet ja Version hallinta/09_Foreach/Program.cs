using System;


namespace _09_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, summa = 0;
            int[] taulukko = new int[5];

            Console.WriteLine("Anna viisi lukua: ");
            for (int i = 0; i < 5; i++)
            {
                while (!int.TryParse(Console.ReadLine(),out numero))
                {
                    Console.WriteLine("Syötä vain numeroita: ");
                }
                taulukko[i] = numero;
            }


            foreach (var item in taulukko)
            {
                summa += item;
            }

            Console.WriteLine("Keskiarvo on: " + summa / 5);
        }
    }
}
