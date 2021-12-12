using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElainLuokat;

namespace Oliot
{
    class Program
    {
        static void Main(string[] args)
        {
            string syote;
            int maara = 0;

            Console.WriteLine("Kuinka monta eläintä luodaan?");
            syote = Console.ReadLine();
            while (!Int32.TryParse(syote, out maara))
            {
                Console.WriteLine("Syötä vain numeroita");
                syote = Console.ReadLine();
            }

            Random rnd = new Random();            
            List<Elain> lista = new List<Elain>();
            
            for (int i = 0; i < maara; i++)
            {
                int ika = rnd.Next(1, 16);
                if (i % 4 == 3)
                {
                    Hevonen hevonen = new Hevonen();
                    hevonen.AsetaElaimenNimi("Hevonen");
                    hevonen.AsetaElaimenIka(ika);
                    hevonen.AsetaLihanSyoja(false);
                    hevonen.AsetaImetys(true);
                    lista.Add(hevonen);
                }
                else if (i % 3 == 0)
                {
                    Kissa kissa = new Kissa();                   
                    kissa.AsetaElaimenNimi("Kissa");
                    kissa.AsetaElaimenIka(ika);
                    kissa.AsetaLihanSyoja(true);
                    kissa.AsetaImetys(true);
                    lista.Add(kissa);
                }
                else if (i % 3 == 1)
                {
                    Koira koira = new Koira();                    
                    koira.AsetaElaimenNimi("Koira");
                    koira.AsetaElaimenIka(ika);
                    koira.AsetaLihanSyoja(true);
                    koira.AsetaImetys(true);
                    lista.Add(koira);
                }
                else
                {
                    Papukaija papu = new Papukaija();                    
                    papu.AsetaElaimenNimi("Papukaija");
                    papu.AsetaElaimenIka(ika);
                    papu.AsetaLihanSyoja(false);
                    papu.AsetaSulat(true);
                    lista.Add(papu);
                }
            }

            foreach(Elain elain in lista)
            {
                Console.WriteLine(elain.GetType() + " Nimi:" + elain.PalautaElaimenNimi() + " Ika:" + elain.PalautaElaimenIka() + " Onko lihan syöjä?" + elain.PalautaLihanSyoja());
            }
            foreach (Nisakkaat nisakas in lista.OfType<Nisakkaat>())
            {
                Console.WriteLine("Nisakas imettää: " + nisakas.PalautaImetys());
            }
            foreach (Linnut lintu in lista.OfType<Linnut>())
            {
                Console.WriteLine("Linnulla on sulat: " + lintu.PalautaSulat());
            }
        }
    }
}
