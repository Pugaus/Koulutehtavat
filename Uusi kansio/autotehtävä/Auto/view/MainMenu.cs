using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        KaupanLogiikka registerHandler;

        private List<Auto> autot;
        private List<AutonMerkki> merkit;
        private List<AutonMalli> mallit;
        private List<AutonVari> varit;
        private List<AutonPolttoaine> polttoaineet;
        // Valitun auton indeksi autot-listassa.
        int autotValittuIndeksi;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            HaeAutot();
            AlustaValikot();

            autotValittuIndeksi = 0;
            ValitseAuto(autotValittuIndeksi);
        }

        private void HaeAutot()
        {
            autot = registerHandler.getAllAutos();
        }

        private void AlustaValikot()
        {
            merkit = registerHandler.getAllAutoMakers();
            comboBoxMerkki.Items.AddRange(merkit.ToArray());
            varit = registerHandler.getAllColors();
            comboBoxVari.Items.AddRange(varit.ToArray());
            polttoaineet = registerHandler.getAllFuels();
            comboBoxPolttoaine.Items.AddRange(polttoaineet.ToArray());
        }

        private void HaeMallit()
        {
            PoistaComboBoxValinta(ref comboBoxMalli);
            comboBoxMalli.Items.Clear();
            // Jos ollaan valittu merkki, niin haetaan mallit merkin mukaan.
            if (comboBoxMerkki.SelectedItem is AutonMerkki valittuMerkki)
            {
                mallit = registerHandler.getAutoModels(valittuMerkki.Id);
                comboBoxMalli.Items.AddRange(mallit.ToArray());
            }
        }

        private void ValitseAuto(int indeksi)
        {
            NaytaAuto(autot[indeksi]);
            labelJarjestysluku.Text = (autotValittuIndeksi + 1).ToString();
        }

        private void NaytaAuto(Auto auto)
        {
            comboBoxMerkki.SelectedItem = merkit.Find(
                merkki => merkki.Id == auto.AutonMerkkiID);
            // Haetaan merkkiä vastaavat mallit mallilistaan ja -valikkoon.
            HaeMallit();
            comboBoxMalli.SelectedItem = mallit.Find(
                malli => malli.Id == auto.AutonMalliID);
            comboBoxVari.SelectedItem = varit.Find(
                vari => vari.Id == auto.VaritID);
            comboBoxPolttoaine.SelectedItem = polttoaineet.Find(
                polttoaine => polttoaine.Id == auto.PolttoaineID);

            textBoxMittari.Text = auto.Mittarilukema.ToString();
            textBoxTilavuus.Text = auto.Moottorin_tilavuus.ToString();
            textBoxHinta.Text = auto.Hinta.ToString();

            dateTimePickerRekisterointi.Value = auto.Rekisteri_paivamaara;
        }

        private void TyhjennaKentat()
        {
            textBoxMittari.Text = string.Empty;
            textBoxTilavuus.Text = string.Empty;
            textBoxHinta.Text = string.Empty;
            PoistaComboBoxValinta(ref comboBoxMerkki);
            // Tyhjentää mallit-valikon koska tyhjä merkkivalinta.
            HaeMallit();
            PoistaComboBoxValinta(ref comboBoxVari);
            PoistaComboBoxValinta(ref comboBoxPolttoaine);
            dateTimePickerRekisterointi.Value = DateTime.Today;
        }

        private void PoistaComboBoxValinta(ref ComboBox cb)
        {
            // Ei valintaa.
            cb.SelectedIndex = -1;
            cb.Text = string.Empty;
        }

        private void comboBoxMerkki_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Haetaan mallit aina kun valitaan uusi merkki.
            HaeMallit();
        }

        private void buttonUusi_Click(object sender, EventArgs e)
        {
            TyhjennaKentat();
        }

        private void buttonEdellinen_Click(object sender, EventArgs e)
        {
            // Jos selataan taaksepäin listan alussa, niin valitaan listan viimeinen auto.
            if (--autotValittuIndeksi < 0)
            {
                autotValittuIndeksi = autot.Count - 1;
            }
            ValitseAuto(autotValittuIndeksi);
        }

        private void buttonSeuraava_Click(object sender, EventArgs e)
        {
            // Jos selataan eteenpäin listan lopussa, niin valitaan listan ensimmäinen auto.
            if (++autotValittuIndeksi == autot.Count)
            {
                autotValittuIndeksi = 0;
            }
            ValitseAuto(autotValittuIndeksi);
        }

        private void buttonPoista_Click(object sender, EventArgs e)
        {
            registerHandler.removeAuto(autot[autotValittuIndeksi]);
            autot.RemoveAt(autotValittuIndeksi);
            if (autotValittuIndeksi >= autot.Count)
            {
                autotValittuIndeksi = autot.Count - 1;
            }
            ValitseAuto(autotValittuIndeksi);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}