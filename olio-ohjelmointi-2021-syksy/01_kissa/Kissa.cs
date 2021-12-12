using System;
using System.Collections.Generic;
using System.Text;

namespace _01_kissa
{
    class Kissa
    {
        private int ika = 0;
        public string nimi = "Miuku";
        public Kissa()
        {

        }
        public Kissa(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public bool AsetaKissanNimi(string uusiNimi)
        {
            if (uusiNimi.Equals("hilda", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            else
            {
                this.nimi = uusiNimi;
                return true;
            }            
        }
        public bool AsetaKissanIka(int ika)
        {
            if (ika < 0)
            {
                return false;
            }
            else
            {
                this.ika = ika;
                return true;
            }
        }
        public string PalautaKissanNimi()
        {
            return nimi;
        }
        public int PalautaKissanIka()
        {
            return ika;
        }
        public override string ToString()
        {
            return ("Kissa: " + nimi + ", ikä " + ika);
        }
    }
}
