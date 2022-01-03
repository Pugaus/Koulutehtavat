using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Dictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> hakemisto;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hakemisto = new Dictionary<string, string>();
            lisaaElementti.Enabled = true;

        }

        private void lisaaElementti_Click(object sender, EventArgs e)
        {
            if(avain.Text.Length <= 0 || arvo.Text.Length <= 0)
            {
                MessageBox.Show("Key ja value kohdissa pitää olla jonkinlainen merrkijono", "HUOM!");
            }
            else
            {
                hakemisto.Add(avain.Text, arvo.Text);
                haeElementti.Enabled = true;
                avain.Text = string.Empty;
                arvo.Text = string.Empty;

            }            
        }
        private void haeElementti_Click(object sender, EventArgs e)
        {
            string hakuTulos;

            if (hakemisto.TryGetValue(avainHaku.Text, out hakuTulos))
            {
                arvonPalautus.Text = hakuTulos;
                avainHaku.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Hakemistosta ei löytynyt hakemaasi avainta, yritä uudelleen.", "HUOM!");
            }
        }
    }
}
