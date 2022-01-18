using System;
using System.Collections.Generic;

namespace Testi_huutokauppa
{
    class Program
    {
        static int TuoteMaara()
        {
            //Kuinka monta tuotetta halutaan myydä huutokaupassa.
            string syote;
            int maara = 0;

            Console.WriteLine("Kuinka monta tuotetta haluat huutokaupata?");
            syote = Console.ReadLine();
            while (!int.TryParse(syote, out maara))
            {
                Console.WriteLine("Syötä vain numeroita");
                syote = Console.ReadLine();
            }
            return maara;
        }    
        static int TavoiteSumma()
        {
            //Annetaan huutokaupan tavoite summa.
            string syote;
            int tavoite = 0;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\nTuotteiden arvo liikkuu 1000€ ja 100000€ välillä. Anna tavoite summa:");
            syote = Console.ReadLine();
            while (!int.TryParse(syote, out tavoite))
            {
                Console.WriteLine("Syötä vain numeroita");
                syote = Console.ReadLine();
            }
            return tavoite;
        }
        static bool Tavoite(int tavoite, int sum)
        {
            //Kerrotaan huutokaupan tavoitteen eteneminen.
            bool tulos = false;           

            if (tavoite > sum)
            {
                Console.WriteLine("Tavoitteeseen on vielä matkaa: " + (tavoite - sum) + "€");
                tulos = true;
            }
            else
            {
                Console.WriteLine("Tavoite ylitetty!: " + (sum - tavoite) + "€");
                tulos = true;
            }
            return tulos;
        }
        static bool Vertailu(int tuoteHinta, int edellinenTuote)
        {
            //Verrataan saatiinko edellisestä tuotteesta enemmän vai vähemmän rahaa.
            bool tulos = false;

            if (tuoteHinta > edellinenTuote)
            {
                Console.WriteLine("Sait tästä tuotteesta paremman hinnan kuin edellisestä!");
                tulos = true;
            }
            else
            {
                Console.WriteLine("Sait edellisestä tuotteesta paremman hinnan!");
                tulos = true;
            }
            return tulos;
        }       
        static void Loppu()
        {
            Console.WriteLine("\n============================================================");
            Console.WriteLine("Huutokauppa on päättynyt. Paina jotain näppäintä jatkaaksesi.");
            Console.ReadKey();
        }
        static bool LoppuTavoite(int tavoite, int sum)
        {
            //Kerrotaan päästiinkö huutokaupassa tavoitteeseen.
            bool tulos = false;
            
            if (tavoite > sum)
            {
                Console.WriteLine("Jäit tavoitteesta: " + (tavoite- sum) + "€");
                tulos = true;
            }
            else
            {
                Console.WriteLine("Tavoite saavutettu! Ylitit tavoitteen " + (sum - tavoite) + "€");
                tulos = true;
            }
            return tulos;
        }
        static void Main(string[] args)
        {            
            int maara, tavoite;

            maara = TuoteMaara();
            tavoite = TavoiteSumma();

            List<string> tuotteet = new List<string>();
            List<int> hinnat = new List<int>();

            int tuoteHinta, sum = 0;
            string tuote;

            // Tuotteiden huutokauppa.
            for (int i = 0; i < maara; i++)
            {
                Random hintaArpa = new Random();
                tuoteHinta = hintaArpa.Next(1000, 100000);
                hinnat.Add(tuoteHinta);

                Console.WriteLine("\nTuote, josta aloitetaan huuto: ");
                tuote = Console.ReadLine();
                tuotteet.Add(tuote);

                Console.WriteLine("\nKorkein huuto oli: " + tuoteHinta + "€");
                sum += tuoteHinta;

                Console.WriteLine("\nOlet myynyt tähän mennessä " + tuotteet.Count + " tuotetta.");
                Console.WriteLine("Tuotteiden yhteenlaskettu summa tällä hetkellä on: " + sum + "€");

                Tavoite(tavoite, sum);

                // Verrataan oliko viimeisin myyty tuote kalliimpi vai halvempi kuin edellinen.
                if (hinnat.Count >= 2)
                {
                    int edellinenTuote = hinnat[hinnat.Count - 2];
                    Vertailu(tuoteHinta, edellinenTuote);                    
                }                
            }
            
            // Ilmoitus huutokaupan päättymisestä.
            Loppu();
            
            // Huutokaupan lopulliset summat.
            Console.WriteLine("\nHuutokauppa tuotti: " + sum + "€");
            LoppuTavoite(tavoite, sum);
           
            hinnat.Sort();
            hinnat.Reverse();            
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Kalleimman huutokaupassa myydyn tuotteen hinta oli: " + hinnat[i] + "€");
            }
            Console.ReadKey();
        }
    }
}
