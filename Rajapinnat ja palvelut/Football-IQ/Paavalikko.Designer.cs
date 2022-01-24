
namespace Football_IQ
{
    partial class Paavalikko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paavalikko));
            this.buttonVastaus = new System.Windows.Forms.Button();
            this.comboBoxVastaus = new System.Windows.Forms.ComboBox();
            this.buttonKysymys = new System.Windows.Forms.Button();
            this.labelKysymys = new System.Windows.Forms.Label();
            this.labelOikeaVastaus = new System.Windows.Forms.Label();
            this.labelOikeinTaiVaarin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPalkinnot = new System.Windows.Forms.PictureBox();
            this.labelPiste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalkinnot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVastaus
            // 
            this.buttonVastaus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVastaus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonVastaus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonVastaus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVastaus.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVastaus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(93)))), ((int)(((byte)(119)))));
            this.buttonVastaus.Location = new System.Drawing.Point(607, 453);
            this.buttonVastaus.Name = "buttonVastaus";
            this.buttonVastaus.Size = new System.Drawing.Size(75, 32);
            this.buttonVastaus.TabIndex = 0;
            this.buttonVastaus.Text = "Answer";
            this.buttonVastaus.UseVisualStyleBackColor = false;
            this.buttonVastaus.Click += new System.EventHandler(this.buttonVastaus_Click);
            // 
            // comboBoxVastaus
            // 
            this.comboBoxVastaus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxVastaus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxVastaus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVastaus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVastaus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxVastaus.FormattingEnabled = true;
            this.comboBoxVastaus.Items.AddRange(new object[] {
            "Punt",
            "Kick a field goal",
            "Run",
            "Pass",
            "Kneel down",
            "Dont know / it depends"});
            this.comboBoxVastaus.Location = new System.Drawing.Point(408, 454);
            this.comboBoxVastaus.Name = "comboBoxVastaus";
            this.comboBoxVastaus.Size = new System.Drawing.Size(193, 31);
            this.comboBoxVastaus.TabIndex = 1;
            this.comboBoxVastaus.SelectedIndexChanged += new System.EventHandler(this.comboBoxVastaus_SelectedIndexChanged);
            // 
            // buttonKysymys
            // 
            this.buttonKysymys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKysymys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(93)))), ((int)(((byte)(119)))));
            this.buttonKysymys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKysymys.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKysymys.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKysymys.Location = new System.Drawing.Point(276, 453);
            this.buttonKysymys.Name = "buttonKysymys";
            this.buttonKysymys.Size = new System.Drawing.Size(126, 32);
            this.buttonKysymys.TabIndex = 2;
            this.buttonKysymys.Text = "New question";
            this.buttonKysymys.UseVisualStyleBackColor = false;
            this.buttonKysymys.Click += new System.EventHandler(this.buttonKysymys_Click);
            // 
            // labelKysymys
            // 
            this.labelKysymys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKysymys.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKysymys.Location = new System.Drawing.Point(12, 416);
            this.labelKysymys.Name = "labelKysymys";
            this.labelKysymys.Size = new System.Drawing.Size(933, 15);
            this.labelKysymys.TabIndex = 3;
            this.labelKysymys.Text = "label1";
            this.labelKysymys.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOikeaVastaus
            // 
            this.labelOikeaVastaus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOikeaVastaus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOikeaVastaus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOikeaVastaus.Location = new System.Drawing.Point(12, 519);
            this.labelOikeaVastaus.Name = "labelOikeaVastaus";
            this.labelOikeaVastaus.Size = new System.Drawing.Size(933, 29);
            this.labelOikeaVastaus.TabIndex = 4;
            this.labelOikeaVastaus.Text = "label1";
            this.labelOikeaVastaus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOikeinTaiVaarin
            // 
            this.labelOikeinTaiVaarin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOikeinTaiVaarin.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOikeinTaiVaarin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOikeinTaiVaarin.Location = new System.Drawing.Point(12, 497);
            this.labelOikeinTaiVaarin.Name = "labelOikeinTaiVaarin";
            this.labelOikeinTaiVaarin.Size = new System.Drawing.Size(933, 26);
            this.labelOikeinTaiVaarin.TabIndex = 5;
            this.labelOikeinTaiVaarin.Text = "label1";
            this.labelOikeinTaiVaarin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(93)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "FOOTBALL IQ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Offence Edition";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gameManualToolStripMenuItem
            // 
            this.gameManualToolStripMenuItem.Name = "gameManualToolStripMenuItem";
            this.gameManualToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.gameManualToolStripMenuItem.Text = "Game manual";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDataToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // openDataToolStripMenuItem
            // 
            this.openDataToolStripMenuItem.Name = "openDataToolStripMenuItem";
            this.openDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openDataToolStripMenuItem.Text = "Open data";
            this.openDataToolStripMenuItem.Click += new System.EventHandler(this.openDataToolStripMenuItem_Click);
            // 
            // pictureBoxPalkinnot
            // 
            this.pictureBoxPalkinnot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPalkinnot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPalkinnot.Image")));
            this.pictureBoxPalkinnot.Location = new System.Drawing.Point(897, 14);
            this.pictureBoxPalkinnot.Name = "pictureBoxPalkinnot";
            this.pictureBoxPalkinnot.Size = new System.Drawing.Size(45, 65);
            this.pictureBoxPalkinnot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPalkinnot.TabIndex = 10;
            this.pictureBoxPalkinnot.TabStop = false;
            this.pictureBoxPalkinnot.Click += new System.EventHandler(this.pictureBoxPalkinnot_Click);
            // 
            // labelPiste
            // 
            this.labelPiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPiste.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPiste.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelPiste.Location = new System.Drawing.Point(536, 500);
            this.labelPiste.Name = "labelPiste";
            this.labelPiste.Size = new System.Drawing.Size(430, 20);
            this.labelPiste.TabIndex = 11;
            this.labelPiste.Text = "+1";
            this.labelPiste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPiste.Visible = false;
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 626);
            this.Controls.Add(this.labelPiste);
            this.Controls.Add(this.pictureBoxPalkinnot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelOikeinTaiVaarin);
            this.Controls.Add(this.labelOikeaVastaus);
            this.Controls.Add(this.labelKysymys);
            this.Controls.Add(this.buttonKysymys);
            this.Controls.Add(this.comboBoxVastaus);
            this.Controls.Add(this.buttonVastaus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paavalikko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football IQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalkinnot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVastaus;
        private System.Windows.Forms.ComboBox comboBoxVastaus;
        private System.Windows.Forms.Button buttonKysymys;
        private System.Windows.Forms.Label labelKysymys;
        private System.Windows.Forms.Label labelOikeaVastaus;
        private System.Windows.Forms.Label labelOikeinTaiVaarin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPalkinnot;
        private System.Windows.Forms.Label labelPiste;
    }
}

