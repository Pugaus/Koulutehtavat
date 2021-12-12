using System;

namespace _06_Loogiset_operaattorit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paistaako aurinko? \nKYLLÄ = 1 / EI = 2");
            int sun = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSataako? \nKYLLÄ = 1 / EI = 2");
            int rain = int.Parse(Console.ReadLine());
            Console.WriteLine("\nOnko lämpötila >0 \nKYLLÄ = 1 / EI = 2");
            int temp = int.Parse(Console.ReadLine());

            if ((sun == 1) && (rain == 1) && (temp == 1))
            {
                Console.WriteLine("\nTaitaa tulla kesä.");
            }

            else if ((sun == 2) && (rain == 1) && (temp == 1))
            {
                Console.WriteLine("\nSyksy saapui lehdet vei tuuli menneessään.");
            }

            else if ((sun == 2 || sun == 1) && (rain == 2) && (temp == 1))
            {
                Console.WriteLine("\nJo joutui armas aika ja suvi suloinen.");
            }               

            else if ((sun == 2) && (rain == 2 || rain == 1) && (temp == 2))
            {
                Console.WriteLine("\nKylmää ja pimeää");
            }                
            else if ((sun == 1) && (rain == 1) && (temp == 2))
            {
                Console.WriteLine("\nKesällä sataa aina");
            }               
            else if ((sun == 1) && (rain == 2) && (temp == 1))
            {
                Console.WriteLine("\nPakkanen paukkuu");
            }
                
        }
    }
}
