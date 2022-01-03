
namespace _15_Matikkapeli
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
            this.pelaaButton = new System.Windows.Forms.Button();
            this.PoistuButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.nimiLabel = new System.Windows.Forms.Label();
            this.saavutuksetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pelaaButton
            // 
            this.pelaaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.pelaaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pelaaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pelaaButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pelaaButton.Location = new System.Drawing.Point(40, 302);
            this.pelaaButton.Name = "pelaaButton";
            this.pelaaButton.Size = new System.Drawing.Size(197, 28);
            this.pelaaButton.TabIndex = 0;
            this.pelaaButton.Text = "Pelaa";
            this.pelaaButton.UseVisualStyleBackColor = false;
            this.pelaaButton.Click += new System.EventHandler(this.pelaaButton_Click);
            // 
            // PoistuButton
            // 
            this.PoistuButton.BackColor = System.Drawing.Color.Salmon;
            this.PoistuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoistuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PoistuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PoistuButton.Location = new System.Drawing.Point(40, 370);
            this.PoistuButton.Name = "PoistuButton";
            this.PoistuButton.Size = new System.Drawing.Size(197, 28);
            this.PoistuButton.TabIndex = 6;
            this.PoistuButton.Text = "Poistu";
            this.PoistuButton.UseVisualStyleBackColor = false;
            this.PoistuButton.Click += new System.EventHandler(this.PoistuButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = global::_15_Matikkapeli.Properties.Resources.space_ship;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPictureBox.Location = new System.Drawing.Point(40, 102);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(198, 143);
            this.logoPictureBox.TabIndex = 8;
            this.logoPictureBox.TabStop = false;
            // 
            // nimiLabel
            // 
            this.nimiLabel.AutoSize = true;
            this.nimiLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nimiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(174)))), ((int)(((byte)(152)))));
            this.nimiLabel.Location = new System.Drawing.Point(66, 238);
            this.nimiLabel.Name = "nimiLabel";
            this.nimiLabel.Size = new System.Drawing.Size(144, 30);
            this.nimiLabel.TabIndex = 9;
            this.nimiLabel.Text = "SPACE MATH";
            // 
            // saavutuksetButton
            // 
            this.saavutuksetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(118)))));
            this.saavutuksetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saavutuksetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saavutuksetButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saavutuksetButton.Location = new System.Drawing.Point(40, 336);
            this.saavutuksetButton.Name = "saavutuksetButton";
            this.saavutuksetButton.Size = new System.Drawing.Size(197, 28);
            this.saavutuksetButton.TabIndex = 10;
            this.saavutuksetButton.Text = "Ennätykset";
            this.saavutuksetButton.UseVisualStyleBackColor = false;
            this.saavutuksetButton.Click += new System.EventHandler(this.saavutuksetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.saavutuksetButton);
            this.Controls.Add(this.nimiLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.PoistuButton);
            this.Controls.Add(this.pelaaButton);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pelaaButton;
        private System.Windows.Forms.Button PoistuButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label nimiLabel;
        private System.Windows.Forms.Button saavutuksetButton;
    }
}

