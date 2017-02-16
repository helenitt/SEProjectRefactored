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
    public partial class frmStudDel : Form
    {
        frmStudMenu parent;
        int studId;
        Student delStud = new Student();

        public frmStudDel()
        {
            InitializeComponent();
        }

        public frmStudDel(frmStudMenu Parent, int Id)
        {
            InitializeComponent();
            parent = Parent;
            studId = Id;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmStudDel_Load(object sender, EventArgs e)
        {
            txtDelPsw.Focus();

            delStud.getStudDetails(studId);

            //load student details into form controls
            txtDelSname.Text = delStud.getSName().TrimEnd(); ;
            txtDelFname.Text = delStud.getFName().TrimEnd();
            txtDelEmail.Text = delStud.getEmail().TrimEnd();
            dtpDelDob.Value = Convert.ToDateTime(delStud.getDOB());
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            if (txtDelPsw.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDelPsw.Focus();
                return;
            }
            if (txtConfPsw.Text.Equals(""))
            {
                MessageBox.Show("Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPsw.Focus();
                return;
            }
            // Validate Passwords match
            if (!txtDelPsw.Text.Equals(txtConfPsw.Text))
            {
                MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPsw.Focus();
                return;
            }

            MessageBox.Show("Are you sure you want to delete your account?\n\nTHIS ACTION CAN NOT BE UNDONE", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            try
            {
                delStud.deleteStudent(studId);

                MessageBox.Show("Account Sucessfully Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
