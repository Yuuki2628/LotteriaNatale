using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteriaNatale
{
    public partial class FrmMain : Form
    {
        FrmNumeri numeri;

        public FrmMain()
        {
            InitializeComponent();

            btnGenera.Enabled = false;
        }

        private void rbdPulsanti_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
                btnGenera.Enabled = true;
            if (txtNome.Text == "")
                btnGenera.Enabled = false;
        }

        private void rbtCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
                btnGenera.Enabled = true;
            if (txtNome.Text == "")
                btnGenera.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (rbdPulsanti.Checked || rbdCheckbox.Checked)
                btnGenera.Enabled = true;
            if (txtNome.Text == "")
                btnGenera.Enabled = false;
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            numeri = new FrmNumeri(this);
        }
    }
}
