using System;

namespace _05_Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka velka = new Velka(1000, 0.1);

            velka.tulostaSaldo();
            velka.odotaVuosi();
            velka.tulostaSaldo();
            velka.odotaVuosi();
            velka.tulostaSaldo();
            velka.odotaVuosi();
            velka.tulostaSaldo();
            velka.odotaVuosi();
        }
    }
}
