using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H1Form
{
    public partial class H1Form : Form
    {
        public H1Form()
        {
            InitializeComponent();
        }

        private void H1Form_Load(object sender, EventArgs e)
        {
            this.Text = "Minun ensimmäinen ohjelma! " + DateTime.Now;
        }

        int laskuri = 0;
        private void H1Form_MouseClick(object sender, MouseEventArgs e)
        {
            Form uusiIkkuna = new Form();
            uusiIkkuna.Text = "Ikkuna" + ++laskuri;
            uusiIkkuna.BackColor = Color.Aqua;
            uusiIkkuna.Size = new Size(250, 250);
            uusiIkkuna.Location = new Point(50, 50);
            uusiIkkuna.Show();
        }

        private void H1Form_Move(object sender, EventArgs e)
        {
            Random r = new Random();
            Color taustaVari = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            this.BackColor = taustaVari;
        }
    }
}
