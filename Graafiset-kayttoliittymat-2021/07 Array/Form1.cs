using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Array
{
    public partial class Form1 : Form
    {
        int numero, indeksi, arrayKoko, hakuIndeksi;
        int[] taulukko;
        string tulos;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (taulukonKoko.Text.Length <= 0)
                {
                    MessageBox.Show("Syötä jokin luku!");
                }
                else
                {
                    arrayKoko = Convert.ToInt32(taulukonKoko.Text);
                    taulukko = new int[arrayKoko + 1];
                    MessageBox.Show("Taulukon koko tallennettu!");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Syötä pienempi luku!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Syötä vain numeroita!", "HUOM!");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Talleta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TalletettavaNumero.Text.All(char.IsDigit) || !TalletettavaIndeksi.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Syötä vain numeroita indeksi ja numero kenttään!", "HUOM!");
                }
                else
                {
                    numero = Convert.ToInt32(TalletettavaNumero.Text);
                    indeksi = Convert.ToInt32(TalletettavaIndeksi.Text);

                    taulukko[indeksi] = numero;

                    TalletettavaNumero.Text = string.Empty;
                    TalletettavaIndeksi.Text = string.Empty;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indeksi on liian suuri taulukon kokoon nähden!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Syötä pienempi luku!");
            }
        }
        private void Hae_Click(object sender, EventArgs e)
        {           
            try
            {
                if (TalletuspaikanIndeksi.TextLength <= 0)
                {
                    MessageBox.Show("Syötä jokin luku haku kenttään!");
                }
                else
                {
                    hakuIndeksi = Convert.ToInt32(TalletuspaikanIndeksi.Text);
                    tulos = taulukko[hakuIndeksi].ToString();
                    Tulos.Text = tulos;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indeksi on liian suuri taulukon kokoon nähden!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Syötä pienempi luku!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Syötä vain numeroita!", "HUOM!");
            }
        }
    }
}
