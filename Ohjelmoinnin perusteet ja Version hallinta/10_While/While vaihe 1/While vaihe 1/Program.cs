using System;

namespace Vaihe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            while (sum <= 99)
            {
                Console.WriteLine("Anna jokin luku 1 - 99 välillä: ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                Console.WriteLine("\nLaskettu summa on: " + sum);
            }
            
            Console.WriteLine("Raja saavutettu");
        }
    }
}
