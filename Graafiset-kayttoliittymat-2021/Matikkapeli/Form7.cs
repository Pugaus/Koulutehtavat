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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pelaaButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\puukk\\graafiset-kayttoliittymat-2021\\15 Matikkapeli\\TuloksetYhteen.txt";
            using StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            MessageBox.Show(filedata.ToString());
        }

        private void vahennysButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\puukk\\graafiset-kayttoliittymat-2021\\15 Matikkapeli\\TuloksetVahennys.txt";
            using StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            MessageBox.Show(filedata.ToString());
        }

        private void kertoButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\puukk\\graafiset-kayttoliittymat-2021\\15 Matikkapeli\\TuloksetKerto.txt";
            using StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            MessageBox.Show(filedata.ToString());
        }

        private void jakoButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\puukk\\graafiset-kayttoliittymat-2021\\15 Matikkapeli\\TuloksetJako.txt";
            using StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            MessageBox.Show(filedata.ToString());
        }
        private void poistuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
