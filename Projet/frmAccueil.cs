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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
            cmdNiv1.Visible = false;
            cmdNiv2.Visible = false;
            lblEz.Visible = false;
            lblHard.Visible = false;
            pctExit.Visible = false;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdNiv1_Click(object sender, EventArgs e)
        {
            frmJeu fenetreJeu = new frmJeu();
            fenetreJeu.ShowDialog();
            Principal();
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            cmdPlay.Visible = false;
            cmdNiv1.Visible = true;
            cmdNiv2.Visible = true;
            lblEz.Visible = true;
            lblHard.Visible = true;
            cmdHelp.Visible = false;
            cmdExit.Visible = false;
            pctExit.Visible = true;
            pctTrait1.Visible = false;
            pctTrait2.Visible = false;
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            frmPrincipe fenetreListe = new frmPrincipe();
            fenetreListe.ShowDialog();
        }

        private void cmdNiv2_Click(object sender, EventArgs e)
        {
            frmJeu2 fenetreJeu2 = new frmJeu2();
            fenetreJeu2.ShowDialog();
            Principal();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Principal();
        }

        private void Principal()
        {
            cmdNiv1.Visible = false;
            cmdNiv2.Visible = false;
            lblEz.Visible = false;
            lblHard.Visible = false;
            pctExit.Visible = false;
            cmdPlay.Visible = true;
            cmdHelp.Visible = true;
            cmdExit.Visible = true;
            pctTrait1.Visible = true;
            pctTrait2.Visible = true;
        }
    }
}
