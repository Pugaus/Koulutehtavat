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

        public Palkinnot()
        {
            registerHandler = new Pelinlogiikka();
            InitializeComponent();
        }

        private void Palkinnot_Load(object sender, EventArgs e)
        {           
            // Haetaan pisteet
            registerHandler.PisteHaku(pisteet);

            // Näytetään kokonaispisteet 
            labelKokonais.Text = "Total points: " + registerHandler.PisteHaku(pisteet);

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
                labelMadden.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox4.Visible = true;
                labelPiilotus4.Visible = false;
            }           
        }

        private void buttonKysymys_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
