using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Array_Lotto
{
    public partial class Form1 : Form
    {
        Random numerot = new Random();
        int[] lottonumerot = new int[9];
        public Form1()
        {
            InitializeComponent();
        }
        private void arvoNumerot_Click(object sender, EventArgs e)
        {
            HashSet<int> lottoPallot = new HashSet<int>();
            for (int i = 0; i < 40; i++)
            {
                lottoPallot.Add(i + 1);
            }
            for (int i = 0; i < 9; i++)
            {
                lottonumerot[i] = lottoPallot.ToList()[numerot.Next(0, lottoPallot.Count)];
                lottoPallot.Remove(lottonumerot[i]);
            }

            int[] varsinaisetNumerot = new int[7];
            int[] lisanumerot = new int[2];
            Array.ConstrainedCopy(lottonumerot, 0, varsinaisetNumerot, 0, 7);
            Array.ConstrainedCopy(lottonumerot, 7, lisanumerot, 0, 2);

            Array.Sort(varsinaisetNumerot);
            Array.Sort(lisanumerot);

            arvotutNumerot.Text = string.Join(", ", varsinaisetNumerot);
            textBox2.Text = string.Join(", ", lisanumerot);

            int montaOikein = 0;
            int montaLisanumeroaOikein = 0;

            foreach (Control control in this.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown kontrolli = control as NumericUpDown;
                    int numero = (int)kontrolli.Value;

                    foreach (int item in varsinaisetNumerot)
                    {
                        if (item == numero)
                        {
                            montaOikein++;
                        }

                    }
                    foreach (int item in lisanumerot)
                    {
                        if (item == numero)
                        {
                            montaLisanumeroaOikein++;
                        }
                    }
                }
            }
            montaOikeinTeksti.Text = montaOikein.ToString();
            lisaOikeinTeksti.Text = montaLisanumeroaOikein.ToString();
        }
    }
}
