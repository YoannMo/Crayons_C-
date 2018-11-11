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

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdNiv1_Click(object sender, EventArgs e)
        {
            frmJeu fenetreListe = new frmJeu();
            fenetreListe.ShowDialog();
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            cmdPlay.Visible = false;
            cmdNiv1.Visible = true;
            cmdNiv2.Visible = true;
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {
            frmPrincipe fenetreListe = new frmPrincipe();
            fenetreListe.ShowDialog();
        }
    }
}
