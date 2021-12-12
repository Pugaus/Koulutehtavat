using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Musiikkikappale
{
    class Musiikkikappale
    {
        public string nimi;
        public int pituus;

        public Musiikkikappale()
        {
        }

        public Musiikkikappale(String kappaleenNimi, int kappaleenPituus)
        {
            this.nimi = kappaleenNimi;
            this.pituus = kappaleenPituus;
        }
        public String Nimi()
        {
            return this.nimi;
        }
        public int Pituus()
        {
            return this.pituus;
        }
    }
}
