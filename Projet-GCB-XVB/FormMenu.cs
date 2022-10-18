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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMission1_Click(object sender, EventArgs e)
        {
            FormM1 form1 = new FormM1();
            form1.Show();
        }

        private void btnMission2_Click(object sender, EventArgs e)
        {
            FormM2 form1 = new FormM2();
            form1.Show();
        }

        private void btnMission3_Click(object sender, EventArgs e)
        {
            Date form1 = new Date();
            form1.Show();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();s
        }
    }
}
