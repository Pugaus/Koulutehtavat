using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Matikkapeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pelaaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 peliValikko = new Form2();
            peliValikko.ShowDialog();

            this.Show();
        }

        private void PoistuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saavutuksetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 saavutukset = new Form7();
            saavutukset.ShowDialog();

            this.Show();
        }
    }
}
