using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class frmJeu2 : Form
    {
        int nbrCoups = 0;
        int nbrOrdi, nbAlea, nbrAct = 15;
        Boolean jo_or;

        public frmJeu2()
        {
            InitializeComponent();
        }

        private void picture_CLick(object sender, EventArgs e)
        {
            PictureBox pct_clique = sender as PictureBox;
            if (pct_clique != null)
            {
                pct_clique.Visible = false;
                nbrCoups = nbrCoups + 1;
                nbrAct--;
                lblMsg.Text = "";
                lblMsg2.Text = "";
                jo_or = true;
                Fin_de_jeu();
                if (nbrCoups >= 3)
                {
                    if (nbrCoups == 0)
                    {
                        lblMsg.Text = "Vous n'avez pas joué votre tour !";
                        lblMsg2.Text = "Veuillez enlever au moins un stylo !";
                    }
                    else
                    {
                        lblMsg.Text = "";
                        lblMsg2.Text = "";
                        Nbr_Ordi();
                        jo_or = false;
                        Fin_de_jeu();
                    }
                }
            }

        }

        private void Nbr_Ordi()
        {
            if (nbrAct - 1 == 13 | nbrAct - 2 == 13)
            {
                nbAlea = nbrAct - 13;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct == 13 | nbrAct == 9 | nbrAct == 5 | nbrAct == 1)
            {
                nbAlea = 1;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct - 1 == 9 | nbrAct - 2 == 9 | nbrAct - 3 == 9)
            {
                nbAlea = nbrAct - 9;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct - 1 == 5 | nbrAct - 2 == 5 | nbrAct - 3 == 5)
            {
                nbAlea = nbrAct - 5;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct - 1 == 1 | nbrAct - 2 == 1 | nbrAct - 3 == 1)
            {
                nbAlea = nbrAct - 1;
                nbrAct = nbrAct - nbAlea;
            }
            Tour_Ordi(nbAlea);
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdFin_Click(object sender, EventArgs e)
        {

            
            if (nbrCoups == 0)
            {
                lblMsg.Text = "Vous n'avez pas joué votre tour !";
                lblMsg2.Text = "Veuillez enlever au moins un stylo !";
            }
            else
            {
                lblMsg.Text = "";
                lblMsg2.Text = "";
                Nbr_Ordi();
                jo_or = false;
                Fin_de_jeu();
            }
        }

        private void cmdOui_Click(object sender, EventArgs e)
        {
            cmdOui.Visible = false;
            cmdNon.Visible = false;
            lblAsk.Visible = false;
        }

        private void cmdNon_Click(object sender, EventArgs e)
        {
            cmdOui.Visible = false;
            cmdNon.Visible = false;
            lblAsk.Visible = false;
            Nbr_Ordi();
        }

        private void Fin_de_jeu()
        {
            if (nbrAct <= 0)
            {
                if (jo_or == true)
                {
                    lblMsg.Text = "Vous avez perdu...";
                }
                else
                {
                    lblMsg.Text = "Vous avez gagné !";
                }
                cmdFin.Visible = false;
            }
        }

        private void Tour_Ordi(int a)
        {
            nbrOrdi = 0;
            if (nbrOrdi < a)
            {
                if (pct1.Visible == true)
                {
                    pct1.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct2.Visible == true)
                {
                    pct2.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct3.Visible == true)
                {
                    pct3.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct4.Visible == true)
                {
                    pct4.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct5.Visible == true)
                {
                    pct5.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct6.Visible == true)
                {
                    pct6.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct7.Visible == true)
                {
                    pct7.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct8.Visible == true)
                {
                    pct8.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct9.Visible == true)
                {
                    pct9.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct10.Visible == true)
                {
                    pct10.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct11.Visible == true)
                {
                    pct11.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct12.Visible == true)
                {
                    pct12.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct13.Visible == true)
                {
                    pct13.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct14.Visible == true)
                {
                    pct14.Visible = false;
                    nbrOrdi++;
                }
            }
            if (nbrOrdi < a)
            {
                if (pct15.Visible == true)
                {
                    pct15.Visible = false;
                    nbrOrdi++;
                }
            }
            nbrCoups = 0;
        }
    }
}
