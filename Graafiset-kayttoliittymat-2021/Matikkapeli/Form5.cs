using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _15_Matikkapeli
{
    public partial class Form5 : Form
    {
        Random satunnainen = new Random();

        int numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9, numero10;
        int timeLeft;
        string nimimerkki, aikaNimi;

        private void tallennaButton_Click(object sender, EventArgs e)
        {
            if (tunntusBox1.Text.Length <= 0)
            {
                MessageBox.Show("Lisää nimimerkkisi, ennen kuin voit aloittaa!", "Huom!");
            }
            else
            {
                aloitaButton.Visible = true;
                aloitaLabel.Visible = false;
                tunntusBox1.Enabled = false;
                tallennaButton.Enabled = false;
                nimimerkki = tunntusBox1.Text;
            }
        }

        private void poistuButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko poistua harjoituksesta?", "Huom!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (TarkistaVastaukset())
            {
                timer3.Stop();

                int tehtavanKestoAika = 30 - timeLeft;
                aikaNimi = "Nimimerkki: " + nimimerkki + " \tAika: " + tehtavanKestoAika + " Sekunttia";
                using TextWriter txt = new StreamWriter("C:\\Users\\puukk\\graafiset-kayttoliittymat-2021\\15 Matikkapeli\\TuloksetJako.txt", true);
                txt.Write("\n" + aikaNimi);
                txt.Close();

                MessageBox.Show("Sait kaikki vastaukset oikein!", "Hyvä!");
                aloitaButton.Visible = true;
            }
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                aikaLabel.Text = timeLeft + " sekuntia";
            }
            else
            {
                timer3.Stop();
                aikaLabel.Text = "Aika loppui!";
                MessageBox.Show("Aika loppui ennen kuin kerkesit vastata kaikkii kysymyksiin. Oikeat vastaukset on lisätty vastaus kenttään.", "Huom!");
                numericUpDown.Value = numero1 / numero2;
                numericUpDown2.Value = numero3 / numero4;
                numericUpDown3.Value = numero5 / numero6;
                numericUpDown4.Value = numero7 / numero8;
                numericUpDown5.Value = numero9 / numero10;
                aloitaButton.Visible = true;
            }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void aloitaButton_Click(object sender, EventArgs e)
        {
            numero1 = satunnainen.Next(11, 101);
            numero2 = satunnainen.Next(2, 11);
            numero3 = satunnainen.Next(11, 101);
            numero4 = satunnainen.Next(2, 11);
            numero5 = satunnainen.Next(11, 101);
            numero6 = satunnainen.Next(2, 11);
            numero7 = satunnainen.Next(11, 101);
            numero8 = satunnainen.Next(2, 11);
            numero9 = satunnainen.Next(11, 101);
            numero10 = satunnainen.Next(2, 11);

            numeroVasenLabel.Text = numero1.ToString();
            numeroOikeaLabel.Text = numero2.ToString();
            numericUpDown.Value = 0;

            numeroVasenLabel2.Text = numero3.ToString();
            numeroOikeaLabel2.Text = numero4.ToString();
            numericUpDown2.Value = 0;

            numeroVasenLabel3.Text = numero5.ToString();
            numeroOikeaLabel3.Text = numero6.ToString();
            numericUpDown3.Value = 0;

            numeroVasenLabel4.Text = numero7.ToString();
            numeroOikeaLabel4.Text = numero8.ToString();
            numericUpDown4.Value = 0;

            numeroVasenLabel5.Text = numero9.ToString();
            numeroOikeaLabel5.Text = numero10.ToString();
            numericUpDown5.Value = 0;

            timeLeft = 30;
            aikaLabel.Text = "30 sekunttia";
            timer3.Start();
            aloitaButton.Visible = false;
        }
        private bool TarkistaVastaukset()
        {
            if (numero1 / numero2 == numericUpDown.Value & numero3 / numero4 == numericUpDown2.Value & numero5 / numero6 == numericUpDown3.Value & numero7 / numero8 == numericUpDown4.Value & numero9 / numero10 == numericUpDown5.Value)
                return true;

            else
                return false;
        }
    }
}
