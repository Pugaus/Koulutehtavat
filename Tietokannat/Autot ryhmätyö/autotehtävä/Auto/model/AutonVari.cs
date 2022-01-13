using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{
    public class AutonVari
    {
        public int Id { get; set; }
        public string VariNimi { get; set; }

        public AutonVari(int id, string variNimi)
        {
            Id = id;
            VariNimi = variNimi;
        }

        public override string ToString()
        {
            return VariNimi;
        }
    }
}
