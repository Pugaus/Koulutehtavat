using System;

namespace _03_Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka kysyy käyttäjän pituutta senttimetreinä. Ohjelman tulee ilmoittaa paljonko annettu luku on metreinä, maileina jaardeina ja tuumina.
            //Tulosta mitat kahden desimaalin tarkkuudella.

            int pituus;
            decimal metri, maili, jaardi, tuuma;

            Console.WriteLine("Kerro pituutesi senttimetreinä");
            pituus = int.Parse(Console.ReadLine());

            metri = pituus / 100.0m;
            maili = pituus / 16093.4m;
            jaardi = pituus / 91.43m;
            tuuma = pituus / 2.53m;

            metri = Math.Round(metri * 100) / 100;
            maili = Math.Round(maili * 100) / 100;
            jaardi = Math.Round(jaardi * 100) / 100;
            tuuma = Math.Round(tuuma * 100) / 100;

            Console.WriteLine("Pituutesi: " + "Metreinä " + metri  + " Maileina " + maili +  " Jaardeina " + jaardi + " Tuumina " + tuuma);
        }
    }
}
