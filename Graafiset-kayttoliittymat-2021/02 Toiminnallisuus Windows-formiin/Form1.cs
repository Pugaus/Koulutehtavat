using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_grafiikka
{
    public partial class Form1 : Form
    {
        string vuosi = DateTime.Now.Year.ToString();

        public Form1()
        {
            InitializeComponent();
        }         
        private void textBoxNimi_Leave(object sender, EventArgs e)
        {
            if (textBoxNimi.Text.Length == 0)
            {
                textBoxNimi.Text = "[Syötä elokuvan nimi]";
                textBoxNimi.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBoxNimi_Enter(object sender, EventArgs e)
        {
            if (textBoxNimi.Text == "[Syötä elokuvan nimi]")
            {
                textBoxNimi.Text = "";
                textBoxNimi.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBoxVuosi_Leave(object sender, EventArgs e)
        {
            if (textBoxVuosi.Text.Length == 0)
            {
                textBoxVuosi.Text = vuosi;
                textBoxVuosi.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBoxVuosi_Enter(object sender, EventArgs e)
        {
            if (textBoxVuosi.Text == vuosi)
            {
                textBoxVuosi.Text = "";
                textBoxVuosi.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBoxKesto_Leave(object sender, EventArgs e)
        {
            if (textBoxKesto.Text.Length == 0)
            {
                textBoxKesto.Text = "0";
                textBoxKesto.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBoxKesto_Enter(object sender, EventArgs e)
        {
            if (textBoxKesto.Text == "0")
            {
                textBoxKesto.Text = "";
                textBoxKesto.ForeColor = SystemColors.WindowText;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Teemu Puukka");
        }
        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko poistua sovelluksesta?","Sulje sovellus", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buttonUusiTietue_Click(object sender, EventArgs e)
        {
            textBoxID.ForeColor = SystemColors.GrayText;
            textBoxID.Text = "0";

            textBoxNimi.ForeColor = SystemColors.GrayText;
            textBoxNimi.Text = "[Syötä elokuvan nimi]";
            this.textBoxNimi.Leave += new System.EventHandler(this.textBoxNimi_Leave);
            this.textBoxNimi.Enter += new System.EventHandler(this.textBoxNimi_Enter);

            textBoxVuosi.ForeColor = SystemColors.GrayText;
            textBoxVuosi.Text = vuosi;
            this.textBoxVuosi.Leave += new System.EventHandler(this.textBoxVuosi_Leave);
            this.textBoxVuosi.Enter += new System.EventHandler(this.textBoxVuosi_Enter);

            textBoxKesto.ForeColor = SystemColors.GrayText;
            textBoxKesto.Text = "0";
            this.textBoxKesto.Leave += new System.EventHandler(this.textBoxKesto_Leave);
            this.textBoxKesto.Enter += new System.EventHandler(this.textBoxKesto_Enter);
        }
        private void buttonTallenna_Click(object sender, EventArgs e)
        {
            if (textBoxNimi.Text == "[Syötä elokuvan nimi]" || textBoxNimi.TextLength == 0)
            {
                MessageBox.Show("Et ole syöttänyt elokuvalle nimeä");
            }
            else if (!textBoxVuosi.Text.All(char.IsDigit))
            {
                MessageBox.Show("Syötä vain numeroita julkaisuvuosi kenttään");
            }
            else if (textBoxVuosi.TextLength == 0)
            {
                MessageBox.Show("Et ole syöttanyt elokuvalle julkaisuvuotta");
            }
            else if (!textBoxKesto.Text.All(char.IsDigit))
            {
                MessageBox.Show("Syötä vain numeroita kesto kenttään");
            }
            else if (textBoxKesto.TextLength == 0 || textBoxKesto.Text == "0")
            {
                MessageBox.Show("Et ole syöttänyt elokuvalle kesoaikaa");
            }
            else
            {
                MessageBox.Show("Check OK!");
            }
        }
    }
}
