using System;
using System.Collections.Generic;
using System.Text;
using ElainLuokat;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int ika;
        public string nimi;
        private bool OnLihanSyoja;
        public void AsetaElaimenIka(int ika)
        {
            if (ika > 0)
            {
                this.ika = ika;
            }
        }
        public void AsetaElaimenNimi(string nimi)
        {
            this.nimi = nimi;
        }
        public int PalautaElaimenIka()
        {
            return ika;
        }
        public string PalautaElaimenNimi()
        {
            return nimi;
        }        
        public void AsetaLihanSyoja(bool syoLihaa)
        {
            this.OnLihanSyoja = syoLihaa;
        }
        public bool PalautaLihanSyoja()
        {
            return OnLihanSyoja;
        }
        public virtual void Aantele()
        {
            Console.WriteLine("Umph!");
        }
    }
}
