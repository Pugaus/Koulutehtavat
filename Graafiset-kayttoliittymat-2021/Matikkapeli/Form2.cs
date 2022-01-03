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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void yhteenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 yhteenlasku = new Form3();
            yhteenlasku.ShowDialog();

            this.Show();
        }

        private void vahennysButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 vahennyslasku = new Form4();
            vahennyslasku.ShowDialog();

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 jakolasku = new Form5();
            jakolasku.ShowDialog();

            this.Show();
        }

        private void kertoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 kertolasku = new Form6();
            kertolasku.ShowDialog();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
