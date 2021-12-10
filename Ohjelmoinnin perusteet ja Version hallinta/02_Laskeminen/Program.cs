using System;

namespace _02_Laskeminen
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;

            Console.WriteLine("Anna jokin luku 1 - 10 väliltä:");
            luku = int.Parse(Console.ReadLine());

            Console.WriteLine("1*" + luku + "=" + 1 * luku + " 1/" + luku + "=" + 1 / luku + " 1%" + luku + "=" + 1 % luku);
            Console.WriteLine("2*" + luku + "=" + 2 * luku + " 2/" + luku + "=" + 2 / luku + " 1%" + luku + "=" + 2 % luku);
            Console.WriteLine("3*" + luku + "=" + 3 * luku + " 3/" + luku + "=" + 3 / luku + " 1%" + luku + "=" + 3 % luku);
            Console.WriteLine("4*" + luku + "=" + 4 * luku + " 4/" + luku + "=" + 4 / luku + " 1%" + luku + "=" + 4 % luku);
            Console.WriteLine("5*" + luku + "=" + 5 * luku + " 5/" + luku + "=" + 5 / luku + " 1%" + luku + "=" + 5 % luku);
        }
    }
}
