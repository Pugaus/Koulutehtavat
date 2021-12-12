using System;
using System.Collections.Generic;
using System.Text;

namespace _00_hevonen 
{   
    class Hevonen 
    {
        public string nimi;
        public float paino;
    }

    class Program {
    
        // Main Method
        static public void Main(String[] args)
        {
            Hevonen polle=new Hevonen();
            Console.WriteLine(polle.nimi+" "+polle.paino);
            polle.nimi="Histamiini";
            polle.paino=89;
            Console.WriteLine(polle.nimi+" "+polle.paino);
        }
    }
}