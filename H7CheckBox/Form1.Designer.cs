namespace H7CheckBox
{
    partial class H7
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
            this.variValintaRuutu = new System.Windows.Forms.CheckBox();
            this.kokoValintaruutu = new System.Windows.Forms.CheckBox();
            this.sijaintiValintaRuutu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // variValintaRuutu
            // 
            this.variValintaRuutu.AutoSize = true;
            this.variValintaRuutu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.variValintaRuutu.Location = new System.Drawing.Point(36, 61);
            this.variValintaRuutu.Name = "variValintaRuutu";
            this.variValintaRuutu.Size = new System.Drawing.Size(150, 17);
            this.variValintaRuutu.TabIndex = 0;
            this.variValintaRuutu.Text = "Muuta ikkunan taustaväriä";
            this.variValintaRuutu.UseVisualStyleBackColor = true;
            this.variValintaRuutu.CheckedChanged += new System.EventHandler(this.variValintaRuutu_CheckedChanged);
            // 
            // kokoValintaruutu
            // 
            this.kokoValintaruutu.AutoSize = true;
            this.kokoValintaruutu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kokoValintaruutu.Location = new System.Drawing.Point(36, 96);
            this.kokoValintaruutu.Name = "kokoValintaruutu";
            this.kokoValintaruutu.Size = new System.Drawing.Size(128, 17);
            this.kokoValintaruutu.TabIndex = 1;
            this.kokoValintaruutu.Text = "Muuta ikkunan kokoa";
            this.kokoValintaruutu.UseVisualStyleBackColor = true;
            this.kokoValintaruutu.CheckedChanged += new System.EventHandler(this.kokoValintaruutu_CheckedChanged);
            // 
            // sijaintiValintaRuutu
            // 
            this.sijaintiValintaRuutu.AutoSize = true;
            this.sijaintiValintaRuutu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sijaintiValintaRuutu.Location = new System.Drawing.Point(36, 130);
            this.sijaintiValintaRuutu.Name = "sijaintiValintaRuutu";
            this.sijaintiValintaRuutu.Size = new System.Drawing.Size(132, 17);
            this.sijaintiValintaRuutu.TabIndex = 2;
            this.sijaintiValintaRuutu.Text = "Muuta ikkunan sijaintia";
            this.sijaintiValintaRuutu.UseVisualStyleBackColor = true;
            this.sijaintiValintaRuutu.CheckedChanged += new System.EventHandler(this.sijaintiValintaRuutu_CheckedChanged);
            // 
            // H7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 246);
            this.Controls.Add(this.sijaintiValintaRuutu);
            this.Controls.Add(this.kokoValintaruutu);
            this.Controls.Add(this.variValintaRuutu);
            this.Name = "H7";
            this.Text = "H7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox variValintaRuutu;
        private System.Windows.Forms.CheckBox kokoValintaruutu;
        private System.Windows.Forms.CheckBox sijaintiValintaRuutu;
    }
}

