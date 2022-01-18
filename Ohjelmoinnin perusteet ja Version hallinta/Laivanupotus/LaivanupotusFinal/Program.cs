using System;
using System.Collections.Generic;

namespace LaivanupotusFinal
{
    class Program
    {
        static void Info()
        {
            Console.WriteLine("Tervetuloa laivanupotus peliin.");
            Console.WriteLine("\nTehtäväsi on ensin valita koordinaatti, johon sijoitat laivasi ruudukossa. \nKun laivan paikka on valittuna" +
                ", ammutte tietokoneen kanssa vuoronperään \ntoistenne ruudukoihin ja kumpi osuu ensimmäisenä vastustajan laivaan, voittaa pelin.");
            Console.WriteLine("\n  __1__2__3__4__5_");
            Console.WriteLine("a |__|__|__|__|__| \nb |__|__|__|__|__| \nc |__|__|__|__|__| \nd |__|__|__|__|__| \ne |__|__|__|__|__|");
            Console.WriteLine("\nEsimerkki laukaus: c3");
            Console.WriteLine("\nPaina jotakin näppäintä jatkaaksesi laivan koordinaatin valintaan.");
            Console.WriteLine("=====================================================================");
            Console.ReadKey();
        }
        static string LaivanSijainti()
        {
            string laivanPaikka = "";
            var random = new List<string> { "a1", "a2", "a3", "a4", "a5", "b1", "b2", "b3", "b4", "b5", "c1", "c2", "c3", "c4", "c5", "d1", "d2", "d3", "d4", "d5", "e1", "e2", "e3", "e4", "e5" };
            bool oikein = true;
            while (oikein)
            {
                Console.WriteLine("\nAnna laivasi koordinaatti.");
                laivanPaikka = Console.ReadLine();
                if (random.Contains(laivanPaikka))
                {
                    oikein = false;
                    Console.WriteLine("\nVastustaja valitsi myös laivansa koordinaatin.");
                    Console.WriteLine("Paina jotakin näppäintä aloittaaksesi peli.");
                    Console.WriteLine("==============================================================");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nLaiva pitää sijoittaa määrättyyn ruudukkoon.");
                }
            }
            return laivanPaikka;
        }                
        static void PelaajaOsuma()
        {
            Console.WriteLine("OSUI JA UPPOSI!");
            Console.WriteLine("\nVoitit pelin! Sait yhden pisteen!");                  
        }
        static void VastustajanOsuma()
        {
            Console.WriteLine("OSUI JA UPPOSI!");
            Console.WriteLine("\nVastustaja voitti pelin! Hän sai yhden pisteen!");

        }
        static void Pisteet(int pelaajanPisteet, int vastustajanPisteet)
        {
            Console.WriteLine("\n==============================================================");
            Console.WriteLine("Pelaajan pisteet:" + pelaajanPisteet);
            Console.WriteLine("Vastustajan pisteet:" + vastustajanPisteet);
        }
        static bool Loppu(bool peli)
        {
            Console.WriteLine("\nPeli loppui. Haluatko pelata uuden kierroksen vai sulkea sovelluksen?");
            bool jatkuu = true;
            while (jatkuu)
            {
                Console.WriteLine("1) Uusi peli / 2) Sulje sovellus");
                string syote = Console.ReadLine();
                bool oikein = Int32.TryParse(syote, out int vastaus);
                if (vastaus == 1)
                {
                    peli = true;
                    break;

                }
                if (vastaus == 2)
                {
                    jatkuu = false;
                    peli = false;
                }
                else
                {
                    Console.WriteLine("1) Uusi peli / 2) Sulje sovellus");
                }
            }
            return peli;                       
        }
        static void Kiitos(int pelaajanPisteet, int vastustajanPisteet)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Kiitos laivanupotuksen pelaamisesta!");
            Console.WriteLine("\nPelaajan pisteet:" + pelaajanPisteet);
            Console.WriteLine("Vastustajan pisteet:" + vastustajanPisteet);
            
            if (pelaajanPisteet > vastustajanPisteet)
            {
                Console.WriteLine("\nPeli päättyi pelaajan voittoon!");
            }
            if (vastustajanPisteet > pelaajanPisteet)
            {
                Console.WriteLine("\nPeli päättyi vastustajan voittoon!");
            }
            if (vastustajanPisteet == pelaajanPisteet)
            {
                Console.WriteLine("\nPeli päättyi tasapeliin!");
            }
            
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int pelaajanPisteet = 0, vastustajanPisteet = 0;

            Info();
                                   
            bool peli = true;
            while (peli)
            {
                string laivanPaikka, arvaus;
                laivanPaikka = LaivanSijainti();

                var random = new Random();
                var lauta = new List<string> { "a1", "a2", "a3", "a4", "a5", "b1", "b2", "b3", "b4", "b5", "c1", "c2", "c3", "c4", "c5", "d1", "d2", "d3", "d4", "d5", "e1", "e2", "e3", "e4", "e5" };

                // Arvotaan vastustajan laivan paikka.
                int arpa = random.Next(lauta.Count);
                string laiva = (lauta[arpa]);
                
                // Pelaajien ammunta.
                bool ammunta = true;
                while (ammunta)
                {

                    // Arvotaan tietokoneen laukaus kohta.
                    arpa = random.Next(lauta.Count);
                    string laukaus = (lauta[arpa]);

                    Console.WriteLine("\nMihin koordinaattiin haluat ampua? ");
                    arvaus = Console.ReadLine();
                    if (arvaus == laiva)
                    {
                        PelaajaOsuma();
                        pelaajanPisteet++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Laukaus meni ohi.");
                    }

                    Console.WriteLine("\nVastustajan vuoro ampua.");
                    Console.WriteLine(laukaus);
                    if (laukaus == laivanPaikka)
                    {
                        VastustajanOsuma();
                        vastustajanPisteet++;
                        ammunta = false;
                    }
                    else
                    {
                        Console.WriteLine("Laukaus meni ohi.");
                    }
                }
                
                // Pisteet ja valikko.
                Pisteet(pelaajanPisteet, vastustajanPisteet);
                peli = Loppu(peli);
                
            }
            // Pelin loppu ja voittajan julistaminen.
            Kiitos(pelaajanPisteet, vastustajanPisteet);
        }
    }
}
