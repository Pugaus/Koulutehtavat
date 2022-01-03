using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kysymys = true;

            while (kysymys)
            {
                if (MessageBox.Show("Valitse KYLLÄ jatkaaksesi tai EI lopettaaksesi", "Huom!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
                else
                {
                    kysymys = false;
                }                              
            }
        }
    }
}
