﻿using System;
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
    public partial class frmJeu : Form
    {
        int nbrCoups = 0;
        Random rnd = new Random();
        int nbrOrdi, nbAlea, nbrIm = 0;
        Boolean jo_or;
        Boolean tour, msg=true;
        int aide;
    

        public frmJeu()
        {
            InitializeComponent();
            aide = 1;
            cmdFin.Visible = false;
            pctWin.Visible = false;
            pctLose.Visible = false;
            lblTour.Visible = false;
        }

        private void cmdOui_Click(object sender, EventArgs e)
        {
            tour = true;
            cmdOui.Visible = false;
            cmdNon.Visible = false;
            lblAsk.Visible = false;
            cmdFin.Visible = true;
            lblTour.Visible = true;
            aide = 2;
        }

        private void cmdNon_Click(object sender, EventArgs e)
        {
            tour = true;
            cmdOui.Visible = false;
            cmdNon.Visible = false;
            lblAsk.Visible = false;
            nbAlea = rnd.Next(1, 4);
            Tour_Ordi(nbAlea);
            nbrIm = nbrIm + nbAlea;
            cmdFin.Visible = true;
            aide = 2;
        }

        private void picture_CLick(object sender, EventArgs e)
        {
            if (cmdOui.Visible == false & tour ==true)
            {
                PictureBox pct_clique = sender as PictureBox;
                if (pct_clique != null)
                {
                    pct_clique.Visible = false;
                    nbrCoups = nbrCoups + 1;
                    nbrIm++;
                    jo_or = true;
                    Fin_de_jeu();
                    if (nbrCoups >= 3)
                    {
                        tour = false;
                        aide = 3;
                        if (msg)
                        {
                            frmAlerte fenetreAlerte = new frmAlerte(false);
                            fenetreAlerte.ShowDialog();
                            msg = !msg;
                        }
                    }
                }
            }
        }
        private void cmdFin_Click(object sender, EventArgs e)
        {

            if (nbrCoups == 0)
            {
                frmAlerte fenetreAlerte = new frmAlerte(true);
                fenetreAlerte.ShowDialog();
            }
            else
            {
                lblTour.Visible = false;
                cmdFin.Visible = false;
                nbAlea = rnd.Next(1, 4);
                Tour_Ordi(nbAlea);
                nbrIm = nbrIm + nbAlea;
                jo_or = false;
                Fin_de_jeu();
                tour = true;
                aide = 2;
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
            cmdFin.Visible = true;
            lblTour.Visible = true;
            lblOrdi.Text = "L'ordinateur a enlevé " + a + " crayons.";
        }

        private void pctInterr_Click(object sender, EventArgs e)
        {
            frmAide fenetreAcc = new frmAide(aide);
            fenetreAcc.ShowDialog();
        }

        private void Fin_de_jeu()
        {
            if (nbrIm >= 15)
            {
                if (jo_or == true)
                {
                    pctWin.Visible = true;
                    cmdFin.Visible = false;
                }
                else
                {
                    pctLose.Visible = true;
                    cmdFin.Visible = false;
                }
                cmdFin.Visible = false;
                lblTour.Visible = false;
                pctInterr.Visible = false;
                lblOrdi.Visible = false;
            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
