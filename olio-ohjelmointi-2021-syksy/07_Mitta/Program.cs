using System;

namespace _07_Mitta
{
    class Program
    {
        static void Main(string[] args)
        {
            Mittari m = new Mittari();
            while (!m.taynna())
            {
                Console.WriteLine("Ei täynnä! Mitta: " + m.Mitta());
                m.lisaa();
            }
            Console.WriteLine("Täynnä! Mitta: " + m.Mitta());
            m.vahenna();
            Console.WriteLine("Ei täynnä! Mitta: " + m.Mitta());

        }
    }
}
