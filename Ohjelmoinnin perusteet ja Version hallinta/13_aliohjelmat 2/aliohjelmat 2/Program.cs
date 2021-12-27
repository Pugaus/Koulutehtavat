using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktiot
{
    class Program
    {
        private static int Pienin(int eka, int toka, int kolmas)
        {          
            Console.WriteLine("\nPienin luku oli: " + Math.Min(Math.Min(eka, toka), kolmas));
            int pieninLuku = Math.Min(Math.Min(eka, toka), kolmas);
            return pieninLuku;
        }

        private static int Suurin(int eka, int toka, int kolmas)
        {
            Console.WriteLine("Suurin luku oli: " + Math.Max(Math.Max(eka, toka), kolmas));
            int suurinLuku = Math.Max(Math.Max(eka, toka), kolmas);
            return suurinLuku;
        }

        static void Main(string[] args)
        {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;
            string syote;

            bool jatkuu = true;

            while (jatkuu)
            {
                Console.WriteLine("\nAnna eka luku");
                syote = Console.ReadLine();
                bool oikein = Int32.TryParse(syote, out luku1);

                Console.WriteLine("Anna toka luku");
                syote = Console.ReadLine();
                oikein = Int32.TryParse(syote, out luku2);

                Console.WriteLine("Anna kolmas luku");
                syote = Console.ReadLine();
                oikein = Int32.TryParse(syote, out luku3);
                
                if (oikein)
                    {
                        jatkuu = false;
                        pieninLuku = Pienin(luku1, luku2, luku3);
                        suurinLuku = Suurin(luku1, luku2, luku3);
                    }
            
            else
            {
                Console.WriteLine("\nAnna vain numeroita!");
            }                
            }
        }
    }
}