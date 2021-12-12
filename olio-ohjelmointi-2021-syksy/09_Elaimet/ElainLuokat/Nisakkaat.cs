using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public abstract class Nisakkaat : Elain
    {
        private bool Imettaa;

        public void AsetaImetys(bool imetys)
        {
            this.Imettaa = imetys;
        }
        public bool PalautaImetys()
        {
            return Imettaa;
        }
    }
}
