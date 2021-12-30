namespace Autokauppa.view
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripValikko = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTiedot = new System.Windows.Forms.TableLayoutPanel();
            this.labelVari = new System.Windows.Forms.Label();
            this.labelMittari = new System.Windows.Forms.Label();
            this.textBoxMittari = new System.Windows.Forms.TextBox();
            this.labelTilavuus = new System.Windows.Forms.Label();
            this.textBoxTilavuus = new System.Windows.Forms.TextBox();
            this.labelHinta = new System.Windows.Forms.Label();
            this.textBoxHinta = new System.Windows.Forms.TextBox();
            this.labelMalli = new System.Windows.Forms.Label();
            this.comboBoxMalli = new System.Windows.Forms.ComboBox();
            this.labelMerkki = new System.Windows.Forms.Label();
            this.comboBoxMerkki = new System.Windows.Forms.ComboBox();
            this.labelRekisterointi = new System.Windows.Forms.Label();
            this.dateTimePickerRekisterointi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPolttoaine = new System.Windows.Forms.ComboBox();
            this.comboBoxVari = new System.Windows.Forms.ComboBox();
            this.labelPolttoaine = new System.Windows.Forms.Label();
            this.tableLayoutPanelToiminnot = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUusi = new System.Windows.Forms.Button();
            this.buttonTallenna = new System.Windows.Forms.Button();
            this.buttonPoista = new System.Windows.Forms.Button();
            this.tableLayoutPanelSelaus = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEdellinen = new System.Windows.Forms.Button();
            this.buttonSeuraava = new System.Windows.Forms.Button();
            this.labelJarjestysluku = new System.Windows.Forms.Label();
            this.tableLayoutPanelYlapalkki = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripValikko.SuspendLayout();
            this.tableLayoutPanelTiedot.SuspendLayout();
            this.tableLayoutPanelToiminnot.SuspendLayout();
            this.tableLayoutPanelSelaus.SuspendLayout();
            this.tableLayoutPanelYlapalkki.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripValikko
            // 
            this.menuStripValikko.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemAbout});
            this.menuStripValikko.Location = new System.Drawing.Point(0, 0);
            this.menuStripValikko.Name = "menuStripValikko";
            this.menuStripValikko.Size = new System.Drawing.Size(397, 24);
            this.menuStripValikko.TabIndex = 0;
            this.menuStripValikko.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItemAbout.Text = "&About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "&Testaa tietokantayhteyttä";
            // 
            // tableLayoutPanelTiedot
            // 
            this.tableLayoutPanelTiedot.ColumnCount = 2;
            this.tableLayoutPanelTiedot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTiedot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTiedot.Controls.Add(this.labelVari, 0, 7);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelMittari, 0, 0);
            this.tableLayoutPanelTiedot.Controls.Add(this.textBoxMittari, 1, 0);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelTilavuus, 0, 1);
            this.tableLayoutPanelTiedot.Controls.Add(this.textBoxTilavuus, 1, 1);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelHinta, 0, 2);
            this.tableLayoutPanelTiedot.Controls.Add(this.textBoxHinta, 1, 2);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelMalli, 0, 3);
            this.tableLayoutPanelTiedot.Controls.Add(this.comboBoxMalli, 1, 3);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelMerkki, 0, 4);
            this.tableLayoutPanelTiedot.Controls.Add(this.comboBoxMerkki, 1, 4);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelRekisterointi, 0, 5);
            this.tableLayoutPanelTiedot.Controls.Add(this.dateTimePickerRekisterointi, 1, 5);
            this.tableLayoutPanelTiedot.Controls.Add(this.comboBoxPolttoaine, 1, 6);
            this.tableLayoutPanelTiedot.Controls.Add(this.comboBoxVari, 1, 7);
            this.tableLayoutPanelTiedot.Controls.Add(this.labelPolttoaine, 0, 6);
            this.tableLayoutPanelTiedot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTiedot.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanelTiedot.Name = "tableLayoutPanelTiedot";
            this.tableLayoutPanelTiedot.RowCount = 8;
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelTiedot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTiedot.Size = new System.Drawing.Size(397, 262);
            this.tableLayoutPanelTiedot.TabIndex = 1;
            // 
            // labelVari
            // 
            this.labelVari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVari.AutoSize = true;
            this.labelVari.Location = new System.Drawing.Point(98, 236);
            this.labelVari.Name = "labelVari";
            this.labelVari.Size = new System.Drawing.Size(28, 13);
            this.labelVari.TabIndex = 0;
            this.labelVari.Text = "Väri:";
            // 
            // labelMittari
            // 
            this.labelMittari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMittari.AutoSize = true;
            this.labelMittari.Location = new System.Drawing.Point(54, 9);
            this.labelMittari.Name = "labelMittari";
            this.labelMittari.Size = new System.Drawing.Size(72, 13);
            this.labelMittari.TabIndex = 0;
            this.labelMittari.Text = "Mittarilukema:";
            // 
            // textBoxMittari
            // 
            this.textBoxMittari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMittari.Location = new System.Drawing.Point(132, 6);
            this.textBoxMittari.Name = "textBoxMittari";
            this.textBoxMittari.Size = new System.Drawing.Size(262, 20);
            this.textBoxMittari.TabIndex = 6;
            // 
            // labelTilavuus
            // 
            this.labelTilavuus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTilavuus.AutoSize = true;
            this.labelTilavuus.Location = new System.Drawing.Point(33, 41);
            this.labelTilavuus.Name = "labelTilavuus";
            this.labelTilavuus.Size = new System.Drawing.Size(93, 13);
            this.labelTilavuus.TabIndex = 1;
            this.labelTilavuus.Text = "Moottorin tilavuus:";
            // 
            // textBoxTilavuus
            // 
            this.textBoxTilavuus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTilavuus.Location = new System.Drawing.Point(132, 38);
            this.textBoxTilavuus.Name = "textBoxTilavuus";
            this.textBoxTilavuus.Size = new System.Drawing.Size(262, 20);
            this.textBoxTilavuus.TabIndex = 6;
            // 
            // labelHinta
            // 
            this.labelHinta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHinta.AutoSize = true;
            this.labelHinta.Location = new System.Drawing.Point(91, 73);
            this.labelHinta.Name = "labelHinta";
            this.labelHinta.Size = new System.Drawing.Size(35, 13);
            this.labelHinta.TabIndex = 2;
            this.labelHinta.Text = "Hinta:";
            // 
            // textBoxHinta
            // 
            this.textBoxHinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHinta.Location = new System.Drawing.Point(132, 70);
            this.textBoxHinta.Name = "textBoxHinta";
            this.textBoxHinta.Size = new System.Drawing.Size(262, 20);
            this.textBoxHinta.TabIndex = 6;
            // 
            // labelMalli
            // 
            this.labelMalli.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMalli.AutoSize = true;
            this.labelMalli.Location = new System.Drawing.Point(95, 105);
            this.labelMalli.Name = "labelMalli";
            this.labelMalli.Size = new System.Drawing.Size(31, 13);
            this.labelMalli.TabIndex = 4;
            this.labelMalli.Text = "Malli:";
            // 
            // comboBoxMalli
            // 
            this.comboBoxMalli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMalli.FormattingEnabled = true;
            this.comboBoxMalli.Location = new System.Drawing.Point(132, 101);
            this.comboBoxMalli.Name = "comboBoxMalli";
            this.comboBoxMalli.Size = new System.Drawing.Size(262, 21);
            this.comboBoxMalli.TabIndex = 7;
            // 
            // labelMerkki
            // 
            this.labelMerkki.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMerkki.AutoSize = true;
            this.labelMerkki.Location = new System.Drawing.Point(84, 137);
            this.labelMerkki.Name = "labelMerkki";
            this.labelMerkki.Size = new System.Drawing.Size(42, 13);
            this.labelMerkki.TabIndex = 3;
            this.labelMerkki.Text = "Merkki:";
            // 
            // comboBoxMerkki
            // 
            this.comboBoxMerkki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMerkki.FormattingEnabled = true;
            this.comboBoxMerkki.Location = new System.Drawing.Point(132, 133);
            this.comboBoxMerkki.Name = "comboBoxMerkki";
            this.comboBoxMerkki.Size = new System.Drawing.Size(262, 21);
            this.comboBoxMerkki.TabIndex = 8;
            this.comboBoxMerkki.SelectedIndexChanged += new System.EventHandler(this.comboBoxMerkki_SelectedIndexChanged);
            // 
            // labelRekisterointi
            // 
            this.labelRekisterointi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRekisterointi.AutoSize = true;
            this.labelRekisterointi.Location = new System.Drawing.Point(3, 169);
            this.labelRekisterointi.Name = "labelRekisterointi";
            this.labelRekisterointi.Size = new System.Drawing.Size(123, 13);
            this.labelRekisterointi.TabIndex = 5;
            this.labelRekisterointi.Text = "Rekisteröintipäivämäärä:";
            // 
            // dateTimePickerRekisterointi
            // 
            this.dateTimePickerRekisterointi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerRekisterointi.Location = new System.Drawing.Point(132, 166);
            this.dateTimePickerRekisterointi.Name = "dateTimePickerRekisterointi";
            this.dateTimePickerRekisterointi.Size = new System.Drawing.Size(262, 20);
            this.dateTimePickerRekisterointi.TabIndex = 9;
            // 
            // comboBoxPolttoaine
            // 
            this.comboBoxPolttoaine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPolttoaine.Location = new System.Drawing.Point(132, 197);
            this.comboBoxPolttoaine.Name = "comboBoxPolttoaine";
            this.comboBoxPolttoaine.Size = new System.Drawing.Size(262, 21);
            this.comboBoxPolttoaine.TabIndex = 11;
            // 
            // comboBoxVari
            // 
            this.comboBoxVari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVari.Location = new System.Drawing.Point(132, 232);
            this.comboBoxVari.Name = "comboBoxVari";
            this.comboBoxVari.Size = new System.Drawing.Size(262, 21);
            this.comboBoxVari.TabIndex = 12;
            // 
            // labelPolttoaine
            // 
            this.labelPolttoaine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPolttoaine.AutoSize = true;
            this.labelPolttoaine.Location = new System.Drawing.Point(69, 201);
            this.labelPolttoaine.Name = "labelPolttoaine";
            this.labelPolttoaine.Size = new System.Drawing.Size(57, 13);
            this.labelPolttoaine.TabIndex = 10;
            this.labelPolttoaine.Text = "Polttoaine:";
            // 
            // tableLayoutPanelToiminnot
            // 
            this.tableLayoutPanelToiminnot.AutoSize = true;
            this.tableLayoutPanelToiminnot.ColumnCount = 3;
            this.tableLayoutPanelToiminnot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelToiminnot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelToiminnot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelToiminnot.Controls.Add(this.buttonUusi, 0, 0);
            this.tableLayoutPanelToiminnot.Controls.Add(this.buttonTallenna, 1, 0);
            this.tableLayoutPanelToiminnot.Controls.Add(this.buttonPoista, 2, 0);
            this.tableLayoutPanelToiminnot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelToiminnot.Location = new System.Drawing.Point(0, 299);
            this.tableLayoutPanelToiminnot.Name = "tableLayoutPanelToiminnot";
            this.tableLayoutPanelToiminnot.RowCount = 1;
            this.tableLayoutPanelToiminnot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelToiminnot.Size = new System.Drawing.Size(397, 29);
            this.tableLayoutPanelToiminnot.TabIndex = 2;
            // 
            // buttonUusi
            // 
            this.buttonUusi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUusi.Location = new System.Drawing.Point(80, 3);
            this.buttonUusi.Name = "buttonUusi";
            this.buttonUusi.Size = new System.Drawing.Size(75, 23);
            this.buttonUusi.TabIndex = 0;
            this.buttonUusi.Text = "Uusi tietue";
            this.buttonUusi.UseVisualStyleBackColor = true;
            this.buttonUusi.Click += new System.EventHandler(this.buttonUusi_Click);
            // 
            // buttonTallenna
            // 
            this.buttonTallenna.Location = new System.Drawing.Point(161, 3);
            this.buttonTallenna.Name = "buttonTallenna";
            this.buttonTallenna.Size = new System.Drawing.Size(75, 23);
            this.buttonTallenna.TabIndex = 1;
            this.buttonTallenna.Text = "Tallenna";
            this.buttonTallenna.UseVisualStyleBackColor = true;
            // 
            // buttonPoista
            // 
            this.buttonPoista.Location = new System.Drawing.Point(242, 3);
            this.buttonPoista.Name = "buttonPoista";
            this.buttonPoista.Size = new System.Drawing.Size(75, 23);
            this.buttonPoista.TabIndex = 2;
            this.buttonPoista.Text = "Poista";
            this.buttonPoista.UseVisualStyleBackColor = true;
            this.buttonPoista.Click += new System.EventHandler(this.buttonPoista_Click);
            // 
            // tableLayoutPanelSelaus
            // 
            this.tableLayoutPanelSelaus.AutoSize = true;
            this.tableLayoutPanelSelaus.ColumnCount = 2;
            this.tableLayoutPanelSelaus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSelaus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSelaus.Controls.Add(this.buttonEdellinen, 0, 0);
            this.tableLayoutPanelSelaus.Controls.Add(this.buttonSeuraava, 1, 0);
            this.tableLayoutPanelSelaus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelSelaus.Location = new System.Drawing.Point(0, 328);
            this.tableLayoutPanelSelaus.Name = "tableLayoutPanelSelaus";
            this.tableLayoutPanelSelaus.RowCount = 1;
            this.tableLayoutPanelSelaus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSelaus.Size = new System.Drawing.Size(397, 29);
            this.tableLayoutPanelSelaus.TabIndex = 3;
            // 
            // buttonEdellinen
            // 
            this.buttonEdellinen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdellinen.Location = new System.Drawing.Point(120, 3);
            this.buttonEdellinen.Name = "buttonEdellinen";
            this.buttonEdellinen.Size = new System.Drawing.Size(75, 23);
            this.buttonEdellinen.TabIndex = 0;
            this.buttonEdellinen.Text = "< Edellinen";
            this.buttonEdellinen.UseVisualStyleBackColor = true;
            this.buttonEdellinen.Click += new System.EventHandler(this.buttonEdellinen_Click);
            // 
            // buttonSeuraava
            // 
            this.buttonSeuraava.Location = new System.Drawing.Point(201, 3);
            this.buttonSeuraava.Name = "buttonSeuraava";
            this.buttonSeuraava.Size = new System.Drawing.Size(75, 23);
            this.buttonSeuraava.TabIndex = 1;
            this.buttonSeuraava.Text = "Seuraava >";
            this.buttonSeuraava.UseVisualStyleBackColor = true;
            this.buttonSeuraava.Click += new System.EventHandler(this.buttonSeuraava_Click);
            // 
            // labelJarjestysluku
            // 
            this.labelJarjestysluku.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJarjestysluku.AutoSize = true;
            this.labelJarjestysluku.Location = new System.Drawing.Point(198, 0);
            this.labelJarjestysluku.Name = "labelJarjestysluku";
            this.labelJarjestysluku.Size = new System.Drawing.Size(0, 13);
            this.labelJarjestysluku.TabIndex = 4;
            // 
            // tableLayoutPanelYlapalkki
            // 
            this.tableLayoutPanelYlapalkki.AutoSize = true;
            this.tableLayoutPanelYlapalkki.ColumnCount = 1;
            this.tableLayoutPanelYlapalkki.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelYlapalkki.Controls.Add(this.labelJarjestysluku, 0, 0);
            this.tableLayoutPanelYlapalkki.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelYlapalkki.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelYlapalkki.Name = "tableLayoutPanelYlapalkki";
            this.tableLayoutPanelYlapalkki.RowCount = 1;
            this.tableLayoutPanelYlapalkki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelYlapalkki.Size = new System.Drawing.Size(397, 13);
            this.tableLayoutPanelYlapalkki.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 357);
            this.Controls.Add(this.tableLayoutPanelTiedot);
            this.Controls.Add(this.tableLayoutPanelToiminnot);
            this.Controls.Add(this.tableLayoutPanelSelaus);
            this.Controls.Add(this.tableLayoutPanelYlapalkki);
            this.Controls.Add(this.menuStripValikko);
            this.MainMenuStrip = this.menuStripValikko;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStripValikko.ResumeLayout(false);
            this.menuStripValikko.PerformLayout();
            this.tableLayoutPanelTiedot.ResumeLayout(false);
            this.tableLayoutPanelTiedot.PerformLayout();
            this.tableLayoutPanelToiminnot.ResumeLayout(false);
            this.tableLayoutPanelSelaus.ResumeLayout(false);
            this.tableLayoutPanelYlapalkki.ResumeLayout(false);
            this.tableLayoutPanelYlapalkki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripValikko;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTiedot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelToiminnot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSelaus;
        private System.Windows.Forms.Button buttonUusi;
        private System.Windows.Forms.Button buttonTallenna;
        private System.Windows.Forms.Button buttonPoista;
        private System.Windows.Forms.Button buttonEdellinen;
        private System.Windows.Forms.Button buttonSeuraava;
        private System.Windows.Forms.Label labelMittari;
        private System.Windows.Forms.Label labelTilavuus;
        private System.Windows.Forms.Label labelHinta;
        private System.Windows.Forms.Label labelMerkki;
        private System.Windows.Forms.Label labelMalli;
        private System.Windows.Forms.Label labelRekisterointi;
        private System.Windows.Forms.TextBox textBoxTilavuus;
        private System.Windows.Forms.TextBox textBoxMittari;
        private System.Windows.Forms.TextBox textBoxHinta;
        private System.Windows.Forms.ComboBox comboBoxMalli;
        private System.Windows.Forms.ComboBox comboBoxMerkki;
        private System.Windows.Forms.DateTimePicker dateTimePickerRekisterointi;
        private System.Windows.Forms.Label labelVari;
        private System.Windows.Forms.Label labelPolttoaine;
        private System.Windows.Forms.ComboBox comboBoxPolttoaine;
        private System.Windows.Forms.ComboBox comboBoxVari;
        private System.Windows.Forms.Label labelJarjestysluku;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelYlapalkki;
    }
}