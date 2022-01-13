using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{
    public class AutonMerkki
    {   
        public int Id { get; set; }
        public string MerkkiNimi { get; set; }

        public AutonMerkki (int id, string merkkiNimi)
        {
            Id = id;
            MerkkiNimi = merkkiNimi;
        }

        public override string ToString()
        {
            return MerkkiNimi;
        }
    }
}
       



   
   


