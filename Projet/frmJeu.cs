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
    public partial class frmJeu : Form
    {
        int nbrCoups = 0;
        Random rnd = new Random();
        int nbrOrdi, nbAlea, nbrIm;

        public frmJeu()
        {
            InitializeComponent();
        }

        private void picture_CLick(object sender, EventArgs e)
        {
            PictureBox pct_clique = sender as PictureBox;
            if (pct_clique != null)
            {
                pct_clique.Visible = false;
                nbrCoups = nbrCoups + 1;
                nbrIm++;
                lblMsg.Text = "";
                lblMsg2.Text = "";
                if (nbrCoups >= 3)
                {
                    nbAlea = rnd.Next(1, 4);
                    if (nbrCoups == 0)
                    {
                        lblMsg.Text = "Vous n'avez pas joué votre tour !";
                        lblMsg2.Text = "Veuillez enlever au moins un stylo !";
                    }
                    else
                    {
                        lblMsg.Text = "";
                        lblMsg2.Text = "";
                        Tour_Ordi(nbAlea);
                        nbrIm = nbrIm + nbAlea;
                    }
                }
            }
            
        }


        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdFin_Click(object sender, EventArgs e)
        {
            
            nbAlea = rnd.Next(1, 4);
            if (nbrCoups == 0)
            {
                lblMsg.Text = "Vous n'avez pas joué votre tour !";
                lblMsg2.Text = "Veuillez enlever au moins un stylo !";
            }
            else
            {
                lblMsg.Text = "";
                lblMsg2.Text = "";
                Tour_Ordi(nbAlea);
                nbrIm = nbrIm + nbAlea;
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
        }

        
    }
}
