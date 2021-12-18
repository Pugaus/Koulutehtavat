using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliohjelma_vaihe1
{
    class Program
    {
        private static int Tervehdys(string kayttaja, string suku)
        {
            Console.WriteLine("Tervetuloa ohjelmaan!" + " " + kayttaja + " " + suku);
            Console.Write("Kerro ikäsi: ");

            int ika = int.Parse(Console.ReadLine());
            return ika;
        }

        static void Main(string[] args)
        {
            int ika;

            Console.WriteLine("Anna nimesi:");
            string kayttaja = Console.ReadLine();
            Console.WriteLine("Anna sukunimesi:");
            string suku = Console.ReadLine();
            
            Console.WriteLine();
            ika = Tervehdys(kayttaja, suku);
        }
    }
}
