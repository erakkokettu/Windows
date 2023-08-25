using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4Label
{
    public partial class H4Label : Form
    {
        public H4Label()
        {
            InitializeComponent();
        }

        private void tunnusLipuke_MouseHover(object sender, EventArgs e)
        {
            Label aktiiviLipuke = (Label)sender;
            aktiiviLipuke.BackColor = SystemColors.ActiveBorder;
        }

        private void tunnusLipuke_MouseLeave(object sender, EventArgs e)
        {
            Label aktiiviLipuke = (Label)sender;
            aktiiviLipuke.BackColor = SystemColors.Control;
        }

        private void salasanaLipuke_MouseHover(object sender, EventArgs e)
        {
            Label aktiiviLipuke = (Label)sender;
            aktiiviLipuke.BackColor = SystemColors.ActiveBorder;
        }

        private void salasanaLipuke_MouseLeave(object sender, EventArgs e)
        {
            Label aktiiviLipuke = (Label)sender;
            aktiiviLipuke.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tunnusTekstikentta.Text.Equals("Muumi") && (salasanaTekstikentta.Text.Equals("Laakso")))
                palauteLipuke.Text = "Tervetuloa!";
            else
                palauteLipuke.Text = "Kirjautuminen ei onnistunut!";


        }
        int fonttiKoko = 10;
        private void palauteLipuke_MouseDown(object sender, MouseEventArgs e)
        {
            if (fonttiKoko <= 10)
                fonttiKoko = 10;
            else
                fonttiKoko--;

            palauteLipuke.Font = new Font(new FontFamily("Tahoma"), fonttiKoko);
        }

        private void palauteLipuke_MouseHover(object sender, EventArgs e)
        {
            palauteLipuke.Font = new Font(new FontFamily("Tahoma"), fonttiKoko++);
        }
    }
}
