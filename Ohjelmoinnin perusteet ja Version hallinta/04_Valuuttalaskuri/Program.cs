using System;

namespace _04_Valuuttalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka kysyy käyttäjältä euromääräisen luvun. Ohjelman laskee paljonko annettu luku on dollareina ja puntina ja kertoo sen käyttäjälle. 

            int luku;
            double dollari = 1.13;
            double rupla = 82.67;

            Console.WriteLine("Kerro jokin euromääräinen luku");
            luku = int.Parse(Console.ReadLine());
                        
            Console.WriteLine(String.Format("Dollareina " + "{0:0.00}", luku * dollari));
            Console.WriteLine(String.Format("Ruplina " + "{0:0.00}", luku * rupla));

        }
    }
}
