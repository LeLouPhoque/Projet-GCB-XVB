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
    public partial class FModifieIN : Form
    {
        public FModifieIN()
        {
            InitializeComponent();
            
        }
        
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtRue.Text = string.Empty;
            txtVille.Text = string.Empty;

        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            //faudra modifier les données dans la base de données, du l'utilisateur courant 
            //d'abord se connecter a la base de données, et récupérer les informations, pour vérifier que le connexion a bien étais établit
            //ensuite pouvoir modifier les données saisies, et SAUVEGARDER les informations 
            // enfin vérification

            



        }
      

        
    }
}
