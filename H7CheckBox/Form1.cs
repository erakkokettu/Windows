using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H7CheckBox
{
    public partial class H7 : Form
    {

        FontFamily alkuFf, uusiFf;
        Font alkuFontti, uusiFontti;

        private void variValintaRuutu_CheckedChanged(object sender, EventArgs e)
        {
            if (variValintaRuutu.Checked)
            {
                variValintaRuutu.Font = uusiFontti;
                variValintaRuutu.ForeColor = Color.Red;
                this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)); 
            }
            else
            {
                variValintaRuutu.Font = alkuFontti;
                variValintaRuutu.ForeColor = Color.Black;
            }
        }

        private void kokoValintaruutu_CheckedChanged(object sender, EventArgs e)
        {
            Size alkuKoko = new Size(465, 325);

            if (kokoValintaruutu.Checked )
            {
                kokoValintaruutu.Font = uusiFontti;
                kokoValintaruutu.ForeColor = Color.Red;
                this.Size = new Size(alkuKoko.Width + r.Next(50), alkuKoko.Height + r.Next(50));

            }
            else
            {
                kokoValintaruutu.Font = alkuFontti;
                kokoValintaruutu.ForeColor = Color.Black;

                this.Size = alkuKoko;
            }
        }

        private void sijaintiValintaRuutu_CheckedChanged(object sender, EventArgs e)
        {
            Point alkuSijainti = new Point(130, 132);

            if (sijaintiValintaRuutu.Checked)
            {
                sijaintiValintaRuutu.Font = uusiFontti;
                sijaintiValintaRuutu.ForeColor = Color.Red;
                this.Location = new Point(alkuSijainti.X + r.Next(50), alkuSijainti.Y + r.Next(50));
            }
            else
            {
                sijaintiValintaRuutu.Font = alkuFontti;
                sijaintiValintaRuutu.ForeColor = Color.Black;

                this.Location = alkuSijainti;
            }
        }

        Random r;

        public H7()
        {
            InitializeComponent();

            alkuFf = new FontFamily("Microsoft Sans Serif");
            alkuFontti = new Font(alkuFf, 8, GraphicsUnit.Point);

            uusiFf = new FontFamily("Times New Roman");
            uusiFontti = new Font(uusiFf, 14, GraphicsUnit.Point);

            r = new Random();
        }
    }
}
