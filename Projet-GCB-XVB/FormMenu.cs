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

        private void m1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormM1 form1 = new FormM1();
            form1.Show();
        }

        private void m2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormM2 form1 = new FormM2();
            form1.Show();
        }

        private void m3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormM3 form1 = new FormM3();
            form1.Show();
        }
    }
}
