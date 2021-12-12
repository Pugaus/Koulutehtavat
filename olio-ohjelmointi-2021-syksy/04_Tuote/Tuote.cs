using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tuote
{
    class Tuote
    {
        public string nimi;
        public double hinta;
        public int lukumaara;        
        public Tuote()
        {
        }
        public Tuote(String nimiAlussa, double hintaAlussa, int maaraAlussa)
        {
            this.nimi = nimiAlussa;
            this.hinta = hintaAlussa;
            this.lukumaara = maaraAlussa;            
        }
        public void tulostaTuote()
        {
            Console.WriteLine(nimi + ", " + "hinta " + hinta + ", "+ lukumaara + " kpl.");
        }
    }
}
