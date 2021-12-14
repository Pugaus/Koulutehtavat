using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button painettuNappi = sender as Button;

            //MessageBox.Show(painettuNappi.Text, "Huom", MessageBoxButtons.OK);

            switch (painettuNappi.Name)
            {
                case "button1":
                    MessageBox.Show("Valinta 1", "Huom");
                    break;
                case "button2":
                    MessageBox.Show("Valinta 2", "Huom");
                    break;
                case "button3":
                    MessageBox.Show("Valinta 3", "Huom");
                    break;
                case "button4":
                    MessageBox.Show("Valinta 4", "Huom");
                    break;
                case "button5":
                    MessageBox.Show("Defaulta", "Huom");
                    break;

            }
        }
    }
}
