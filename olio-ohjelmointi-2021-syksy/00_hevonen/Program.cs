using System;
using System.Collections.Generic;
using System.Text;

namespace Hevonen
{
    class Hevonen
    {
        public string nimi;
        public int paino;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen heppa = new Hevonen();
            Console.WriteLine(heppa.nimi + "\n" + heppa.paino);
            heppa.nimi = "Histamiini";
            heppa.paino = 89;
            Console.WriteLine("\n" + heppa.nimi + "\n" + heppa.paino);
        }
    }
}
