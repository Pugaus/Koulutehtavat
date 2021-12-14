using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _05_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            
            if (int.TryParse(textBox1.Text, out numero))
            {
                for (int i = 0; i < numero +1; i++)
                {
                    label1.Text = i.ToString();
                    Thread.Sleep(100);
                    label1.Update();
                }                
            }
            else
            {
                MessageBox.Show("Syötä vain numeroita!", "Huom", MessageBoxButtons.OK);
            }
        }
    }
}
