using System;

namespace Tehtävä_15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculation = true;

            while (calculation)
            {
                try
                {
                    Console.WriteLine("\nAnna jaettava: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nAnna jakaja: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    
                    calculation = false;                                        
                    Console.WriteLine("\nJakolaskun tulos: " + num1 / num2);
                    
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }   
        }
    }
}
