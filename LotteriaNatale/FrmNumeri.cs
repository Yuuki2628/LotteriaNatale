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
        List<int> scelte = new List<int>();
        Random g = new Random();

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
                btn.BackColor = Color.White;

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

            if (b.BackColor == Color.Green)
            {
                scelte.Remove(Convert.ToInt32(b.Text));
                b.BackColor = Color.White;
            }
            else
            {
                scelte.Add(Convert.ToInt32(b.Text));

                b.BackColor = Color.Green;

                scelte.Sort();
            }

            string numeriScelti = "";
            for (int i = 0; i < scelte.Count; i++)
            {
                numeriScelti = numeriScelti + " " + scelte[i];
            }
            txtNumeriScelti.Text = numeriScelti;
        }

        public void GeneraCheckbox()
        {
            for (int i = 0; i < 90; i++)
            {
                CheckBox c = new CheckBox();

                c.Text = i.ToString();

                flpLotteria.Controls.Add(c);
            }
        }

        private void btnCompleta_Click(object sender, EventArgs e)
        {
            int win = g.Next(1, 91);
            bool vittoria = false;
            for (int i = 0; i < scelte.Count && !vittoria; i++)
            {
                if (win == scelte[i])
                {
                    MessageBox.Show("Congratulazioni!\nHai vinto un premio", "Hai vinto!");
                    vittoria = true;
                }
            }
            if (vittoria)
            {
                MessageBox.Show("Congratulazioni!\nHai vinto un premio", "Hai vinto!");

            }
            else
            {
                MessageBox.Show("Peccato.\nNon hai vinto alcun premio", "Hai perso!");
            }
            for (int i = 0; i< 90; i++)
            {
                pulsanti[i].BackColor = Color.White;
                pulsanti[i].Enabled = false;
                btnVittoria.Enabled = false;
            }
        }
}
}
