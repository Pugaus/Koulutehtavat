using System;

namespace _04_Tuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote tuote1 = new Tuote();
            tuote1.nimi = "Banaani";
            tuote1.hinta = 1.1;
            tuote1.lukumaara = 13;   
            
            tuote1.tulostaTuote();            
        }
    }
}
