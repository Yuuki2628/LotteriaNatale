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
        Button[] pulsanti = new Button[90];
        CheckBox[] checkbox = new CheckBox[90];
        int[] scelte = new int[90];
        int numeriSelezionati = 0;

        public FrmNumeri(FrmMain sender)
        {
            InitializeComponent();

            finestraPrincipale = sender;

            lblNome.Text = "Nome giocatore: " + finestraPrincipale.txtNome.Text;

            if (finestraPrincipale.rbdCheckbox.Checked)
                GeneraCheckbox();
            else
                GeneraPulsanti();
        }

        public void GeneraPulsanti()
        {
            int nBtn = Convert.ToInt32(Math.Ceiling(Math.Sqrt(90)));
            int wBtn = Convert.ToInt32(flpLotteria.Width / nBtn);

            for (int i = 0; i < 90; i++)
            {
                Button btn;

                btn = new Button();

                btn.Width = btn.Height = wBtn;
                btn.Font = new Font("Tahoma", wBtn / 4);

                btn.Margin = new Padding(0);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.Text = Convert.ToString(i + 1);

                btn.Click += Btn_Click;

                flpLotteria.Controls.Add(btn);
                pulsanti[i] = btn;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            numeriSelezionati++;

            Ordina(scelte);

            b.Enabled = false;

            for(int i = 0; i < numeriSelezionati; i++)
            {
                txtNumeriScelti.Text = txtNumeriScelti.Text + " " + scelte[i].ToString();
            }
        }

        public void GeneraCheckbox()
        {

        }

        public void Ordina(int[] a)
        {
            int[] b = new int[90];
            for(int i = 0; i < numeriSelezionati; i++)
            {
                int min = int.MaxValue;
                for(int c = i; c < numeriSelezionati; c++)
                {
                    if (a[c] < min)
                        min = a[c];
                }
                b[i] = min;
            }
            a = b;
        }
    }
}
