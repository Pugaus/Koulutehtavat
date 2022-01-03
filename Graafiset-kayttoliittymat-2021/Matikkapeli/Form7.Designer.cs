
namespace _15_Matikkapeli
{
    partial class Form7
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
            this.nimiLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.yhteenButton = new System.Windows.Forms.Button();
            this.vahennysButton = new System.Windows.Forms.Button();
            this.jakoButton = new System.Windows.Forms.Button();
            this.kertoButton = new System.Windows.Forms.Button();
            this.poistuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nimiLabel
            // 
            this.nimiLabel.AutoSize = true;
            this.nimiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nimiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(11)))));
            this.nimiLabel.Location = new System.Drawing.Point(67, 190);
            this.nimiLabel.Name = "nimiLabel";
            this.nimiLabel.Size = new System.Drawing.Size(146, 30);
            this.nimiLabel.TabIndex = 11;
            this.nimiLabel.Text = "ENNÄTYKSET";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = global::_15_Matikkapeli.Properties.Resources.science_fiction;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPictureBox.Location = new System.Drawing.Point(41, 54);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(198, 143);
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            // 
            // yhteenButton
            // 
            this.yhteenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(46)))), ((int)(((byte)(113)))));
            this.yhteenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yhteenButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yhteenButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yhteenButton.Location = new System.Drawing.Point(42, 240);
            this.yhteenButton.Name = "yhteenButton";
            this.yhteenButton.Size = new System.Drawing.Size(197, 29);
            this.yhteenButton.TabIndex = 12;
            this.yhteenButton.Text = "Yhteenlaskut";
            this.yhteenButton.UseVisualStyleBackColor = false;
            this.yhteenButton.Click += new System.EventHandler(this.pelaaButton_Click);
            // 
            // vahennysButton
            // 
            this.vahennysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(46)))), ((int)(((byte)(113)))));
            this.vahennysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vahennysButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vahennysButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vahennysButton.Location = new System.Drawing.Point(41, 275);
            this.vahennysButton.Name = "vahennysButton";
            this.vahennysButton.Size = new System.Drawing.Size(197, 28);
            this.vahennysButton.TabIndex = 13;
            this.vahennysButton.Text = "Vähennyslaskut";
            this.vahennysButton.UseVisualStyleBackColor = false;
            this.vahennysButton.Click += new System.EventHandler(this.vahennysButton_Click);
            // 
            // jakoButton
            // 
            this.jakoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(46)))), ((int)(((byte)(113)))));
            this.jakoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jakoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jakoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.jakoButton.Location = new System.Drawing.Point(42, 309);
            this.jakoButton.Name = "jakoButton";
            this.jakoButton.Size = new System.Drawing.Size(197, 28);
            this.jakoButton.TabIndex = 14;
            this.jakoButton.Text = "Jakolaskut";
            this.jakoButton.UseVisualStyleBackColor = false;
            this.jakoButton.Click += new System.EventHandler(this.jakoButton_Click);
            // 
            // kertoButton
            // 
            this.kertoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(46)))), ((int)(((byte)(113)))));
            this.kertoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kertoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kertoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kertoButton.Location = new System.Drawing.Point(42, 343);
            this.kertoButton.Name = "kertoButton";
            this.kertoButton.Size = new System.Drawing.Size(197, 28);
            this.kertoButton.TabIndex = 15;
            this.kertoButton.Text = "Kertolaskut";
            this.kertoButton.UseVisualStyleBackColor = false;
            this.kertoButton.Click += new System.EventHandler(this.kertoButton_Click);
            // 
            // poistuButton
            // 
            this.poistuButton.BackColor = System.Drawing.Color.Salmon;
            this.poistuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poistuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poistuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poistuButton.Location = new System.Drawing.Point(41, 377);
            this.poistuButton.Name = "poistuButton";
            this.poistuButton.Size = new System.Drawing.Size(197, 28);
            this.poistuButton.TabIndex = 16;
            this.poistuButton.Text = "Päävalikko";
            this.poistuButton.UseVisualStyleBackColor = false;
            this.poistuButton.Click += new System.EventHandler(this.poistuButton_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.poistuButton);
            this.Controls.Add(this.kertoButton);
            this.Controls.Add(this.jakoButton);
            this.Controls.Add(this.vahennysButton);
            this.Controls.Add(this.yhteenButton);
            this.Controls.Add(this.nimiLabel);
            this.Controls.Add(this.logoPictureBox);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nimiLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button yhteenButton;
        private System.Windows.Forms.Button vahennysButton;
        private System.Windows.Forms.Button jakoButton;
        private System.Windows.Forms.Button kertoButton;
        private System.Windows.Forms.Button poistuButton;
    }
}