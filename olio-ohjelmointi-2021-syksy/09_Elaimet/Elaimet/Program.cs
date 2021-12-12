using System;
using ElainLuokat;

namespace ElainLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira = new Koira();
            Console.WriteLine(koira.PalautaKoiranNimi());
            koira.AsetaKoiranNimi("Max");
            Console.WriteLine(koira.PalautaKoiranNimi());
            koira.AsetaKoiranNimi("Musti");
            Console.WriteLine(koira.PalautaKoiranNimi());
        }
    }
}
