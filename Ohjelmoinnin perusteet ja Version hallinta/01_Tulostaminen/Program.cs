using System;

namespace _01_Tulostaminen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee sovellus, joka tulostaa konsolin ruudulle tekstin "Hei maailma!".
            //Muuta sovellusta, että se kysyy käyttäjän nimen ja iän sekä tervehtii sitten häntä esimerkiksi tähän tapaan "Hei Maija, 26!"

            int ika;
            string nimi;
                        
            Console.WriteLine("Hei maailma!");
            Console.WriteLine("Kerro nimesi:");
            nimi = Console.ReadLine();

            Console.WriteLine("Kerro myös ikäsi:");
            ika = int.Parse(Console.ReadLine());

            Console.WriteLine("Hei " + nimi + ", " + ika + "!");
        }
    }
}
