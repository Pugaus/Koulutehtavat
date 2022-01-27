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
    public partial class Palkinnot : Form
    {
        Pelinlogiikka registerHandler;

        int pisteet = 0;
        int juoksuPisteet = 0;
        int heittoPisteet = 0;
        int potkuPisteet = 0;
        int polviPisteet = 0;

        public Palkinnot()
        {
            registerHandler = new Pelinlogiikka();
            InitializeComponent();
        }

        private void Palkinnot_Load(object sender, EventArgs e)
        {           
            // Näytetään kokonaispisteet 
            labelKokonais.Text = "Totall points: " + registerHandler.PisteHaku(pisteet);
            labelJuoksu.Text = "Totall rushing points: " + registerHandler.JuoksuHaku(juoksuPisteet);
            labelHeitto.Text = "Total passing points: " + registerHandler.HeittoHaku(heittoPisteet);
            labelPotku.Text = "Total field goal points: " + registerHandler.PotkuHaku(potkuPisteet);            

            // Palkintojen rajat joilloin ne tulevat näkyviin
            if (registerHandler.PisteHaku(pisteet) >= 1)
            {
                labelFirstDown.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox1.Visible = true;
                labelPiilotus1.Visible = false;
                
            }
            if (registerHandler.PisteHaku(pisteet) >= 100)
            {
                labelSitu.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox2.Visible = true;
                labelPiilotus2.Visible = false;
            }
            if (registerHandler.PisteHaku(pisteet) >= 500)
            {
                labelBragging.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox3.Visible = true;
                labelPiilotus3.Visible = false;
            }
            if (registerHandler.PisteHaku(pisteet) >= 2262)
            {
                labelIq.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox4.Visible = true;
                labelPiilotus4.Visible = false;
            }
            if (registerHandler.JuoksuHaku(juoksuPisteet) >= 28)
            {
                labelGround.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox6.Visible = true;
                labelPiilotus6.Visible = false;
            }
            if (registerHandler.HeittoHaku(heittoPisteet) >= 55)
            {
                labelDots.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox8.Visible = true;
                labelPiilotus8.Visible = false;
            }
            if(registerHandler.PotkuHaku(heittoPisteet) >= 8)
            {
                labelGoal.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox7.Visible = true;
                labelPiilotus7.Visible = false;
            }
            if(registerHandler.PolviHaku(polviPisteet) >= 1)
            {
                labelVictory.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox5.Visible = true;
                labelPiilotus5.Visible = false;
            }
        }

        private void buttonKysymys_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
