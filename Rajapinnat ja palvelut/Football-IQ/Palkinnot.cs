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
        int pisteet;
        string yhteysMerkkiJono = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Football;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        public Palkinnot()
        {
            InitializeComponent();
        }

        private void Palkinnot_Load(object sender, EventArgs e)
        {
            string pisteetSql = "SELECT Pisteet FROM Palkinnot WHERE Id = 1";
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

            // Palkintojen rajat joilloin ne tulevat näkyviin
            if (pisteet >= 1)
            {
                labelFirstDown.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox1.Visible = true;
                labelPiilotus1.Visible = false;
                
            }
            if (pisteet >= 100)
            {
                labelSitu.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox2.Visible = true;
                labelPiilotus2.Visible = false;
            }
            if (pisteet >= 500)
            {
                labelBragging.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox3.Visible = true;
                labelPiilotus3.Visible = false;
            }
            if (pisteet >= 2262)
            {
                labelMadden.ForeColor = Color.FromArgb(244, 93, 119);
                pictureBox4.Visible = true;
                labelPiilotus4.Visible = false;
            }

            // Näytetään kokonaispisteet 
            labelKokonais.Text = "Total points: " + pisteet;
        }

        private void buttonKysymys_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
