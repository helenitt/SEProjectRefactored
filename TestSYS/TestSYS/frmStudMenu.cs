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
    public partial class frmStudMenu : Form
    {
        Student stud = new Student();
        String fName;
        int studId;
        

        public frmStudMenu()
        {
            InitializeComponent();
        }        
        
        public frmStudMenu(String foreName, int studentId)
        {
            InitializeComponent();
            Student stud = new Student();
            fName = foreName;
            studId = studentId;
        }


        private void frmStudMenu_Load(object sender, EventArgs e)
        {
            txtName.Text = fName;
            //txtId.Text = studId.ToString("0000");  //CHECK OTHER WORKS THEN GET RID
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            frmTTake frmNext = new frmTTake(this, fName, studId);

            this.Hide();
            frmNext.Show();
        }

        private void btnRevTest_Click(object sender, EventArgs e)
        {
            frmTRevw frmNext = new frmTRevw(this, studId);

            this.Hide();
            frmNext.Show();
        } 
        private void btnStudProf_Click(object sender, EventArgs e)
        {
            frmTProfile frmNext = new frmTProfile(this, studId);

            this.Hide();
            frmNext.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)

        {
            Application.Exit();
        }

        private void btnAmdStudDet_Click(object sender, EventArgs e)
        {
            frmStudAmd frmNext = new frmStudAmd(this, fName, studId);

            this.Hide();
            frmNext.Show();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            frmStudDel frmNext = new frmStudDel(this, studId);

            this.Hide();
            frmNext.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
