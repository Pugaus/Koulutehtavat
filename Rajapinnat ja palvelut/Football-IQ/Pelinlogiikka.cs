using System;
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
        public int JuoksuHaku(int juoksuPisteet)
        {
            return dbModel.juoksupisteidenHakuDatabase(juoksuPisteet);
        }
        public void JuoksuPäivitys()
        {
            dbModel.juoksupistePaivitys();
        }
        public int HeittoHaku(int heittopisteet)
        {
            return dbModel.heittopisteidenHakuDatabase(heittopisteet);
        }
        public void HeittoPäivitys()
        {
            dbModel.heittopistePaivitys();
        }
        public int PotkuHaku(int potkuPiste)
        {
            return dbModel.potkupisteidenHakuDatabase(potkuPiste);
        }
        public void PotkuPaivitys()
        {
            dbModel.potkupistePaivitys();
        }
        public int PolviHaku(int polviPiste)
        {
            return dbModel.polvipisteidenHakuDatabase(polviPiste);
        }
        public void PolviPaivitys()
        {
            dbModel.polvipistePaivitys();
        }
    }
}
