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
    public partial class FormM2 : Form
    {
        public FormM2()
        {
            InitializeComponent();
        }

        private void visiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormM2_Visiteur form1 = new FormM2_Visiteur();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormM2_Rapport form1 = new FormM2_Rapport();
            form1.Show();
        }

        private void medicament_Click(object sender, EventArgs e)
        {
            FormM2_medic form1 = new FormM2_medic();
            form1.Show();
        }

        private void medecin_Click(object sender, EventArgs e)
        {
            FormM2_Medecins form1 = new FormM2_Medecins();
            form1.Show();
        }
    }
}
