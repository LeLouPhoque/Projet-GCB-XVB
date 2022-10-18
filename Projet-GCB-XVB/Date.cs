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
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbMois.SelectedIndex = -1;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FormM3 form1 = new FormM3();
            form1.Show();
        }
    }
}
