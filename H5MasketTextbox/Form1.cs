using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H5MasketTextbox
{
    public partial class H5MasketTextbox : Form
    {
        public H5MasketTextbox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rekisteriPainike_Click(object sender, EventArgs e)
        {
            if (yhteenvetoTextBox.Text != "")
                yhteenvetoTextBox.Text = "";

            yhteenvetoTextBox.Text += "\tHenkilötiedot" + Environment.NewLine + "Nimi:\t\t" + nimiMaskedTextBox.Text + Environment.NewLine +
            "Tunnus:\t\t" + tunnusMaskedTextBox.Text + Environment.NewLine +
            "GSM:\t\t" + gsmMaskedTextBox.Text + Environment.NewLine +
            "Sähköposti:\t" + spostiMaskedTextBox.Text;


        }
    }
}
