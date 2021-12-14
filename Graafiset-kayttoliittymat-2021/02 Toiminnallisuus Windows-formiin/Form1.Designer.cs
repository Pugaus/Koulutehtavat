
namespace Harjoitus_grafiikka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hjhjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxToiminnallisuus = new System.Windows.Forms.GroupBox();
            this.buttonPoista = new System.Windows.Forms.Button();
            this.buttonTallenna = new System.Windows.Forms.Button();
            this.buttonUusiTietue = new System.Windows.Forms.Button();
            this.groupBoxTiedot = new System.Windows.Forms.GroupBox();
            this.textBoxKesto = new System.Windows.Forms.TextBox();
            this.textBoxVuosi = new System.Windows.Forms.TextBox();
            this.textBoxNimi = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSeuraava = new System.Windows.Forms.Button();
            this.buttonEdellinen = new System.Windows.Forms.Button();
            this.groupBoxArvio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxArvio = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxToiminnallisuus.SuspendLayout();
            this.groupBoxTiedot.SuspendLayout();
            this.groupBoxArvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hjhjToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hjhjToolStripMenuItem
            // 
            this.hjhjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.hjhjToolStripMenuItem.Name = "hjhjToolStripMenuItem";
            this.hjhjToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.hjhjToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantojaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantojaToolStripMenuItem
            // 
            this.testaaTietokantojaToolStripMenuItem.Name = "testaaTietokantojaToolStripMenuItem";
            this.testaaTietokantojaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantojaToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // groupBoxToiminnallisuus
            // 
            this.groupBoxToiminnallisuus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxToiminnallisuus.Controls.Add(this.buttonPoista);
            this.groupBoxToiminnallisuus.Controls.Add(this.buttonTallenna);
            this.groupBoxToiminnallisuus.Controls.Add(this.buttonUusiTietue);
            this.groupBoxToiminnallisuus.Location = new System.Drawing.Point(385, 44);
            this.groupBoxToiminnallisuus.Name = "groupBoxToiminnallisuus";
            this.groupBoxToiminnallisuus.Size = new System.Drawing.Size(244, 478);
            this.groupBoxToiminnallisuus.TabIndex = 2;
            this.groupBoxToiminnallisuus.TabStop = false;
            this.groupBoxToiminnallisuus.Text = "Toiminnallisuus";
            this.groupBoxToiminnallisuus.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonPoista
            // 
            this.buttonPoista.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPoista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.buttonPoista.ForeColor = System.Drawing.Color.White;
            this.buttonPoista.Location = new System.Drawing.Point(17, 184);
            this.buttonPoista.Name = "buttonPoista";
            this.buttonPoista.Size = new System.Drawing.Size(214, 57);
            this.buttonPoista.TabIndex = 2;
            this.buttonPoista.Text = "Poista";
            this.buttonPoista.UseVisualStyleBackColor = false;
            // 
            // buttonTallenna
            // 
            this.buttonTallenna.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTallenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(147)))));
            this.buttonTallenna.Location = new System.Drawing.Point(17, 112);
            this.buttonTallenna.Name = "buttonTallenna";
            this.buttonTallenna.Size = new System.Drawing.Size(214, 57);
            this.buttonTallenna.TabIndex = 1;
            this.buttonTallenna.Text = "Tallenna";
            this.buttonTallenna.UseVisualStyleBackColor = false;
            this.buttonTallenna.Click += new System.EventHandler(this.buttonTallenna_Click);
            // 
            // buttonUusiTietue
            // 
            this.buttonUusiTietue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUusiTietue.Location = new System.Drawing.Point(17, 39);
            this.buttonUusiTietue.Name = "buttonUusiTietue";
            this.buttonUusiTietue.Size = new System.Drawing.Size(214, 57);
            this.buttonUusiTietue.TabIndex = 0;
            this.buttonUusiTietue.Text = "Uusi tietue";
            this.buttonUusiTietue.UseVisualStyleBackColor = true;
            this.buttonUusiTietue.Click += new System.EventHandler(this.buttonUusiTietue_Click);
            // 
            // groupBoxTiedot
            // 
            this.groupBoxTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTiedot.Controls.Add(this.textBoxKesto);
            this.groupBoxTiedot.Controls.Add(this.textBoxVuosi);
            this.groupBoxTiedot.Controls.Add(this.textBoxNimi);
            this.groupBoxTiedot.Controls.Add(this.textBoxID);
            this.groupBoxTiedot.Controls.Add(this.label6);
            this.groupBoxTiedot.Controls.Add(this.label5);
            this.groupBoxTiedot.Controls.Add(this.label4);
            this.groupBoxTiedot.Controls.Add(this.label3);
            this.groupBoxTiedot.Controls.Add(this.buttonSeuraava);
            this.groupBoxTiedot.Controls.Add(this.buttonEdellinen);
            this.groupBoxTiedot.Location = new System.Drawing.Point(12, 44);
            this.groupBoxTiedot.Name = "groupBoxTiedot";
            this.groupBoxTiedot.Size = new System.Drawing.Size(356, 311);
            this.groupBoxTiedot.TabIndex = 3;
            this.groupBoxTiedot.TabStop = false;
            this.groupBoxTiedot.Text = "Elokuvan tiedot";
            // 
            // textBoxKesto
            // 
            this.textBoxKesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKesto.Location = new System.Drawing.Point(131, 181);
            this.textBoxKesto.Name = "textBoxKesto";
            this.textBoxKesto.Size = new System.Drawing.Size(114, 23);
            this.textBoxKesto.TabIndex = 10;
            // 
            // textBoxVuosi
            // 
            this.textBoxVuosi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVuosi.Location = new System.Drawing.Point(131, 130);
            this.textBoxVuosi.Name = "textBoxVuosi";
            this.textBoxVuosi.Size = new System.Drawing.Size(114, 23);
            this.textBoxVuosi.TabIndex = 9;
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNimi.Location = new System.Drawing.Point(131, 81);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(202, 23);
            this.textBoxNimi.TabIndex = 8;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Location = new System.Drawing.Point(131, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(114, 23);
            this.textBoxID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kesto (min):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Julkaisuvuosi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nimi:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // buttonSeuraava
            // 
            this.buttonSeuraava.Location = new System.Drawing.Point(190, 241);
            this.buttonSeuraava.Name = "buttonSeuraava";
            this.buttonSeuraava.Size = new System.Drawing.Size(143, 53);
            this.buttonSeuraava.TabIndex = 2;
            this.buttonSeuraava.Text = "Seuraava";
            this.buttonSeuraava.UseVisualStyleBackColor = true;
            // 
            // buttonEdellinen
            // 
            this.buttonEdellinen.Location = new System.Drawing.Point(19, 241);
            this.buttonEdellinen.Name = "buttonEdellinen";
            this.buttonEdellinen.Size = new System.Drawing.Size(143, 53);
            this.buttonEdellinen.TabIndex = 1;
            this.buttonEdellinen.Text = "Edellinen";
            this.buttonEdellinen.UseVisualStyleBackColor = true;
            // 
            // groupBoxArvio
            // 
            this.groupBoxArvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArvio.Controls.Add(this.label2);
            this.groupBoxArvio.Controls.Add(this.numericUpDown2);
            this.groupBoxArvio.Controls.Add(this.label1);
            this.groupBoxArvio.Controls.Add(this.numericUpDown1);
            this.groupBoxArvio.Controls.Add(this.textBoxArvio);
            this.groupBoxArvio.Location = new System.Drawing.Point(12, 361);
            this.groupBoxArvio.Name = "groupBoxArvio";
            this.groupBoxArvio.Size = new System.Drawing.Size(356, 160);
            this.groupBoxArvio.TabIndex = 4;
            this.groupBoxArvio.TabStop = false;
            this.groupBoxArvio.Text = "Arvio";
            this.groupBoxArvio.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = ".";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Location = new System.Drawing.Point(161, 122);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arvosana:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(86, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // textBoxArvio
            // 
            this.textBoxArvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArvio.Location = new System.Drawing.Point(19, 30);
            this.textBoxArvio.Multiline = true;
            this.textBoxArvio.Name = "textBoxArvio";
            this.textBoxArvio.Size = new System.Drawing.Size(314, 76);
            this.textBoxArvio.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 534);
            this.Controls.Add(this.groupBoxArvio);
            this.Controls.Add(this.groupBoxTiedot);
            this.Controls.Add(this.groupBoxToiminnallisuus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elokuvasovellus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxToiminnallisuus.ResumeLayout(false);
            this.groupBoxTiedot.ResumeLayout(false);
            this.groupBoxTiedot.PerformLayout();
            this.groupBoxArvio.ResumeLayout(false);
            this.groupBoxArvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hjhjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxToiminnallisuus;
        private System.Windows.Forms.Button buttonPoista;
        private System.Windows.Forms.Button buttonTallenna;
        private System.Windows.Forms.Button buttonUusiTietue;
        private System.Windows.Forms.GroupBox groupBoxTiedot;
        private System.Windows.Forms.Button buttonSeuraava;
        private System.Windows.Forms.Button buttonEdellinen;
        private System.Windows.Forms.GroupBox groupBoxArvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxArvio;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKesto;
        private System.Windows.Forms.TextBox textBoxVuosi;
        private System.Windows.Forms.TextBox textBoxNimi;
    }
}

