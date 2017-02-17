using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSYS
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmStudAdd frmNext = new frmStudAdd(this);

            this.Hide();
            frmNext.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmNext = new frmLogin(this);

            this.Hide();
            frmNext.Show();
        }

    }
}
