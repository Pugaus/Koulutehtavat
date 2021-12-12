using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ElainLuokat;

namespace ElainLuokat
{
    public class Kissa : Nisakkaat
    {
        private List<Kissa> pennut = new List<Kissa>();
        public List<Kissa> Pennut { get => pennut; set => pennut = value; }
        public Kissa Emo { get => emo; set => emo = value; }

        private Kissa emo;
        public void Kehraa()
        {
            Console.WriteLine("hrrrr");
        }        
        public Kissa (string nimi, int ika = 0)
        {
            this.AsetaElaimenNimi(nimi);
            this.AsetaElaimenIka(ika);
        }
        public Kissa(string nimi, Kissa emo, int ika = 0) : this(nimi, ika)
        {
            this.Emo = emo;
        }
        public override void Aantele()
        {
            Console.WriteLine("Miua!");
        }
        public int LisaaPentu(string nimi, int ika = 0)
        {
            Kissa pentu = new Kissa(nimi,this,ika);
            pennut.Add(pentu);

            return pennut.Count;
        }
    }
}
