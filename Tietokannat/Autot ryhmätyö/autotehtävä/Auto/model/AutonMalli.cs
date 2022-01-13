using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{
    public class AutonMalli
    {
        private int id;
        private string malliNimi;
        private int merkkiId;

        public int Id { get => id; set => id = value; }
        public string MalliNimi { get => malliNimi; set => malliNimi = value; }
        public int MerkkiId { get => merkkiId; set => merkkiId = value; }

        public AutonMalli (int id, string malliNimi, int merkkiId)
        {
            this.id = id;
            this.malliNimi = malliNimi;
            this.merkkiId = merkkiId;
        }

        public override string ToString()
        {
            return malliNimi;
        }
    }
}
