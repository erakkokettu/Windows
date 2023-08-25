using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3TextBox
{
    public partial class H3TextBox : Form
    {
        public H3TextBox()
        {
            InitializeComponent();
        }

        private void LauseTekstikentta_TextChanged(object sender, EventArgs e)
        {
            LauseTekstikentta.BackColor = Color.Fuchsia;

            arkistoTekstikentta.BackColor = Color.White;
        }

        private void arkistoTekstikentta_TextChanged(object sender, EventArgs e)
        {
            arkistoTekstikentta.BackColor = Color.Cyan;
        }

        private void kopiointiPainike_Click(object sender, EventArgs e)
        {
            arkistoTekstikentta.BackColor = Color.SeaGreen;

            arkistoTekstikentta.Text = LauseTekstikentta.Text + " " + arkistoTekstikentta.Text;
            arkistoTekstikentta_TextChanged(sender, e);
        }

        private void salausPainike_Click(object sender, EventArgs e)
        {
            if (arkistoTekstikentta.PasswordChar == '*')
                arkistoTekstikentta.PasswordChar = '\0';
            else
                arkistoTekstikentta.PasswordChar = '*';

            ((Button)sender).Text = "Kumoa tekstin salaus";
        }
    }
}
