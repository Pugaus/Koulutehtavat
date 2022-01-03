
namespace _07_Array
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.taulukonKoko = new System.Windows.Forms.TextBox();
            this.LuoTaulukko = new System.Windows.Forms.Button();
            this.TalletettavaNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Talleta = new System.Windows.Forms.Button();
            this.TalletettavaIndeksi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.Hae = new System.Windows.Forms.Button();
            this.TalletuspaikanIndeksi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tulos = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(80, 47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 19);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TAULUKON LUONTI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taulukon koko:";
            // 
            // taulukonKoko
            // 
            this.taulukonKoko.Location = new System.Drawing.Point(105, 79);
            this.taulukonKoko.Name = "taulukonKoko";
            this.taulukonKoko.Size = new System.Drawing.Size(56, 23);
            this.taulukonKoko.TabIndex = 3;
            this.taulukonKoko.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LuoTaulukko
            // 
            this.LuoTaulukko.Location = new System.Drawing.Point(185, 78);
            this.LuoTaulukko.Name = "LuoTaulukko";
            this.LuoTaulukko.Size = new System.Drawing.Size(91, 23);
            this.LuoTaulukko.TabIndex = 4;
            this.LuoTaulukko.Text = "Luo taulukko";
            this.LuoTaulukko.UseVisualStyleBackColor = true;
            this.LuoTaulukko.Click += new System.EventHandler(this.button1_Click);
            // 
            // TalletettavaNumero
            // 
            this.TalletettavaNumero.Location = new System.Drawing.Point(142, 161);
            this.TalletettavaNumero.Name = "TalletettavaNumero";
            this.TalletettavaNumero.Size = new System.Drawing.Size(56, 23);
            this.TalletettavaNumero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Talletettava numero:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.Location = new System.Drawing.Point(105, 127);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(82, 19);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "TALLENNUS";
            // 
            // Talleta
            // 
            this.Talleta.Location = new System.Drawing.Point(215, 203);
            this.Talleta.Name = "Talleta";
            this.Talleta.Size = new System.Drawing.Size(61, 23);
            this.Talleta.TabIndex = 11;
            this.Talleta.Text = "Talleta";
            this.Talleta.UseVisualStyleBackColor = true;
            this.Talleta.Click += new System.EventHandler(this.Talleta_Click);
            // 
            // TalletettavaIndeksi
            // 
            this.TalletettavaIndeksi.Location = new System.Drawing.Point(142, 203);
            this.TalletettavaIndeksi.Name = "TalletettavaIndeksi";
            this.TalletettavaIndeksi.Size = new System.Drawing.Size(56, 23);
            this.TalletettavaIndeksi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Talletettava indeksi:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel3.Location = new System.Drawing.Point(123, 259);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(46, 19);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "HAKU";
            // 
            // Hae
            // 
            this.Hae.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hae.Location = new System.Drawing.Point(215, 292);
            this.Hae.Name = "Hae";
            this.Hae.Size = new System.Drawing.Size(61, 23);
            this.Hae.TabIndex = 15;
            this.Hae.Text = "Hae";
            this.Hae.UseVisualStyleBackColor = false;
            this.Hae.Click += new System.EventHandler(this.Hae_Click);
            // 
            // TalletuspaikanIndeksi
            // 
            this.TalletuspaikanIndeksi.Location = new System.Drawing.Point(142, 293);
            this.TalletuspaikanIndeksi.Name = "TalletuspaikanIndeksi";
            this.TalletuspaikanIndeksi.Size = new System.Drawing.Size(56, 23);
            this.TalletuspaikanIndeksi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Talletuspaikan indeksi:";
            // 
            // Tulos
            // 
            this.Tulos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Tulos.Location = new System.Drawing.Point(142, 335);
            this.Tulos.Multiline = true;
            this.Tulos.Name = "Tulos";
            this.Tulos.Size = new System.Drawing.Size(45, 23);
            this.Tulos.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 382);
            this.Controls.Add(this.Tulos);
            this.Controls.Add(this.Hae);
            this.Controls.Add(this.TalletuspaikanIndeksi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.Talleta);
            this.Controls.Add(this.TalletettavaIndeksi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.TalletettavaNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LuoTaulukko);
            this.Controls.Add(this.taulukonKoko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pääformi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taulukonKoko;
        private System.Windows.Forms.Button LuoTaulukko;
        private System.Windows.Forms.TextBox TalletettavaNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button Talleta;
        private System.Windows.Forms.TextBox TalletettavaIndeksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button Hae;
        private System.Windows.Forms.TextBox TalletuspaikanIndeksi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tulos;
    }
}

