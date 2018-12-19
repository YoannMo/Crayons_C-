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
    public partial class frmJeuMulti : Form
    {
        Boolean quelJoueur;
        String Joueur1, Joueur2;
        int clic = 0;
        int stylos = 15;
        Boolean tour;
        int aide;

        public frmJeuMulti(String J1, String J2)
        {
            InitializeComponent();
            aide = 4;
            lblNom1.Text = J1 + " ?";
            lblNom2.Text = J2 + " ?";
            Joueur1 = J1;
            Joueur2 = J2;
            cmdFin.Visible = false;
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNom1_Click(object sender, EventArgs e)          //Si le joueur 1 décide de commencer
        {
            tour = true;
            lblAsk.Visible = false;
            lblNom1.Visible = false;
            lblNom2.Visible = false;
            quelJoueur = true;
            cmdFin.Visible = true;
            lblTour.Text = "Au tour de " + Joueur1 + " !";
            aide = 2;
        }

        private void lblNom2_Click(object sender, EventArgs e)              //Si le joueur 2 décide de commencer
        {
            tour = true;
            lblAsk.Visible = false;
            lblNom1.Visible = false;
            lblNom2.Visible = false;
            quelJoueur = false;
            cmdFin.Visible = true;
            lblTour.Text = "Au tour de " + Joueur2 + " !";
            aide = 2;
        }

        private void cmdFin_Click(object sender, EventArgs e)               
        {
            if (clic == 0)
            {
                frmAlerte fenetreAlerte = new frmAlerte(true);              //Alerte si pas de coups faits et que le joueur appuie sur fin de tour 
                fenetreAlerte.ShowDialog();
            }
            else if (quelJoueur == true)
            {
                lblJoueur.Text = Joueur1 + " a enlevé\n" + clic + " objets.";
                lblTour.Text = "Au tour de " + Joueur2 + " !";
                quelJoueur = false;
                clic = 0;
                tour = true;
                aide = 2;
            }
            else
            {
                lblJoueur.Text = Joueur2 + " a enlevé\n" + clic + " objets.";
                lblTour.Text = "Au tour de " + Joueur1 + " !";
                quelJoueur = true;
                clic = 0;
                tour = true;
                aide = 2;
            }
        }

        private void pctInterr_Click(object sender, EventArgs e)
        {
            frmAide fenetreAcc = new frmAide(aide);
            fenetreAcc.ShowDialog();
        }

        private void picture_CLick(object sender, EventArgs e)
        {
            if (lblAsk.Visible == false & tour == true)
            {
                PictureBox pct_clique = sender as PictureBox;                   //D'autres commentaires inutiles 
                if (pct_clique != null && clic < 3)
                {
                    pct_clique.Visible = false;
                    clic++;
                    stylos--;
                    if (stylos <= 0)
                    {
                        cmdFin.Visible = false;
                        lblTour.Visible = false;
                        pctInterr.Visible = false;
                        if (quelJoueur == true)
                        {
                            lblVic.Text = Joueur1 + " a battu " + Joueur2 + " !";
                        }
                        else
                        {
                            lblVic.Text = Joueur2 + " a battu " + Joueur1 + " !";
                        }
                    }
                }
                else if (clic >= 3)
                {
                    tour = false;
                    aide = 3;
                }
            }
        }
    }
}
