using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        /*
         * [ID]                  
         * [Hinta]               
         * [Rekisteri_paivamaara]
         * [Moottorin_tilavuus]  
         * [Mittarilukema]       
         * [AutonMerkkiID]       
         * [AutonMalliID]        
         * [VaritID]             
         * [PolttoaineID]        
         */
        public int ID { get; set;}
        public decimal Hinta { get; set; }
        public DateTime Rekisteri_paivamaara { get; set; }
        public decimal Moottorin_tilavuus { get; set; }
        public int Mittarilukema { get; set; }
        public int AutonMerkkiID { get; set; }
        public int AutonMalliID { get; set; }
        public int VaritID { get; set; }
        public int PolttoaineID { get; set; }

        public Auto(int id, decimal hinta, DateTime rekisteri_paivamaara, decimal moottorin_tilavuus, 
            int mittarilukema, int autonMerkkiID, int autonMalliID, int varitID, int polttoaineID)
        {
            ID = id;
            Hinta = hinta;
            Rekisteri_paivamaara = rekisteri_paivamaara;
            Moottorin_tilavuus = moottorin_tilavuus;
            Mittarilukema = mittarilukema;
            AutonMerkkiID = autonMerkkiID;
            AutonMalliID = autonMalliID;
            VaritID = varitID;
            PolttoaineID = polttoaineID;
        }
    }
}
