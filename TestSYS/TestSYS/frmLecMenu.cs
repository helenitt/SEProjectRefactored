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
    public partial class frmLecMenu : Form
    {
        public frmLecMenu()
        {
            InitializeComponent();
        }

        private void frmLecMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            frmQAdd frmNext = new frmQAdd();

            this.Hide();
            frmNext.Show();
        }

        private void btnAmdQuest_Click(object sender, EventArgs e)
        {
            frmQAmd frmNext = new frmQAmd();

            this.Hide();
            frmNext.Show();
        }

        private void btnDelQuest_Click(object sender, EventArgs e)
        {
            frmQDel frmNext = new frmQDel();

            this.Hide();
            frmNext.Show();
        }       
        private void btnAmdStud_Click(object sender, EventArgs e)
        {
            frmLecStudSearch frmNext = new frmLecStudSearch();

            this.Hide();
            frmNext.Show();
        }        

        private void btnStudProf_Click(object sender, EventArgs e)
        {
            frmLecStudSearch frmNext = new frmLecStudSearch();

            this.Hide();
            frmNext.Show();
        }        

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            frmLecStudSearch frmNext = new frmLecStudSearch();

            this.Hide();
            frmNext.Show();
        }




    }
}
