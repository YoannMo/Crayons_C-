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
            Principal();
    }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdNiv1_Click(object sender, EventArgs e)
        {
            frmJeu fenetreJeu = new frmJeu();
            fenetreJeu.ShowDialog();
            Principal();
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            Jeux();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            lblRegles.Visible = true;
            lblTxt1.Visible = true;
            lblTxt2.Visible = true;
            lblTxt3.Visible = true;
            pctGl.Visible = true;
            pctExit.Visible = true;
            lblPlay.Visible = false;
            lblHelp.Visible = false;
            lblExit.Visible = false;
            lblJeu.Visible = false;
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

        private void Jeux()
        {
            cmdSolo.Visible = true;
            cmdMulti.Visible = true;
            pctUser1.Visible = true;
            pctUser2.Visible = true;
            pctUser3.Visible = true;
            lblPlay.Visible = false;
            lblHelp.Visible = false;
            lblExit.Visible = false;
            pctExit.Visible = true;
            cmdNiv1.Visible = false;
            cmdNiv2.Visible = false;
            pctEtEz.Visible = false;
            pctEtHa1.Visible = false;
            pctEtHa2.Visible = false;
            pctEtHa3.Visible = false;
            lblTitre.Visible = false;
            lblJeu.Visible = true;
            lblJ1.Visible = false;
            lblJ2.Visible = false;
            txtJ1.Visible = false;
            txtJ2.Visible = false;
            cmdGo.Visible = false;
            lblRegles.Visible = false;
            lblTxt1.Visible = false;
            lblTxt2.Visible = false;
            lblTxt3.Visible = false;
            pctGl.Visible = false;
            pctBack.Visible = false;
            lblBack1.Visible = false;
            lblBack2.Visible = false;
        }

        private void Principal()
        {
            cmdNiv1.Visible = false;
            cmdNiv2.Visible = false;
            pctExit.Visible = false;
            lblPlay.Visible = true;
            lblHelp.Visible = true;
            lblExit.Visible = true;
            pctEtEz.Visible = false;
            pctEtHa1.Visible = false;
            pctEtHa2.Visible = false;
            pctEtHa3.Visible = false;
            cmdSolo.Visible = false;
            cmdMulti.Visible = false;
            pctUser1.Visible = false;
            pctUser2.Visible = false;
            pctUser3.Visible = false;
            lblTitre.Visible = false;
            lblJ1.Visible = false;
            lblJ2.Visible = false;
            txtJ1.Visible = false;
            txtJ2.Visible = false;
            lblJeu.Visible = true;
            cmdGo.Visible = false;
            lblRegles.Visible = false;
            lblTxt1.Visible = false;
            lblTxt2.Visible = false;
            lblTxt3.Visible = false;
            pctGl.Visible = false;
            pctBack.Visible = false;
            lblBack1.Visible = false;
            lblBack2.Visible = false;
        }

        private void cmdSolo_Click(object sender, EventArgs e)
        {
            lblPlay.Visible = false;
            cmdNiv1.Visible = true;
            cmdNiv2.Visible = true;
            lblHelp.Visible = false;
            lblExit.Visible = false;
            pctExit.Visible = true;
            pctEtEz.Visible = true;
            pctEtHa1.Visible = true;
            pctEtHa2.Visible = true;
            pctEtHa3.Visible = true;
            cmdSolo.Visible = false;
            cmdMulti.Visible = false;
            pctUser1.Visible = false;
            pctUser2.Visible = false;
            pctUser3.Visible = false;
            pctBack.Visible = true;
            lblBack1.Visible = true;
            lblBack2.Visible = true;
        }

        private void cmdMulti_Click(object sender, EventArgs e)
        {
            lblTitre.Visible = true;
            lblJ1.Visible = true;
            lblJ2.Visible = true;
            txtJ1.Visible = true;
            txtJ2.Visible = true;
            lblJeu.Visible = false;
            cmdSolo.Visible = false;
            cmdMulti.Visible = false;
            pctUser1.Visible = false;
            pctUser2.Visible = false;
            pctUser3.Visible = false;
            pctExit.Visible = true;
            cmdGo.Visible = true;
            pctBack.Visible = true;
            lblBack1.Visible = true;
            lblBack2.Visible = true;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text != "" && txtJ2.Text != "")
            {
                frmJeuMulti fenetreJeuMulti = new frmJeuMulti(txtJ1.Text, txtJ2.Text);
                fenetreJeuMulti.ShowDialog();
                Principal();
            }
        }

        private void pctBack_Click(object sender, EventArgs e)
        {
            Jeux();
        }
    }
}
