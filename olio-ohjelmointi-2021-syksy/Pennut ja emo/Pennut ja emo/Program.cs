using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElainLuokat;

namespace ElainLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa emo = new Kissa("Emo", 9);
            emo.LisaaPentu("Veijo", 1);
            emo.LisaaPentu("Viljo", 2);
            emo.LisaaPentu("Väinö", 3);

            foreach (Kissa pentu in emo.Pennut)
            {
                Console.WriteLine("Nimi:" + pentu.PalautaElaimenNimi() + " Ika:" + pentu.PalautaElaimenIka() + " ja emo on " + pentu.Emo.PalautaElaimenNimi());
            }

            Kissa emokaksi = new Kissa("Emo kakkonen", 9);
            emokaksi.LisaaPentu("Pentu 4", 4);
            emokaksi.LisaaPentu("Pentu 5", 5);
            emokaksi.LisaaPentu("Pentu 6", 6);

            foreach (Kissa pentu in emokaksi.Pennut)
            {
                Console.WriteLine("Nimi:" + pentu.PalautaElaimenNimi() + " Ika:" + pentu.PalautaElaimenIka() + " ja emo on " + pentu.Emo.PalautaElaimenNimi());
            }
        }
    }
}
