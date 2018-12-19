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
    public partial class frmAlerte : Form
    {
        public frmAlerte(Boolean a)
        {
            InitializeComponent();
            if (a)
            {
                lblAl1.Text = "Vous n'avez pas joué votre tour !";
                lblAl2.Text = "Veuillez enlever au moins un objet !";
            }
            else 
            {
                lblAl1.Text = "Vous avez fini votre tour !";
                lblAl2.Text = "Veuillez cliquer sur Fin de tour !";
            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
