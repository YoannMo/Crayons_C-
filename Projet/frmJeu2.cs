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
            pctWin.Visible = false;
            pctLose.Visible = false;
            lblTour.Visible = false;
            cmdFin.Visible = false;
        }

        private void picture_CLick(object sender, EventArgs e)
        {
            if (cmdOui.Visible == false)
            {
                PictureBox pct_clique = sender as PictureBox;
                if (pct_clique != null)
                {
                    pct_clique.Visible = false;
                    nbrCoups ++;
                    nbrAct--;
                    jo_or = true;
                    Fin_de_jeu();
                    if (nbrCoups >= 3)
                    {
                        lblTour.Visible = false;
                        cmdFin.Visible = false;
                        Nbr_Ordi();
                        jo_or = false;
                        Fin_de_jeu();
                    }
                }
            }

        }

        private void Nbr_Ordi()
        {
            if (nbrAct - 1 == 12 | nbrAct - 2 == 12 | nbrAct - 3 == 12)
            {
                nbAlea = nbrAct - 12;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct == 12 | nbrAct == 8 | nbrAct == 4 | nbrAct == 1)
            {
                nbAlea = 1;
                nbrAct = nbrAct - 1;
            }
            else if (nbrAct - 1 == 8 | nbrAct - 2 == 8 | nbrAct - 3 == 8)
            {
                nbAlea = nbrAct - 8;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct - 1 == 4 | nbrAct - 2 == 4 | nbrAct - 3 == 4)
            {
                nbAlea = nbrAct - 4;
                nbrAct = nbrAct - nbAlea;
            }
            else if (nbrAct - 1 == 0 | nbrAct - 2 == 0 | nbrAct - 3 == 0)
            {
                nbAlea = nbrAct;
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
                frmAlerte fenetreAlerte = new frmAlerte();
                fenetreAlerte.ShowDialog();
            }
            else
            {
                cmdFin.Visible = false;
                lblTour.Visible = false;
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
            cmdFin.Visible = true;
            lblTour.Visible = true;
        }

        private void cmdNon_Click(object sender, EventArgs e)
        {
            cmdOui.Visible = false;
            cmdNon.Visible = false;
            lblAsk.Visible = false;
            cmdFin.Visible = false;
            lblTour.Visible = false;
            Nbr_Ordi();
        }

       
        private void Fin_de_jeu()
        {
            if (nbrAct <= 0)
            {
                if (jo_or == true)
                {
                    pctWin.Visible = true;
                    cmdFin.Visible = false;
                    lblTour.Visible = false;
                }
                else
                {
                    pctLose.Visible = true;
                    cmdFin.Visible = false;
                    lblTour.Visible = false;
                }
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
            lblTour.Visible = true;
            cmdFin.Visible = true;
        }
    }
}
