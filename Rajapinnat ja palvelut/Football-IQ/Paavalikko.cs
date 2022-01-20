using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Football_IQ
{
    public partial class Paavalikko : Form
    {

        string vastaus;
        string yhteysMerkkiJono = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Football;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        public Paavalikko()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Piilotetaan ja lukitaan kaikki muut napit paitsi uuden kysymyksen
            labelKysymys.Hide();
            labelOikeaVastaus.Hide();
            labelOikeinTaiVaarin.Hide();
            comboBoxVastaus.Enabled = false;
            buttonVastaus.Enabled = false;
            
        }

        private void buttonKysymys_Click(object sender, EventArgs e)
        {
            // Näytetään kysymys ja vastausvaihtoehdot
            labelKysymys.Show();
            buttonVastaus.Show();
            comboBoxVastaus.Show();
            buttonVastaus.Enabled = true;
            comboBoxVastaus.Enabled = true;

            // Piilotetaan kaikki kysymyksen jälkeiset tiedot
            labelOikeinTaiVaarin.Hide();
            labelOikeaVastaus.Hide();
            labelPiste.Hide();
            buttonKysymys.Hide();
            
            // Tyhjennetään vastausvaihtoehto comboboxista
            comboBoxVastaus.SelectedItem = null;


            string kysymysSql = "SELECT TOP 1 Skenaario FROM Kysymykset ORDER BY NEWID()";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                // Avataan yhteys komennon suorittamista varten
                yhteys.Open();
                using (SqlCommand command = new SqlCommand(kysymysSql, yhteys))
                {
                    // Käydään läpi lukijan lukemat tietueet
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Saadaan yksi satunnainen kysymys
                        labelKysymys.Text = reader[0] as string;
                    }
                }
                yhteys.Close();

            }
        }
        private void buttonVastaus_Click(object sender, EventArgs e)
        {

            // Lukitaan muut toiminnot paitsi uusi kysymys nappi
            buttonKysymys.Show();
            buttonVastaus.Enabled = false;
            comboBoxVastaus.Enabled = false;

            string vastausSql = "SELECT Vastaus FROM Kysymykset WHERE Skenaario = " + "'" + labelKysymys.Text + "'";
            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                // Avataan yhteys komennon suorittamista varten
                yhteys.Open();
                using (SqlCommand command = new SqlCommand(vastausSql, yhteys))
                {
                    // Käydään läpi lukijan lukemat tietueet
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Saadaan kysymyksen oikea vastaus
                        labelOikeaVastaus.Text = reader["Vastaus"].ToString();
                        break;
                    }
                }
                yhteys.Close();
            }            

            // Jos vastaus oli oiekin, lisätään piste tietokantaa
            if (vastaus == labelOikeaVastaus.Text)
            {
                string pisteSql = "UPDATE Palkinnot SET Pisteet = Pisteet + 1";
                using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
                {
                    yhteys.Open();
                    using (SqlCommand command = new SqlCommand(pisteSql, yhteys))

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                }

                // Näytetään, että vastaus oli oikein
                labelPiste.Show();
                labelOikeinTaiVaarin.Show();
                labelOikeinTaiVaarin.ForeColor = Color.MediumSeaGreen;
                labelOikeinTaiVaarin.Text = "Right answer";
                
            }
            else
            {
                // Näytetään, että vastaus oli väärin ja kerrotaan oikea vastaus
                labelOikeaVastaus.Show();
                labelOikeaVastaus.Text = "The correct answer was: " + labelOikeaVastaus.Text;
                labelOikeinTaiVaarin.Show();
                labelOikeinTaiVaarin.ForeColor = Color.FromArgb(244, 93, 119);
                labelOikeinTaiVaarin.Text = "Wrong answer";
            }
                        
        }
       
        private void comboBoxVastaus_SelectedIndexChanged(object sender, EventArgs e)
        {
            vastaus = this.comboBoxVastaus.GetItemText(this.comboBoxVastaus.SelectedItem);
        }

        private void pictureBoxPalkinnot_Click(object sender, EventArgs e)
        {
            Palkinnot palkinnot = new Palkinnot();
            palkinnot.ShowDialog();

            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ohjelman sulkeminen.
            DialogResult dialogResult = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void openDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ohjelman data on kerätty Data World sivustolta. " +
                "Osoite: https://data.world/crowdflower/football-strategy", "Avoin data", MessageBoxButtons.OK);
        }
    }
}
