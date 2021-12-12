using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Mitta
{
    class Mittari
    {
        private int mitta;
        public Mittari()
        {
            mitta = 0;
        }
        public void lisaa()
        {
            ++mitta;
            if (mitta > 5)
            {
                mitta = 5;
            }            
        }
        public void vahenna()
        {
            --mitta;
            if (mitta < 0)
            {
                mitta = 0;
            }            
        }
        public int Mitta()
        {           
            return mitta;
        }
        public Boolean taynna()
        {
            if(mitta >= 5)
            {
                return true;
            }
            return false;
        }
    }
}
