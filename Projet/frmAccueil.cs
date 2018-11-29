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
            Jeux();
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            lblRegles.Visible = true;
            lblTxt1.Visible = true;
            lblTxt2.Visible = true;
            lblTxt3.Visible = true;
            lblTxt4.Visible = true;
            pctGl.Visible = true;
            pctExit.Visible = true;
            cmdPlay.Visible = false;
            cmdHelp.Visible = false;
            cmdExit.Visible = false;
            pctTrait1.Visible = false;
            pctTrait2.Visible = false;
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
            lblSolo.Visible = true;
            lblMulti.Visible = true;
            cmdPlay.Visible = false;
            cmdHelp.Visible = false;
            cmdExit.Visible = false;
            pctTrait1.Visible = true;
            pctTrait2.Visible = false;
            pctExit.Visible = true;
            cmdNiv1.Visible = false;
            cmdNiv2.Visible = false;
            lblEz.Visible = false;
            lblHard.Visible = false;
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
            lblGo.Visible = false;
            lblRegles.Visible = false;
            lblTxt1.Visible = false;
            lblTxt2.Visible = false;
            lblTxt3.Visible = false;
            lblTxt4.Visible = false;
            pctGl.Visible = false;
            pctBack.Visible = false;
            lblBack1.Visible = false;
            lblBack2.Visible = false;
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
            pctEtEz.Visible = false;
            pctEtHa1.Visible = false;
            pctEtHa2.Visible = false;
            pctEtHa3.Visible = false;
            lblSolo.Visible = false;
            lblMulti.Visible = false;
            lblTitre.Visible = false;
            lblJ1.Visible = false;
            lblJ2.Visible = false;
            txtJ1.Visible = false;
            txtJ2.Visible = false;
            lblJeu.Visible = true;
            lblGo.Visible = false;
            lblRegles.Visible = false;
            lblTxt1.Visible = false;
            lblTxt2.Visible = false;
            lblTxt3.Visible = false;
            lblTxt4.Visible = false;
            pctGl.Visible = false;
            pctBack.Visible = false;
            lblBack1.Visible = false;
            lblBack2.Visible = false;
        }

        private void lblSolo_Click(object sender, EventArgs e)
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
            pctEtEz.Visible = true;
            pctEtHa1.Visible = true;
            pctEtHa2.Visible = true;
            pctEtHa3.Visible = true;
            lblSolo.Visible = false;
            lblMulti.Visible = false;
            pctTrait1.Visible = false;
            pctBack.Visible = true;
            lblBack1.Visible = true;
            lblBack2.Visible = true;
        }

        private void lblMulti_Click(object sender, EventArgs e)
        {
            lblTitre.Visible = true;
            lblJ1.Visible = true;
            lblJ2.Visible = true;
            txtJ1.Visible = true;
            txtJ2.Visible = true;
            lblJeu.Visible = false;
            lblSolo.Visible = false;
            lblMulti.Visible = false;
            pctTrait1.Visible = false;
            pctExit.Visible = true;
            lblGo.Visible = true;
            pctBack.Visible = true;
            lblBack1.Visible = true;
            lblBack2.Visible = true;
        }

        private void lblGo_Click(object sender, EventArgs e)
        {
            frmJeuMulti fenetreJeuMulti = new frmJeuMulti(txtJ1.Text, txtJ2.Text);
            fenetreJeuMulti.ShowDialog();
            Principal();
        }

        private void pctBack_Click(object sender, EventArgs e)
        {
            Jeux();
        }
    }
}
