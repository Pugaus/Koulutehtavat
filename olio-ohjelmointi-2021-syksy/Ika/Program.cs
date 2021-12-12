using System;
using ElainLuokat;

namespace ElainLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random1 = new Random();
            Random random2 = new Random();

            for (int i = 0; i < 10; i++)
            {
                Koira koira1 = new Koira();
                Kissa kissa1 = new Kissa();

                int koiranIka = random1.Next(1, 16); koira1.AsetaKoiranIka(koiranIka);
                int kissanIka = random2.Next(1, 11); kissa1.AsetaKissanIka(kissanIka);

                Console.WriteLine("Kissa on {0} vuotta ja Koira on {1} vuotta.", kissa1.PalautaKissanIka(), koira1.PalautaKoiranIka());
                if (kissa1.PalautaKissanIka() < koira1.PalautaKoiranIka())
                {
                    Console.WriteLine("Koira on vanhempi.");
                }
                else if (kissa1.PalautaKissanIka() > koira1.PalautaKoiranIka())
                {
                    Console.WriteLine("Kissa on vanhempi.");
                }
                else
                {
                    Console.WriteLine("Molemmat ovat saman ikäisiä.");
                }
            }
        }
    }
}
