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
    public partial class Form1 : Form
    {
        string vastaus;
        string yhteysMerkkiJono = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Football;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;" +
            "Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelKysymys.Hide();
            labelOikeaVastaus.Hide();
            labelOikeinTaiVaarin.Hide();
            comboBoxVastaus.Hide();
            buttonVastaus.Hide();
            
        }

        private void buttonKysymys_Click(object sender, EventArgs e)
        {

            comboBoxVastaus.ResetText();
            labelKysymys.Show();
            labelOikeinTaiVaarin.Hide();
            labelOikeaVastaus.Hide();
            comboBoxVastaus.Show();
            buttonVastaus.Show();
            buttonKysymys.Hide();
            buttonVastaus.Enabled = true;
            comboBoxVastaus.Enabled = true;


            string kysymysSql = "SELECT TOP 1 Skenaario FROM Kysymykset ORDER BY NEWID()";

            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                yhteys.Open();
                using (SqlCommand command = new SqlCommand(kysymysSql, yhteys))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        labelKysymys.Text = reader[0] as string;
                    }
                }
                yhteys.Close();

            }
        }
        private void buttonVastaus_Click(object sender, EventArgs e)
        {

            buttonKysymys.Show();
            buttonVastaus.Enabled = false;
            comboBoxVastaus.Enabled = false;
            string vastausSql = "SELECT Vastaus FROM Kysymykset WHERE Skenaario = " + "'" + labelKysymys.Text + "'";

            using (SqlConnection yhteys = new SqlConnection(yhteysMerkkiJono))
            {
                yhteys.Open();
                using (SqlCommand command = new SqlCommand(vastausSql, yhteys))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        labelOikeaVastaus.Text = reader["Vastaus"].ToString();
                        break;
                    }
                }
                yhteys.Close();
            }            

            if (vastaus == labelOikeaVastaus.Text)
            {                
                labelOikeinTaiVaarin.Show();
                labelOikeinTaiVaarin.ForeColor = Color.MediumSeaGreen;
                labelOikeinTaiVaarin.Text = "Right answer";
            }
            else
            {
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
    }
}
