using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Velka
{
    class Velka
    {
        public double _saldo;
        public double _korkoProsentti;
        public Velka(double saldoAlussa, double korkoProsentti)
        {
            _saldo = saldoAlussa;
            _korkoProsentti = korkoProsentti;
        }

        public Velka()
        {
        }

        public void tulostaSaldo()
        {
            Console.WriteLine(_saldo);
        }
        public void odotaVuosi()
        {
            _saldo = _saldo * (1 + _korkoProsentti);
        }
    }
}
