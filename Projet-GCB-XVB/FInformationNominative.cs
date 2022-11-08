using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GCB_XVB
{
    public partial class FInformationNominative : Form
    {
        public FInformationNominative()
        {
            InitializeComponent();
        }

        private void FVisiteur_Load(object sender, EventArgs e)
        {
            //bsVisiteur.DataSource = Modele.Listevisiteur();

        }

        private void bsInformationNominative_CurrentChanged(object sender, EventArgs e)
        {
            txtNom.Text = ((Visiteur)bsVisiteur.Current).nom.ToString();
            txtPrenom.Text = ((Visiteur)bsVisiteur.Current).prenom.ToString();
            txtRue.Text = ((Visiteur)bsVisiteur.Current).rue.ToString();
            txtCP.Text = ((Visiteur)bsVisiteur.Current).cp.ToString();
            txtVille.Text = ((Visiteur)bsVisiteur.Current).ville.ToString();    


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //a faire plustard

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
