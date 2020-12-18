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
    public partial class FrmNumeri : Form
    {
        FrmMain finestraPrincipale = null;
        public FrmNumeri(FrmMain sender)
        {
            InitializeComponent();

            finestraPrincipale = sender;

            lblNome.Text = "Nome giocatore: " + finestraPrincipale.txtNome.Text;


        }
    }
}
