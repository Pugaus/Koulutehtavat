using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_pilli
{
    class Pilli
    {
        private String aani;
        public Pilli(String pillinAani)
        {
            aani = pillinAani;
        }
        public void soi()
        {
            Console.WriteLine(aani);
        }
    }
}
