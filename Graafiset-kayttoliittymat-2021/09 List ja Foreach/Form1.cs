using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_List_ja_Foreach
{
    public partial class Form1 : Form
    {
        List<string> lista;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lista = new List<string>();
            MessageBox.Show("Lista luotu", "Huom");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                MessageBox.Show("Luo ensin lista");
            }
            else if (textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Lisää jokin merkkijono!", "HUOM");
            }
            else
            {
                lista.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }                                
            //comboBox1.Items.Add(textBox1.Text); Suoraan tallennus comboBoksiin.
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                MessageBox.Show("Luo ensin lista");
            }
            else
            {
                foreach (var item in lista)
                {
                    comboBox1.Items.Add(item);
                }
            }
        }
    }
}
