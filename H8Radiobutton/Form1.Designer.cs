namespace H8Radiobutton
{
    partial class H8Radiobutton
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
            this.taustaKuvaGroupBox = new System.Windows.Forms.GroupBox();
            this.kuvanSommitteluGroupBox = new System.Windows.Forms.GroupBox();
            this.kuva1Valintanappi = new System.Windows.Forms.RadioButton();
            this.kuva2Valintanappi = new System.Windows.Forms.RadioButton();
            this.kuva3Valintanappi = new System.Windows.Forms.RadioButton();
            this.centerValintanappi = new System.Windows.Forms.RadioButton();
            this.noneValintanappi = new System.Windows.Forms.RadioButton();
            this.stretchValintanappi = new System.Windows.Forms.RadioButton();
            this.tileValintanappi = new System.Windows.Forms.RadioButton();
            this.zoomValintanappi = new System.Windows.Forms.RadioButton();
            this.taustaKuvaGroupBox.SuspendLayout();
            this.kuvanSommitteluGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // taustaKuvaGroupBox
            // 
            this.taustaKuvaGroupBox.Controls.Add(this.kuva1Valintanappi);
            this.taustaKuvaGroupBox.Controls.Add(this.kuva2Valintanappi);
            this.taustaKuvaGroupBox.Controls.Add(this.kuva3Valintanappi);
            this.taustaKuvaGroupBox.Location = new System.Drawing.Point(64, 98);
            this.taustaKuvaGroupBox.Name = "taustaKuvaGroupBox";
            this.taustaKuvaGroupBox.Size = new System.Drawing.Size(253, 151);
            this.taustaKuvaGroupBox.TabIndex = 0;
            this.taustaKuvaGroupBox.TabStop = false;
            this.taustaKuvaGroupBox.Text = "Taustakuva";
            // 
            // kuvanSommitteluGroupBox
            // 
            this.kuvanSommitteluGroupBox.Controls.Add(this.zoomValintanappi);
            this.kuvanSommitteluGroupBox.Controls.Add(this.centerValintanappi);
            this.kuvanSommitteluGroupBox.Controls.Add(this.tileValintanappi);
            this.kuvanSommitteluGroupBox.Controls.Add(this.noneValintanappi);
            this.kuvanSommitteluGroupBox.Controls.Add(this.stretchValintanappi);
            this.kuvanSommitteluGroupBox.Location = new System.Drawing.Point(390, 98);
            this.kuvanSommitteluGroupBox.Name = "kuvanSommitteluGroupBox";
            this.kuvanSommitteluGroupBox.Size = new System.Drawing.Size(262, 151);
            this.kuvanSommitteluGroupBox.TabIndex = 1;
            this.kuvanSommitteluGroupBox.TabStop = false;
            this.kuvanSommitteluGroupBox.Text = "Taustakuvan sommittelu";
            // 
            // kuva1Valintanappi
            // 
            this.kuva1Valintanappi.AutoSize = true;
            this.kuva1Valintanappi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kuva1Valintanappi.Location = new System.Drawing.Point(9, 32);
            this.kuva1Valintanappi.Name = "kuva1Valintanappi";
            this.kuva1Valintanappi.Size = new System.Drawing.Size(88, 17);
            this.kuva1Valintanappi.TabIndex = 2;
            this.kuva1Valintanappi.Text = "Taustakuva1";
            this.kuva1Valintanappi.UseVisualStyleBackColor = true;
            this.kuva1Valintanappi.CheckedChanged += new System.EventHandler(this.kuva1Valintanappi_CheckedChanged);
            // 
            // kuva2Valintanappi
            // 
            this.kuva2Valintanappi.AutoSize = true;
            this.kuva2Valintanappi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kuva2Valintanappi.Location = new System.Drawing.Point(9, 65);
            this.kuva2Valintanappi.Name = "kuva2Valintanappi";
            this.kuva2Valintanappi.Size = new System.Drawing.Size(88, 17);
            this.kuva2Valintanappi.TabIndex = 3;
            this.kuva2Valintanappi.Text = "Taustakuva2";
            this.kuva2Valintanappi.UseVisualStyleBackColor = true;
            this.kuva2Valintanappi.CheckedChanged += new System.EventHandler(this.kuva2Valintanappi_CheckedChanged);
            // 
            // kuva3Valintanappi
            // 
            this.kuva3Valintanappi.AutoSize = true;
            this.kuva3Valintanappi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kuva3Valintanappi.Location = new System.Drawing.Point(9, 97);
            this.kuva3Valintanappi.Name = "kuva3Valintanappi";
            this.kuva3Valintanappi.Size = new System.Drawing.Size(88, 17);
            this.kuva3Valintanappi.TabIndex = 4;
            this.kuva3Valintanappi.Text = "Taustakuva3";
            this.kuva3Valintanappi.UseVisualStyleBackColor = true;
            this.kuva3Valintanappi.CheckedChanged += new System.EventHandler(this.kuva3Valintanappi_CheckedChanged);
            // 
            // centerValintanappi
            // 
            this.centerValintanappi.AutoSize = true;
            this.centerValintanappi.Location = new System.Drawing.Point(6, 32);
            this.centerValintanappi.Name = "centerValintanappi";
            this.centerValintanappi.Size = new System.Drawing.Size(56, 17);
            this.centerValintanappi.TabIndex = 5;
            this.centerValintanappi.Text = "Center";
            this.centerValintanappi.UseVisualStyleBackColor = true;
            this.centerValintanappi.CheckedChanged += new System.EventHandler(this.centerValintanappi_CheckedChanged);
            // 
            // noneValintanappi
            // 
            this.noneValintanappi.AutoSize = true;
            this.noneValintanappi.Location = new System.Drawing.Point(6, 65);
            this.noneValintanappi.Name = "noneValintanappi";
            this.noneValintanappi.Size = new System.Drawing.Size(51, 17);
            this.noneValintanappi.TabIndex = 6;
            this.noneValintanappi.Text = "None";
            this.noneValintanappi.UseVisualStyleBackColor = true;
            this.noneValintanappi.CheckedChanged += new System.EventHandler(this.noneValintanappi_CheckedChanged);
            // 
            // stretchValintanappi
            // 
            this.stretchValintanappi.AutoSize = true;
            this.stretchValintanappi.Location = new System.Drawing.Point(6, 97);
            this.stretchValintanappi.Name = "stretchValintanappi";
            this.stretchValintanappi.Size = new System.Drawing.Size(59, 17);
            this.stretchValintanappi.TabIndex = 7;
            this.stretchValintanappi.Text = "Stretch";
            this.stretchValintanappi.UseVisualStyleBackColor = true;
            this.stretchValintanappi.CheckedChanged += new System.EventHandler(this.stretchValintanappi_CheckedChanged);
            // 
            // tileValintanappi
            // 
            this.tileValintanappi.AutoSize = true;
            this.tileValintanappi.Location = new System.Drawing.Point(114, 32);
            this.tileValintanappi.Name = "tileValintanappi";
            this.tileValintanappi.Size = new System.Drawing.Size(42, 17);
            this.tileValintanappi.TabIndex = 8;
            this.tileValintanappi.Text = "Tile";
            this.tileValintanappi.UseVisualStyleBackColor = true;
            this.tileValintanappi.CheckedChanged += new System.EventHandler(this.tileValintanappi_CheckedChanged);
            // 
            // zoomValintanappi
            // 
            this.zoomValintanappi.AutoSize = true;
            this.zoomValintanappi.Location = new System.Drawing.Point(114, 65);
            this.zoomValintanappi.Name = "zoomValintanappi";
            this.zoomValintanappi.Size = new System.Drawing.Size(52, 17);
            this.zoomValintanappi.TabIndex = 9;
            this.zoomValintanappi.Text = "Zoom";
            this.zoomValintanappi.UseVisualStyleBackColor = true;
            this.zoomValintanappi.CheckedChanged += new System.EventHandler(this.zoomValintanappi_CheckedChanged);
            // 
            // H8Radiobutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kuvanSommitteluGroupBox);
            this.Controls.Add(this.taustaKuvaGroupBox);
            this.Name = "H8Radiobutton";
            this.Text = "H8";
            this.taustaKuvaGroupBox.ResumeLayout(false);
            this.taustaKuvaGroupBox.PerformLayout();
            this.kuvanSommitteluGroupBox.ResumeLayout(false);
            this.kuvanSommitteluGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox taustaKuvaGroupBox;
        private System.Windows.Forms.RadioButton kuva1Valintanappi;
        private System.Windows.Forms.RadioButton kuva2Valintanappi;
        private System.Windows.Forms.RadioButton kuva3Valintanappi;
        private System.Windows.Forms.GroupBox kuvanSommitteluGroupBox;
        private System.Windows.Forms.RadioButton zoomValintanappi;
        private System.Windows.Forms.RadioButton centerValintanappi;
        private System.Windows.Forms.RadioButton tileValintanappi;
        private System.Windows.Forms.RadioButton noneValintanappi;
        private System.Windows.Forms.RadioButton stretchValintanappi;
    }
}

