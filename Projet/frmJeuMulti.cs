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
        public frmJeuMulti(String J1, String J2)
        {
            InitializeComponent();
            lblNom1.Text = J1 + " ?";
            lblNom2.Text = J2 + " ?";
            Joueur1 = J1;
            Joueur2 = J2;
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNom1_Click(object sender, EventArgs e)
        {
            lblAsk.Visible = false;
            lblNom1.Visible = false;
            lblNom2.Visible = false;
            quelJoueur = true;
            lblTour.Text = "Au tour de " + Joueur1 + " !";
        }

        private void lblNom2_Click(object sender, EventArgs e)
        {
            lblAsk.Visible = false;
            lblNom1.Visible = false;
            lblNom2.Visible = false;
            quelJoueur = false;
            lblTour.Text = "Au tour de " + Joueur2 + " !";
        }

        private void cmdFin_Click(object sender, EventArgs e)
        {
            if (clic == 0)
            {
                frmAlerte fenetreAlerte = new frmAlerte();
                fenetreAlerte.ShowDialog();
            }
            else if (quelJoueur == true)
            {
                lblTour.Text = "Au tour de " + Joueur2 + " !";
                quelJoueur = false;
                clic = 0;
            }
            else
            {
                lblTour.Text = "Au tour de " + Joueur1 + " !";
                quelJoueur = true;
                clic = 0;
            }
        }

        private void picture_CLick(object sender, EventArgs e)
        {
            if (lblAsk.Visible == false)
            {
                PictureBox pct_clique = sender as PictureBox;
                if (pct_clique != null && clic < 3)
                {
                    pct_clique.Visible = false;
                    clic++;
                    stylos--;
                    if (stylos <= 0)
                    {
                        cmdFin.Visible = false;
                        if (quelJoueur == true)
                        {
                            lblTour.Text = Joueur1 + " a battu " + Joueur2 + " !";
                        }
                        else
                        {
                            lblTour.Text = Joueur2 + " a battu " + Joueur1 + " !";
                        }
                    }
                }
                else if (clic == 3)
                {
                    if (quelJoueur == true)
                    {
                        lblTour.Text = "Au tour de " + Joueur2 + " !";
                        quelJoueur = false;
                        clic = 0;
                    }
                    else
                    {
                        lblTour.Text = "Au tour de " + Joueur1 + " !";
                        quelJoueur = true;
                        clic = 0;
                    }
                }
            }
        }
    }
}
