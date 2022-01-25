﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Football_IQ
{
    public class Pelinlogiikka
    {
        Databaseyhteys dbModel = new Databaseyhteys();

        public string Kysymys(string kysymys)
        {            
            return dbModel.valitseYksiKysymys(kysymys);

        }

        public string Vastaus(string vastaus)
        {
            return dbModel.haeKysymyksenVastaus(vastaus);

        }
        public void Pistepaivitys()
        {
            dbModel.palkintopistePaivitys();
        }
        public int PisteHaku(int pisteet)
        {
            return dbModel.pisteidenHakuDatabase(pisteet);
        }

    }
}