using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H6RichTextbox
{
    public partial class H6RichTextbox : Form
    {
        public H6RichTextbox()
        {
            InitializeComponent();
        }

        private void richTiedostoTekstikentta_VScroll(object sender, EventArgs e)
        {
            Random random = new Random();

            richTiedostoTekstikentta.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

        }

        private void latausPainike_Click(object sender, EventArgs e)
        {
            richTiedostoTekstikentta.LoadFile(nimiTekstikentta.Text, RichTextBoxStreamType.RichText);
            StreamReader sr = File.OpenText(nimiTekstikentta.Text);
            tiedostoTekstikentta.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void tallennusPainike_Click(object sender, EventArgs e)
        {
            richTiedostoTekstikentta.SaveFile(nimiTekstikentta.Text);
        }

        private void putsausPainike_Click(object sender, EventArgs e)
        {
            richTiedostoTekstikentta.Text = "";
            tiedostoTekstikentta.Text = "";
        }

        private void lopetusPainike_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
