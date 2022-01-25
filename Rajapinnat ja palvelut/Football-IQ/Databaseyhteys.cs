using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Football_IQ
{
    class Databaseyhteys
    {
        string yhteysMerkkiJono;
        public Databaseyhteys()
        {
            yhteysMerkkiJono = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Football;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        }
        public string valitseYksiKysymys(string kysymys)
        {
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                string kysymysSql = "SELECT TOP 1 Skenaario FROM Kysymykset ORDER BY NEWID()";
                {
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    using (SqlCommand hakukomento = new SqlCommand(kysymysSql, yhteys))
                    {
                        // Käydään läpi lukijan lukemat tietueet
                        SqlDataReader lukija = hakukomento.ExecuteReader();
                        while (lukija.Read())
                        {
                            // Saadaan yksi satunnainen kysymys
                            kysymys = lukija[0] as string;
                        }
                    }
                    yhteys.Close();
                }
            }
            return kysymys;
        }

        public string haeKysymyksenVastaus(string vastaus)
        {
            string vastausSql = "SELECT Vastaus FROM Kysymykset WHERE Skenaario = " + "'" + vastaus + "'";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                // Avataan yhteys komennon suorittamista varten
                yhteys.Open();
                using (SqlCommand hakukomento = new SqlCommand(vastausSql, yhteys))
                {
                    try
                    {
                        // Käydään läpi lukijan lukemat tietueet
                        SqlDataReader lukija = hakukomento.ExecuteReader();
                        while (lukija.Read())
                        {
                            // Saadaan kysymyksen oikea vastaus
                            vastaus = lukija["Vastaus"].ToString();
                            break;
                        }
                        yhteys.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }
                }
            }
            return vastaus;
        }
        public void palkintopistePaivitys()
        {
            string pisteSql = "UPDATE Palkinnot SET Pisteet = Pisteet + 1";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                // Avataan yhteys komennon suorittamista varten
                yhteys.Open();
                using (SqlCommand hakukomento = new SqlCommand(pisteSql, yhteys))

                    try
                    {
                        // Tietokanta päivittyy
                        hakukomento.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }
            }
        }

        public int pisteidenHakuDatabase(int pisteet)
        {
            string pisteetSql = "SELECT Pisteet FROM Palkinnot";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                try
                {
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    using (SqlCommand hakukomento = new SqlCommand(pisteetSql, yhteys))
                    {
                        SqlDataReader lukija = hakukomento.ExecuteReader();
                        // Käydään läpi lukijan lukemat tietueet
                        while (lukija.Read())
                        {
                            // lisätään saadut pisteet
                            pisteet = lukija.GetInt32(0);
                            break;
                        }
                    }
                    yhteys.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
            return pisteet;
        }
        public int juoksupisteidenHakuDatabase(int juoksuPisteet)
        {
            string pisteetSql = "SELECT Run FROM Palkinnot";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                try
                {
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    using (SqlCommand hakukomento = new SqlCommand(pisteetSql, yhteys))
                    {
                        SqlDataReader lukija = hakukomento.ExecuteReader();
                        // Käydään läpi lukijan lukemat tietueet
                        while (lukija.Read())
                        {
                            // lisätään saadut pisteet
                            juoksuPisteet = lukija.GetInt32(0);
                            break;
                        }
                    }
                    yhteys.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
            return juoksuPisteet;
        }
        public void juoksupistePaivitys()
        {
            string pisteSql = "UPDATE Palkinnot SET Run = Run + 1";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                // Avataan yhteys komennon suorittamista varten
                yhteys.Open();
                using (SqlCommand hakukomento = new SqlCommand(pisteSql, yhteys))

                    try
                    {
                        // Tietokanta päivittyy
                        hakukomento.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
            }
        }
        public int heittopisteidenHakuDatabase(int heittoPisteet)
        {
            string pisteetSql = "SELECT Pass FROM Palkinnot";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                try
                {
                    // Avataan yhteys komennon suorittamista varten
                    yhteys.Open();
                    using (SqlCommand hakukomento = new SqlCommand(pisteetSql, yhteys))
                    {
                        SqlDataReader lukija = hakukomento.ExecuteReader();
                        // Käydään läpi lukijan lukemat tietueet
                        while (lukija.Read())
                        {
                            // lisätään saadut pisteet
                            heittoPisteet = lukija.GetInt32(0);
                            break;
                        }
                    }
                    yhteys.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
            return heittoPisteet;
        }
        public void heittopistePaivitys()
        {
            string pisteSql = "UPDATE Palkinnot SET Pass = Pass + 1";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                // Avataan yhteys komennon suorittamista varten
                yhteys.Open();
                using (SqlCommand hakukomento = new SqlCommand(pisteSql, yhteys))

                    try
                    {
                        // Tietokanta päivittyy
                        hakukomento.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw;
                    }
            }
        }
    }
}
