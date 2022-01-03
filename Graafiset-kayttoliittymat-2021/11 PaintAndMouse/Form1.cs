using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_PaintAndMouse
{
    public partial class Form1 : Form
    {
        Point piste = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            Graphics Graf = e.Graphics;

            // - Pää 
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,
            piste.X + 21, piste.Y + 131);

            // - Kädet 
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,
            piste.X + 70, piste.Y + 60);

            // - Jalat 
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X + 70, piste.Y + 181);

            // Kutsutaan DrawCoordinates()-metodia. 
            DrawCordinates(Graf);
        }
        // DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle.  

        private void DrawCordinates(Graphics Graf)
        {
            // Piirretään piirtokoordinaattien arvot näytölle. 
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

            new Font("Arial", 14, System.Drawing.FontStyle.Regular),
            new SolidBrush(Color.Black), 8, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                piste.X = int.Parse(textBoxX.Text);
                piste.Y = int.Parse(textBoxY.Text);
                Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Väärä koordinaatti", "Huom!");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 
                // on formin työalueen vasemmassa ylä nurkassa                
                piste = e.Location;
                
                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 
                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
    }
}
