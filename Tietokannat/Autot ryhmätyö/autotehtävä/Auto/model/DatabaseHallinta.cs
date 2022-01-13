using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;

        public DatabaseHallinta()
        {
           yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Autokauppa;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
        }

        public bool connectDatabase()
        {
            dbYhteys = new SqlConnection(yhteysTiedot);
            
            try
            { 
                dbYhteys.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                //dbYhteys.Close();
                return false;
            }
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                try
                {
                    yhteys.Open();
                    
                    SqlCommand autonLisaysKomento = new SqlCommand(
                        "INSERT INTO dbo.auto (Hinta, Rekisteri_paivamaara, Moottorin_tilavuus, Mittarilukema, AutonMerkkiID, AutonMalliID, VaritID, PolttoaineID) " +
                        "Values (" +
                        newAuto.Hinta.ToString("F",System.Globalization.CultureInfo.InvariantCulture) + ",'" + 
                        newAuto.Rekisteri_paivamaara.ToString("d", System.Globalization.CultureInfo.InvariantCulture) + "'," + 
                        newAuto.Moottorin_tilavuus.ToString("F", System.Globalization.CultureInfo.InvariantCulture) + "," +
                        newAuto.Mittarilukema + "," + 
                        newAuto.AutonMerkkiID + "," + 
                        newAuto.AutonMalliID + "," +
                        newAuto.VaritID + "," + 
                        newAuto.PolttoaineID + ")", yhteys);

                    autonLisaysKomento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
                // Huom. Yhteys sulkeutuu automaattisesti (koska using)
            }
            return true;
        }

        public void removeAutoFromDatabase(Auto delAuto)
        {
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                yhteys.Open();
                try
                {
                    SqlCommand komento = new SqlCommand(
                        "DELETE FROM dbo.auto WHERE ID = " + delAuto.ID, yhteys);
                    komento.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            List<AutonMerkki> autonMerkit = new List<AutonMerkki>();
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                try
                {
                    SqlDataReader lukija = null;
                    SqlCommand hakukomento = new SqlCommand(
                        "SELECT ID, Merkki FROM dbo.AutonMerkki;",
                        yhteys);
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    lukija = hakukomento.ExecuteReader();
                    // Käydään läpi lukijan lukemat tietueet
                    while (lukija.Read())
                    {
                        // Lisätään listaan
                        autonMerkit.Add (new AutonMerkki(
                            (int)lukija.GetValue(0),
                            lukija.GetString(1)));
                    }
                    lukija.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return autonMerkit;
            }    
        }

        public List<AutonMalli> getAutoModelsByMakerId(int makerId) 
             
        {
            List<AutonMalli> autonMallit = new List<AutonMalli>();
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                try
                {
                    SqlDataReader lukija = null;
                    SqlCommand hakukomento = new SqlCommand(
                        "SELECT ID, Auton_mallin_nimi FROM dbo.AutonMallit WHERE AutonMerkkiID = " + makerId,
                        yhteys);
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    lukija = hakukomento.ExecuteReader();
                    // Käydään läpi lukijan lukemat tietueet
                    while (lukija.Read())
                    {
                        // Lisätään listaan
                        autonMallit.Add(new AutonMalli(
                            (int)lukija.GetValue(0),
                            lukija.GetString(1),
                            makerId));
                    }
                    lukija.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return autonMallit;
        }

        public List<AutonVari> getAllColorsFromDatabase()
        {
            List<AutonVari> autonVarit = new List<AutonVari>();
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                try
                {
                    SqlDataReader lukija = null;
                    SqlCommand hakukomento = new SqlCommand(
                        "SELECT ID, Varin_nimi FROM dbo.Varit;",
                        yhteys);
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    lukija = hakukomento.ExecuteReader();
                    // Käydään läpi lukijan lukemat tietueet
                    while (lukija.Read())
                    {
                        // Lisätään listaan
                        autonVarit.Add(new AutonVari(
                            (int)lukija.GetValue(0),
                            lukija.GetString(1)));
                    }
                    lukija.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return autonVarit;
            }
        }
        public List<AutonPolttoaine> getAllFuelsFromDatabase()
        {
            List<AutonPolttoaine> autonPolttoaine = new List<AutonPolttoaine>();
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                try
                {
                    SqlDataReader lukija = null;
                    SqlCommand hakukomento = new SqlCommand(
                        "SELECT ID, Polttoaineen_nimi FROM dbo.Polttoaine;",
                        yhteys);
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    lukija = hakukomento.ExecuteReader();
                    // Käydään läpi lukijan lukemat tietueet
                    while (lukija.Read())
                    {
                        // Lisätään listaan
                        autonPolttoaine.Add(new AutonPolttoaine(
                            (int)lukija.GetValue(0),
                            lukija.GetString(1)));
                    }
                    lukija.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return autonPolttoaine;
            }
        }

        public List<Auto> getAllAutosFromDatabase()
        {
            List<Auto> autot = new List<Auto>();
            using (SqlConnection yhteys = new SqlConnection(yhteysTiedot))
            {
                try
                {
                    SqlDataReader lukija = null;
                    SqlCommand hakukomento = new SqlCommand(
                        "SELECT * FROM dbo.auto;", yhteys);
                    yhteys.Open();
                    lukija = hakukomento.ExecuteReader();
                    while (lukija.Read())
                    {
                        autot.Add(new Auto(
                            (int)lukija.GetValue(0), //[ID]
                            (decimal)lukija.GetValue(1), //[Hinta]
                            (DateTime)lukija.GetValue(2), //[Rekisteri_paivamaara]
                            (decimal)lukija.GetValue(3), //[Moottorin_tilavuus]
                            (int)lukija.GetValue(4), //[Mittarilukema]
                            (int)lukija.GetValue(5), //[AutonMerkkiID]
                            (int)lukija.GetValue(6), //[AutonMalliID]
                            (int)lukija.GetValue(7), //[VaritID]
                            (int)lukija.GetValue(8)  //[PolttoaineID]
                            ));
                    }
                    lukija.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return autot;
            }
        }
    }
}
