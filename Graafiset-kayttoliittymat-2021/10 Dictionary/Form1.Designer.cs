
namespace _10_Dictionary
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avain = new System.Windows.Forms.TextBox();
            this.arvo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lisaaElementti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.haeElementti = new System.Windows.Forms.Button();
            this.avainHaku = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.arvonPalautus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUODAAN Dictionary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Luo Dictionary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "LISÄTÄÄN Elementtejä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key:";
            // 
            // avain
            // 
            this.avain.Location = new System.Drawing.Point(68, 132);
            this.avain.Name = "avain";
            this.avain.Size = new System.Drawing.Size(132, 23);
            this.avain.TabIndex = 5;
            // 
            // arvo
            // 
            this.arvo.Location = new System.Drawing.Point(68, 170);
            this.arvo.Name = "arvo";
            this.arvo.Size = new System.Drawing.Size(132, 23);
            this.arvo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value:";
            // 
            // lisaaElementti
            // 
            this.lisaaElementti.Enabled = false;
            this.lisaaElementti.Location = new System.Drawing.Point(206, 169);
            this.lisaaElementti.Name = "lisaaElementti";
            this.lisaaElementti.Size = new System.Drawing.Size(66, 23);
            this.lisaaElementti.TabIndex = 8;
            this.lisaaElementti.Text = "Lisää";
            this.lisaaElementti.UseVisualStyleBackColor = true;
            this.lisaaElementti.Click += new System.EventHandler(this.lisaaElementti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "HAETAAN Elementtejä";
            // 
            // haeElementti
            // 
            this.haeElementti.Enabled = false;
            this.haeElementti.Location = new System.Drawing.Point(206, 244);
            this.haeElementti.Name = "haeElementti";
            this.haeElementti.Size = new System.Drawing.Size(66, 23);
            this.haeElementti.TabIndex = 12;
            this.haeElementti.Text = "Haku";
            this.haeElementti.UseVisualStyleBackColor = true;
            this.haeElementti.Click += new System.EventHandler(this.haeElementti_Click);
            // 
            // avainHaku
            // 
            this.avainHaku.Location = new System.Drawing.Point(68, 245);
            this.avainHaku.Name = "avainHaku";
            this.avainHaku.Size = new System.Drawing.Size(132, 23);
            this.avainHaku.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Value:";
            // 
            // arvonPalautus
            // 
            this.arvonPalautus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.arvonPalautus.Location = new System.Drawing.Point(68, 282);
            this.arvonPalautus.Name = "arvonPalautus";
            this.arvonPalautus.ReadOnly = true;
            this.arvonPalautus.Size = new System.Drawing.Size(57, 23);
            this.arvonPalautus.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 332);
            this.Controls.Add(this.arvonPalautus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.haeElementti);
            this.Controls.Add(this.avainHaku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lisaaElementti);
            this.Controls.Add(this.arvo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avain;
        private System.Windows.Forms.TextBox arvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lisaaElementti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button haeElementti;
        private System.Windows.Forms.TextBox avainHaku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox arvonPalautus;
    }
}

