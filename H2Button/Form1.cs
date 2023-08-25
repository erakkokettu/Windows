using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2Button
{
    public partial class H2Button : Form
    {
        public H2Button()
        {
            InitializeComponent();
        }


        private void EkaPainike_Click(object sender, EventArgs e)
        {
            if (tokaPainike.Visible)
            {
                tokaPainike.Visible = false;
                ((Button)sender).Text = "Näytä painike 2";
                this.BackColor = Color.CadetBlue;
            }
            else
            {
                tokaPainike.Visible = true;
                ((Button)sender).Text = "Piilota painike 2";
                this.BackColor = Color.Teal;
            }
        }

        private void tokaPainike_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tokaPainike_MouseHover(object sender, EventArgs e)
        {
            tokaPainike.BackColor = Color.Navy;
        }

        private void tokaPainike_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.AntiqueWhite;
        }
    }
}
