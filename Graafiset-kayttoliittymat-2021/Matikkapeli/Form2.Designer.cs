
namespace _15_Matikkapeli
{
    partial class Form2
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
            this.yhteenButton = new System.Windows.Forms.Button();
            this.vahennysButton = new System.Windows.Forms.Button();
            this.kertoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nimiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yhteenButton
            // 
            this.yhteenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.yhteenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yhteenButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yhteenButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yhteenButton.Location = new System.Drawing.Point(44, 236);
            this.yhteenButton.Name = "yhteenButton";
            this.yhteenButton.Size = new System.Drawing.Size(197, 28);
            this.yhteenButton.TabIndex = 0;
            this.yhteenButton.Text = "Yhteenlaskuja";
            this.yhteenButton.UseVisualStyleBackColor = false;
            this.yhteenButton.Click += new System.EventHandler(this.yhteenButton_Click);
            // 
            // vahennysButton
            // 
            this.vahennysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.vahennysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vahennysButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vahennysButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vahennysButton.Location = new System.Drawing.Point(44, 270);
            this.vahennysButton.Name = "vahennysButton";
            this.vahennysButton.Size = new System.Drawing.Size(197, 28);
            this.vahennysButton.TabIndex = 1;
            this.vahennysButton.Text = "Vähennyslaskuja";
            this.vahennysButton.UseVisualStyleBackColor = false;
            this.vahennysButton.Click += new System.EventHandler(this.vahennysButton_Click);
            // 
            // kertoButton
            // 
            this.kertoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.kertoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kertoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kertoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kertoButton.Location = new System.Drawing.Point(44, 338);
            this.kertoButton.Name = "kertoButton";
            this.kertoButton.Size = new System.Drawing.Size(197, 28);
            this.kertoButton.TabIndex = 2;
            this.kertoButton.Text = "Kertolaskuja";
            this.kertoButton.UseVisualStyleBackColor = false;
            this.kertoButton.Click += new System.EventHandler(this.kertoButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(44, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Jakolaskuja";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(11)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(44, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Päävalikko";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_15_Matikkapeli.Properties.Resources.flying;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(44, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 156);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nimiLabel
            // 
            this.nimiLabel.AutoSize = true;
            this.nimiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nimiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(48)))), ((int)(((byte)(92)))));
            this.nimiLabel.Location = new System.Drawing.Point(60, 188);
            this.nimiLabel.Name = "nimiLabel";
            this.nimiLabel.Size = new System.Drawing.Size(167, 30);
            this.nimiLabel.TabIndex = 10;
            this.nimiLabel.Text = "HARJOITUKSET";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.nimiLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kertoButton);
            this.Controls.Add(this.vahennysButton);
            this.Controls.Add(this.yhteenButton);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yhteenButton;
        private System.Windows.Forms.Button vahennysButton;
        private System.Windows.Forms.Button kertoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nimiLabel;
    }
}