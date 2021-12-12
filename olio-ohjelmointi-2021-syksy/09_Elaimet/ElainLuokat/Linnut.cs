using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public abstract class Linnut : Elain
    {
        private bool OnSulat;

        public void AsetaSulat(bool sulat)
        {
            this.OnSulat = sulat;
        }
        public bool PalautaSulat()
        {
            return OnSulat;
        }
    }
}
