using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H8Radiobutton
{
    public partial class H8Radiobutton : Form
    {
        public H8Radiobutton()
        {
            InitializeComponent();
        }

        private void kuva1Valintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.candles;

            taustaKuvaGroupBox.Visible = false;
            this.Text = "Napauta ikkunaa saadaksesi valintanapit näkyviin.";
        }

        private void kuva2Valintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.skull;
            taustaKuvaGroupBox.Visible = false;
            this.Text = "Napsauta ikkunaa saadaksesi valintanapit näkyviin.";
        }

        private void kuva3Valintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.moon; 
            taustaKuvaGroupBox.Visible = false;
            this.Text = "Napsauta ikkunaa saadaksesi valintanapit näkyviin";
        }

        private void centerValintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
            kuvanSommitteluGroupBox.Visible = false;

        }

        private void noneValintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.None;
            kuvanSommitteluGroupBox.Visible = false;
        }

        private void stretchValintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            kuvanSommitteluGroupBox.Visible = false;
        }

        private void tileValintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Tile;
            kuvanSommitteluGroupBox.Visible = false;
        }

        private void zoomValintanappi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            kuvanSommitteluGroupBox.Visible = false;
        }
    }
}
