namespace H5MasketTextbox
{
    partial class H5MasketTextbox
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
            this.otsikkolipuke = new System.Windows.Forms.Label();
            this.nimiLipuke = new System.Windows.Forms.Label();
            this.tunnusLipuke = new System.Windows.Forms.Label();
            this.gsmLipuke = new System.Windows.Forms.Label();
            this.spostiLipuke = new System.Windows.Forms.Label();
            this.yhteenvetoLipuke = new System.Windows.Forms.Label();
            this.nimiMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tunnusMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gsmMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.spostiMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.yhteenvetoTextBox = new System.Windows.Forms.TextBox();
            this.rekisteriPainike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkolipuke
            // 
            this.otsikkolipuke.AutoSize = true;
            this.otsikkolipuke.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikkolipuke.Location = new System.Drawing.Point(162, 32);
            this.otsikkolipuke.Name = "otsikkolipuke";
            this.otsikkolipuke.Size = new System.Drawing.Size(125, 25);
            this.otsikkolipuke.TabIndex = 0;
            this.otsikkolipuke.Text = "Henkilötiedot";
            this.otsikkolipuke.Click += new System.EventHandler(this.label1_Click);
            // 
            // nimiLipuke
            // 
            this.nimiLipuke.AutoSize = true;
            this.nimiLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimiLipuke.Location = new System.Drawing.Point(30, 87);
            this.nimiLipuke.Name = "nimiLipuke";
            this.nimiLipuke.Size = new System.Drawing.Size(35, 20);
            this.nimiLipuke.TabIndex = 1;
            this.nimiLipuke.Text = "Nimi";
            // 
            // tunnusLipuke
            // 
            this.tunnusLipuke.AutoSize = true;
            this.tunnusLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunnusLipuke.Location = new System.Drawing.Point(30, 122);
            this.tunnusLipuke.Name = "tunnusLipuke";
            this.tunnusLipuke.Size = new System.Drawing.Size(88, 20);
            this.tunnusLipuke.TabIndex = 2;
            this.tunnusLipuke.Text = "Henkilötunnus";
            // 
            // gsmLipuke
            // 
            this.gsmLipuke.AutoSize = true;
            this.gsmLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsmLipuke.Location = new System.Drawing.Point(30, 156);
            this.gsmLipuke.Name = "gsmLipuke";
            this.gsmLipuke.Size = new System.Drawing.Size(84, 20);
            this.gsmLipuke.TabIndex = 3;
            this.gsmLipuke.Text = "Matkapuhelin";
            // 
            // spostiLipuke
            // 
            this.spostiLipuke.AutoSize = true;
            this.spostiLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spostiLipuke.Location = new System.Drawing.Point(30, 186);
            this.spostiLipuke.Name = "spostiLipuke";
            this.spostiLipuke.Size = new System.Drawing.Size(70, 20);
            this.spostiLipuke.TabIndex = 4;
            this.spostiLipuke.Text = "Sähköposti";
            // 
            // yhteenvetoLipuke
            // 
            this.yhteenvetoLipuke.AutoSize = true;
            this.yhteenvetoLipuke.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yhteenvetoLipuke.Location = new System.Drawing.Point(30, 229);
            this.yhteenvetoLipuke.Name = "yhteenvetoLipuke";
            this.yhteenvetoLipuke.Size = new System.Drawing.Size(69, 20);
            this.yhteenvetoLipuke.TabIndex = 5;
            this.yhteenvetoLipuke.Text = "Yhteenveto";
            // 
            // nimiMaskedTextBox
            // 
            this.nimiMaskedTextBox.HidePromptOnLeave = true;
            this.nimiMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.nimiMaskedTextBox.Location = new System.Drawing.Point(147, 87);
            this.nimiMaskedTextBox.Mask = ">L|LLLLLL>L|LLLLLLLLLLL";
            this.nimiMaskedTextBox.Name = "nimiMaskedTextBox";
            this.nimiMaskedTextBox.PromptChar = '-';
            this.nimiMaskedTextBox.ResetOnSpace = false;
            this.nimiMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.nimiMaskedTextBox.TabIndex = 0;
            // 
            // tunnusMaskedTextBox
            // 
            this.tunnusMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tunnusMaskedTextBox.Location = new System.Drawing.Point(147, 122);
            this.tunnusMaskedTextBox.Name = "tunnusMaskedTextBox";
            this.tunnusMaskedTextBox.PromptChar = '*';
            this.tunnusMaskedTextBox.ResetOnPrompt = false;
            this.tunnusMaskedTextBox.ResetOnSpace = false;
            this.tunnusMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.tunnusMaskedTextBox.TabIndex = 1;
            // 
            // gsmMaskedTextBox
            // 
            this.gsmMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.gsmMaskedTextBox.Location = new System.Drawing.Point(147, 156);
            this.gsmMaskedTextBox.Mask = "+000-00-0000000";
            this.gsmMaskedTextBox.Name = "gsmMaskedTextBox";
            this.gsmMaskedTextBox.PromptChar = '*';
            this.gsmMaskedTextBox.ResetOnPrompt = false;
            this.gsmMaskedTextBox.ResetOnSpace = false;
            this.gsmMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.gsmMaskedTextBox.TabIndex = 2;
            // 
            // spostiMaskedTextBox
            // 
            this.spostiMaskedTextBox.AsciiOnly = true;
            this.spostiMaskedTextBox.HidePromptOnLeave = true;
            this.spostiMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.spostiMaskedTextBox.Location = new System.Drawing.Point(147, 186);
            this.spostiMaskedTextBox.Mask = "CCCCCCCCCC@LLLLL ";
            this.spostiMaskedTextBox.Name = "spostiMaskedTextBox";
            this.spostiMaskedTextBox.PromptChar = '-';
            this.spostiMaskedTextBox.Size = new System.Drawing.Size(198, 20);
            this.spostiMaskedTextBox.TabIndex = 3;
            // 
            // yhteenvetoTextBox
            // 
            this.yhteenvetoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.yhteenvetoTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.yhteenvetoTextBox.Location = new System.Drawing.Point(147, 231);
            this.yhteenvetoTextBox.Multiline = true;
            this.yhteenvetoTextBox.Name = "yhteenvetoTextBox";
            this.yhteenvetoTextBox.ReadOnly = true;
            this.yhteenvetoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.yhteenvetoTextBox.Size = new System.Drawing.Size(198, 137);
            this.yhteenvetoTextBox.TabIndex = 4;
            // 
            // rekisteriPainike
            // 
            this.rekisteriPainike.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rekisteriPainike.Location = new System.Drawing.Point(187, 394);
            this.rekisteriPainike.Name = "rekisteriPainike";
            this.rekisteriPainike.Size = new System.Drawing.Size(75, 35);
            this.rekisteriPainike.TabIndex = 11;
            this.rekisteriPainike.Text = "Rekisteröi";
            this.rekisteriPainike.UseVisualStyleBackColor = true;
            this.rekisteriPainike.Click += new System.EventHandler(this.rekisteriPainike_Click);
            // 
            // H5MasketTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 441);
            this.Controls.Add(this.rekisteriPainike);
            this.Controls.Add(this.yhteenvetoTextBox);
            this.Controls.Add(this.spostiMaskedTextBox);
            this.Controls.Add(this.gsmMaskedTextBox);
            this.Controls.Add(this.tunnusMaskedTextBox);
            this.Controls.Add(this.nimiMaskedTextBox);
            this.Controls.Add(this.yhteenvetoLipuke);
            this.Controls.Add(this.spostiLipuke);
            this.Controls.Add(this.gsmLipuke);
            this.Controls.Add(this.tunnusLipuke);
            this.Controls.Add(this.nimiLipuke);
            this.Controls.Add(this.otsikkolipuke);
            this.Name = "H5MasketTextbox";
            this.Text = "H5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkolipuke;
        private System.Windows.Forms.Label nimiLipuke;
        private System.Windows.Forms.Label tunnusLipuke;
        private System.Windows.Forms.Label gsmLipuke;
        private System.Windows.Forms.Label spostiLipuke;
        private System.Windows.Forms.Label yhteenvetoLipuke;
        private System.Windows.Forms.MaskedTextBox nimiMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox tunnusMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox gsmMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox spostiMaskedTextBox;
        private System.Windows.Forms.TextBox yhteenvetoTextBox;
        private System.Windows.Forms.Button rekisteriPainike;
    }
}

