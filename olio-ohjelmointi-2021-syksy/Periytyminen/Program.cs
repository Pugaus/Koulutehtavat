using System;
using System.Collections.Generic;
using System.Text;
using ElainLuokat;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira = new Koira();
            koira.AsetaImetys(true);
            
            Papukaija papu = new Papukaija();
            papu.AsetaElaimenNimi("Pete");
            papu.AsetaElaimenIka(5);
            papu.AsetaSulat(true);

            Console.WriteLine("Nimi:" + koira.PalautaElaimenNimi() + " Ikä:" + koira.PalautaElaimenIka() + " Imetys:" + koira.PalautaImetys());
            Console.WriteLine("Nimi:" + papu.PalautaElaimenNimi() + " Ikä:" +papu.PalautaElaimenIka() + " Sulat:" + papu.PalautaSulat());
        }
    }
}
