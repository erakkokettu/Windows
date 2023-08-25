namespace H6RichTextbox
{
    partial class H6RichTextbox
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
            this.richTiedostoTekstikentta = new System.Windows.Forms.RichTextBox();
            this.tiedostoTekstikentta = new System.Windows.Forms.TextBox();
            this.nimiTekstikentta = new System.Windows.Forms.TextBox();
            this.latausPainike = new System.Windows.Forms.Button();
            this.tallennusPainike = new System.Windows.Forms.Button();
            this.putsausPainike = new System.Windows.Forms.Button();
            this.lopetusPainike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTiedostoTekstikentta
            // 
            this.richTiedostoTekstikentta.AcceptsTab = true;
            this.richTiedostoTekstikentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTiedostoTekstikentta.Location = new System.Drawing.Point(66, 52);
            this.richTiedostoTekstikentta.Name = "richTiedostoTekstikentta";
            this.richTiedostoTekstikentta.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTiedostoTekstikentta.Size = new System.Drawing.Size(285, 159);
            this.richTiedostoTekstikentta.TabIndex = 0;
            this.richTiedostoTekstikentta.Text = "";
            this.richTiedostoTekstikentta.ZoomFactor = 2F;
            this.richTiedostoTekstikentta.VScroll += new System.EventHandler(this.richTiedostoTekstikentta_VScroll);
            // 
            // tiedostoTekstikentta
            // 
            this.tiedostoTekstikentta.AcceptsReturn = true;
            this.tiedostoTekstikentta.AcceptsTab = true;
            this.tiedostoTekstikentta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiedostoTekstikentta.Location = new System.Drawing.Point(402, 52);
            this.tiedostoTekstikentta.Multiline = true;
            this.tiedostoTekstikentta.Name = "tiedostoTekstikentta";
            this.tiedostoTekstikentta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tiedostoTekstikentta.Size = new System.Drawing.Size(273, 159);
            this.tiedostoTekstikentta.TabIndex = 1;
            // 
            // nimiTekstikentta
            // 
            this.nimiTekstikentta.Location = new System.Drawing.Point(310, 241);
            this.nimiTekstikentta.Name = "nimiTekstikentta";
            this.nimiTekstikentta.Size = new System.Drawing.Size(134, 20);
            this.nimiTekstikentta.TabIndex = 2;
            this.nimiTekstikentta.Text = "C:\\temp\\arkisto\\muistio.rtf";
            // 
            // latausPainike
            // 
            this.latausPainike.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.latausPainike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.latausPainike.Location = new System.Drawing.Point(199, 296);
            this.latausPainike.Name = "latausPainike";
            this.latausPainike.Size = new System.Drawing.Size(120, 23);
            this.latausPainike.TabIndex = 3;
            this.latausPainike.Text = "Lataa tiedosto";
            this.latausPainike.UseVisualStyleBackColor = false;
            this.latausPainike.Click += new System.EventHandler(this.latausPainike_Click);
            // 
            // tallennusPainike
            // 
            this.tallennusPainike.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tallennusPainike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tallennusPainike.Location = new System.Drawing.Point(325, 296);
            this.tallennusPainike.Name = "tallennusPainike";
            this.tallennusPainike.Size = new System.Drawing.Size(113, 23);
            this.tallennusPainike.TabIndex = 4;
            this.tallennusPainike.Text = "Tallenna tiedosto";
            this.tallennusPainike.UseVisualStyleBackColor = false;
            this.tallennusPainike.Click += new System.EventHandler(this.tallennusPainike_Click);
            // 
            // putsausPainike
            // 
            this.putsausPainike.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.putsausPainike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.putsausPainike.Location = new System.Drawing.Point(444, 296);
            this.putsausPainike.Name = "putsausPainike";
            this.putsausPainike.Size = new System.Drawing.Size(128, 23);
            this.putsausPainike.TabIndex = 5;
            this.putsausPainike.Text = "Puhdista kentät";
            this.putsausPainike.UseVisualStyleBackColor = false;
            this.putsausPainike.Click += new System.EventHandler(this.putsausPainike_Click);
            // 
            // lopetusPainike
            // 
            this.lopetusPainike.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lopetusPainike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lopetusPainike.Location = new System.Drawing.Point(310, 347);
            this.lopetusPainike.Name = "lopetusPainike";
            this.lopetusPainike.Size = new System.Drawing.Size(134, 23);
            this.lopetusPainike.TabIndex = 6;
            this.lopetusPainike.Text = "Sulje sovellus";
            this.lopetusPainike.UseVisualStyleBackColor = false;
            this.lopetusPainike.Click += new System.EventHandler(this.lopetusPainike_Click);
            // 
            // H6RichTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lopetusPainike);
            this.Controls.Add(this.putsausPainike);
            this.Controls.Add(this.tallennusPainike);
            this.Controls.Add(this.latausPainike);
            this.Controls.Add(this.nimiTekstikentta);
            this.Controls.Add(this.tiedostoTekstikentta);
            this.Controls.Add(this.richTiedostoTekstikentta);
            this.Name = "H6RichTextbox";
            this.Text = "H6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTiedostoTekstikentta;
        private System.Windows.Forms.TextBox tiedostoTekstikentta;
        private System.Windows.Forms.TextBox nimiTekstikentta;
        private System.Windows.Forms.Button latausPainike;
        private System.Windows.Forms.Button tallennusPainike;
        private System.Windows.Forms.Button putsausPainike;
        private System.Windows.Forms.Button lopetusPainike;
    }
}

