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
    public partial class Connexion : Form
    {

        public Connexion()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            lblError.Text=Modele.validConnexion(txtBoxUserName.Text, txtBoxMdp.Text);
            if (Modele.connexionValide)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
        }
        public static void ThreadProc()
        {
            Application.Run(new FormMenu());
        }


        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtBoxUserName.Clear();
            txtBoxMdp.Clear();
        }
    }
}
