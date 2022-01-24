using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Football_IQ
{
    public class Kaupanlogiikka
    {
        Databasehallinta dbModel = new Databasehallinta();

        public string Kysymys(string kysymys)
        {            
            return dbModel.valitseYksiKysymys(kysymys);

        }

        public string Vastaus(string vastaus)
        {
            return dbModel.haeKysymyksenVastaus(vastaus);

        }

    }
}
