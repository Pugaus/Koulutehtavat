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
        Pelinlogiikka registerHandler;
        string kysymys = " ";
        string VastausHaku, vastaus;
        int sekuntia = 0;

        public Paavalikko()
        {
            registerHandler = new Pelinlogiikka();
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
            sekuntia = 10;
            timer1.Start();

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

            // Haetaan satunnainen kysymys ja käytetään sitä vastauksen haussa
            labelKysymys.Text = registerHandler.Kysymys(kysymys);
            VastausHaku = labelKysymys.Text;              
        }

        private void buttonVastaus_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            // Lukitaan muut toiminnot paitsi uusi kysymys nappi
            buttonKysymys.Show();
            buttonVastaus.Enabled = false;
            comboBoxVastaus.Enabled = false;

            // Kysymyksen oikea vastaus
            labelOikeaVastaus.Text = registerHandler.Vastaus(VastausHaku);
            
            // Jos vastaus oli oiekin, lisätään piste tietokantaa
            if (vastaus == labelOikeaVastaus.Text)
            {
                
                registerHandler.Pistepaivitys();

                // Näytetään, että vastaus oli oikein
                labelPiste.Show();
                labelOikeinTaiVaarin.Show();
                labelOikeinTaiVaarin.ForeColor = Color.MediumSeaGreen;
                labelOikeinTaiVaarin.Text = "Right answer";

                // Listätään piste tietystä oikeasta vastauksesta tietokantaan
                if (labelOikeaVastaus.Text == "Run")
                {
                    registerHandler.JuoksuPäivitys();
                }
                if (labelOikeaVastaus.Text == "Pass")
                {
                    registerHandler.HeittoPäivitys();
                }
                if(labelOikeaVastaus.Text == "Kick a field goal")
                {
                    registerHandler.PotkuPaivitys();
                }
                if (labelOikeaVastaus.Text == "Kneel down")
                {
                    registerHandler.PolviPaivitys();
                }
            }
            else
            {
                // Näytetään, että vastaus oli väärin ja kerrotaan oikea vastaus
                oikeanVastauksenNäyttäminen();
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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the program?", "Close", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Show();
            label4.Text = "Time remaining: " + sekuntia--.ToString();
            if (sekuntia < 0)
            {
                timer1.Stop();
                buttonKysymys.Show();

                // Kysymyksen oikea vastaus
                labelOikeaVastaus.Text = registerHandler.Vastaus(VastausHaku);

                label4.Text = "Time's up";
                buttonVastaus.Enabled = false;
                comboBoxVastaus.Enabled = false;

                // oikean vastauksen näyttäminen jos aika loppuu
                oikeanVastauksenNäyttäminen();
            }
        }

        private void openDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ohjelman data on kerätty Data World sivustolta. " +
                "Osoite: https://data.world/crowdflower/football-strategy", "Avoin data", MessageBoxButtons.OK);
        }
        private void oikeanVastauksenNäyttäminen()
        {
            labelOikeaVastaus.Show();
            labelOikeaVastaus.Text = "The correct answer was: " + labelOikeaVastaus.Text;
            labelOikeinTaiVaarin.Show();
            labelOikeinTaiVaarin.ForeColor = Color.FromArgb(244, 93, 119);
            labelOikeinTaiVaarin.Text = "Wrong answer";
        }
    }
}
