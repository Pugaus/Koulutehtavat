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
        Kaupanlogiikka registerHandler;
        private string kysymys;
        private string oikeaVastaus;


        string vastaus;


        public Paavalikko()
        {
            registerHandler = new Kaupanlogiikka();
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


            labelKysymys.Text = registerHandler.Kysymys(kysymys);
            oikeaVastaus = labelKysymys.Text;
            
            

        }
        private void buttonVastaus_Click(object sender, EventArgs e)
        {

            // Lukitaan muut toiminnot paitsi uusi kysymys nappi
            buttonKysymys.Show();
            buttonVastaus.Enabled = false;
            comboBoxVastaus.Enabled = false;

            labelOikeaVastaus.Text = registerHandler.Vastaus(oikeaVastaus);
            

            // Jos vastaus oli oiekin, lisätään piste tietokantaa
            if (vastaus == labelOikeaVastaus.Text)
            {
                //string pisteSql = "UPDATE Palkinnot SET Pisteet = Pisteet + 1";
                //using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
                //{
                //    yhteys.Open();
                //    using (SqlCommand command = new SqlCommand(pisteSql, yhteys))

                //        try
                //        {
                //            command.ExecuteNonQuery();
                //        }
                //        catch (Exception ex)
                //        {
                //            Console.WriteLine(ex.ToString());
                //        }
                //}

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
