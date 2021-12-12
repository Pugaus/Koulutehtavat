using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Maksukortti
{
    class Maksukortti
    {
        private double saldo;
        public Maksukortti(double alkusaldo)
        {
            this.saldo = alkusaldo;
        }
        public Maksukortti()
        {
        }
        public override string ToString()
        {
            return string.Format("Kortilla on {0} euroa rahaa", this.saldo);
        }
        public bool syoEdullisesti()
        {
            if (saldo - 2.60 < 0)
            {
                return false;
            }
            else
            {
                this.saldo = saldo - 2.60;
                return true;
            }
        }
        public bool syoMaukkaasti()
        {
            if (saldo - 4.60 < 0)
            {
                return false;
            }
            else
            {
                this.saldo = saldo - 4.60;
                return true;
            }
        }
        public bool lataaRahaa(double lataa)
        {
            if (saldo + lataa < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo + lataa;
                return true;
            }
        }
    }
}