using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutonPolttoaine
    {
        public int Id { get; set; }
        public string PolttoaineNimi { get; set; }

        public AutonPolttoaine(int id, string polttoaineNimi)
        {
            Id = id;
            PolttoaineNimi = polttoaineNimi;
        }

        public override string ToString()
        {
            return PolttoaineNimi;
        }
    }
}
