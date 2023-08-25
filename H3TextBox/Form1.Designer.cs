namespace H3TextBox
{
    partial class H3TextBox
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
            this.LauseTekstikentta = new System.Windows.Forms.TextBox();
            this.arkistoTekstikentta = new System.Windows.Forms.TextBox();
            this.kopiointiPainike = new System.Windows.Forms.Button();
            this.salausPainike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LauseTekstikentta
            // 
            this.LauseTekstikentta.Location = new System.Drawing.Point(137, 169);
            this.LauseTekstikentta.Name = "LauseTekstikentta";
            this.LauseTekstikentta.Size = new System.Drawing.Size(240, 20);
            this.LauseTekstikentta.TabIndex = 0;
            this.LauseTekstikentta.Text = "Kirjoita lause";
            this.LauseTekstikentta.TextChanged += new System.EventHandler(this.LauseTekstikentta_TextChanged);
            // 
            // arkistoTekstikentta
            // 
            this.arkistoTekstikentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arkistoTekstikentta.Location = new System.Drawing.Point(137, 213);
            this.arkistoTekstikentta.Multiline = true;
            this.arkistoTekstikentta.Name = "arkistoTekstikentta";
            this.arkistoTekstikentta.Size = new System.Drawing.Size(240, 127);
            this.arkistoTekstikentta.TabIndex = 1;
            this.arkistoTekstikentta.TextChanged += new System.EventHandler(this.arkistoTekstikentta_TextChanged);
            // 
            // kopiointiPainike
            // 
            this.kopiointiPainike.Location = new System.Drawing.Point(414, 167);
            this.kopiointiPainike.Name = "kopiointiPainike";
            this.kopiointiPainike.Size = new System.Drawing.Size(137, 37);
            this.kopiointiPainike.TabIndex = 2;
            this.kopiointiPainike.Text = "Kopioi teksti arkistoon";
            this.kopiointiPainike.UseVisualStyleBackColor = true;
            this.kopiointiPainike.Click += new System.EventHandler(this.kopiointiPainike_Click);
            // 
            // salausPainike
            // 
            this.salausPainike.Location = new System.Drawing.Point(414, 213);
            this.salausPainike.Name = "salausPainike";
            this.salausPainike.Size = new System.Drawing.Size(137, 34);
            this.salausPainike.TabIndex = 3;
            this.salausPainike.Text = "Salaa teksti";
            this.salausPainike.UseVisualStyleBackColor = true;
            this.salausPainike.Click += new System.EventHandler(this.salausPainike_Click);
            // 
            // H3TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salausPainike);
            this.Controls.Add(this.kopiointiPainike);
            this.Controls.Add(this.arkistoTekstikentta);
            this.Controls.Add(this.LauseTekstikentta);
            this.Name = "H3TextBox";
            this.Text = "H3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LauseTekstikentta;
        private System.Windows.Forms.TextBox arkistoTekstikentta;
        private System.Windows.Forms.Button kopiointiPainike;
        private System.Windows.Forms.Button salausPainike;
    }
}

