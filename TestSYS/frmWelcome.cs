using System;
using System.Windows.Forms;
using TestSYS.LightInject;

namespace TestSYS
{
    public partial class frmWelcome : Form
    {
        private IServiceContainer _container;

        public frmWelcome(IServiceContainer container)
        {
            _container = container;
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmStudAdd>();
            Hide();
            frmNext.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmStudAdd>();
            Hide();
            frmNext.Show();
        }
    }
}
