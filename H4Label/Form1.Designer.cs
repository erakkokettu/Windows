namespace H4Label
{
    partial class H4Label
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
            this.kirjautumisLipuke = new System.Windows.Forms.Label();
            this.tunnusLipuke = new System.Windows.Forms.Label();
            this.salasanaLipuke = new System.Windows.Forms.Label();
            this.palauteLipuke = new System.Windows.Forms.Label();
            this.tunnusTekstikentta = new System.Windows.Forms.TextBox();
            this.salasanaTekstikentta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kirjautumisLipuke
            // 
            this.kirjautumisLipuke.AutoSize = true;
            this.kirjautumisLipuke.BackColor = System.Drawing.SystemColors.Control;
            this.kirjautumisLipuke.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjautumisLipuke.Location = new System.Drawing.Point(270, 85);
            this.kirjautumisLipuke.Name = "kirjautumisLipuke";
            this.kirjautumisLipuke.Size = new System.Drawing.Size(156, 25);
            this.kirjautumisLipuke.TabIndex = 0;
            this.kirjautumisLipuke.Text = "Kirjautumislomake";
            // 
            // tunnusLipuke
            // 
            this.tunnusLipuke.AutoSize = true;
            this.tunnusLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunnusLipuke.Location = new System.Drawing.Point(172, 149);
            this.tunnusLipuke.Name = "tunnusLipuke";
            this.tunnusLipuke.Size = new System.Drawing.Size(52, 20);
            this.tunnusLipuke.TabIndex = 1;
            this.tunnusLipuke.Text = "Tunnus";
            this.tunnusLipuke.MouseLeave += new System.EventHandler(this.tunnusLipuke_MouseLeave);
            this.tunnusLipuke.MouseHover += new System.EventHandler(this.tunnusLipuke_MouseHover);
            // 
            // salasanaLipuke
            // 
            this.salasanaLipuke.AutoSize = true;
            this.salasanaLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLipuke.Location = new System.Drawing.Point(172, 195);
            this.salasanaLipuke.Name = "salasanaLipuke";
            this.salasanaLipuke.Size = new System.Drawing.Size(61, 20);
            this.salasanaLipuke.TabIndex = 3;
            this.salasanaLipuke.Text = "Salasana";
            this.salasanaLipuke.MouseLeave += new System.EventHandler(this.salasanaLipuke_MouseLeave);
            this.salasanaLipuke.MouseHover += new System.EventHandler(this.salasanaLipuke_MouseHover);
            // 
            // palauteLipuke
            // 
            this.palauteLipuke.AutoSize = true;
            this.palauteLipuke.Location = new System.Drawing.Point(372, 325);
            this.palauteLipuke.Name = "palauteLipuke";
            this.palauteLipuke.Size = new System.Drawing.Size(0, 13);
            this.palauteLipuke.TabIndex = 6;
            this.palauteLipuke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.palauteLipuke.MouseDown += new System.Windows.Forms.MouseEventHandler(this.palauteLipuke_MouseDown);
            this.palauteLipuke.MouseHover += new System.EventHandler(this.palauteLipuke_MouseHover);
            // 
            // tunnusTekstikentta
            // 
            this.tunnusTekstikentta.Location = new System.Drawing.Point(273, 146);
            this.tunnusTekstikentta.Name = "tunnusTekstikentta";
            this.tunnusTekstikentta.Size = new System.Drawing.Size(173, 20);
            this.tunnusTekstikentta.TabIndex = 2;
            // 
            // salasanaTekstikentta
            // 
            this.salasanaTekstikentta.Location = new System.Drawing.Point(273, 192);
            this.salasanaTekstikentta.Name = "salasanaTekstikentta";
            this.salasanaTekstikentta.PasswordChar = '*';
            this.salasanaTekstikentta.Size = new System.Drawing.Size(173, 20);
            this.salasanaTekstikentta.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kirjaudu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // H4Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salasanaTekstikentta);
            this.Controls.Add(this.tunnusTekstikentta);
            this.Controls.Add(this.palauteLipuke);
            this.Controls.Add(this.salasanaLipuke);
            this.Controls.Add(this.tunnusLipuke);
            this.Controls.Add(this.kirjautumisLipuke);
            this.Name = "H4Label";
            this.Text = "H4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kirjautumisLipuke;
        private System.Windows.Forms.Label tunnusLipuke;
        private System.Windows.Forms.Label salasanaLipuke;
        private System.Windows.Forms.Label palauteLipuke;
        private System.Windows.Forms.TextBox tunnusTekstikentta;
        private System.Windows.Forms.TextBox salasanaTekstikentta;
        private System.Windows.Forms.Button button1;
    }
}

