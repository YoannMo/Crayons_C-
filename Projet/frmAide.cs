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
    public partial class frmAide : Form
    {
        public frmAide(int b)
        {
            InitializeComponent();
            if (b == 1)
            {
                lblAide.Text = "Il faut d'abord cliquer sur un des deux pouces !";
            }
            else if (b == 2)
            {
                lblAide.Text = "Vous devez cliquer sur  1, 2 ou 3 objets pour jouer !";
            }
            else if (b == 3)
            {
                lblAide.Text = "Veuillez cliquer sur Fin de tour !";
            }
            else if (b == 4)
            {
                lblAide.Text = "Il faut d'abord choisir qui commence !";
            }
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
