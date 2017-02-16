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
    public partial class frmStudAmd : Form
    {
        frmStudMenu parent;
        String fName;
        int studId;
        Student amdStud = new Student();
        

        public frmStudAmd()
        {
            InitializeComponent();
        }

        public frmStudAmd(frmStudMenu Parent, String foreName, int Id)
        {
            InitializeComponent();
            parent = Parent;
            fName = foreName;
            studId = Id;

        }
        public frmStudAmd(int Id)
        {
            InitializeComponent();
            studId = Id;
        }
 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();

            // IF TO SEE WHERE TO RETURN TO GETCLASS()
            if (this.GetType().Name == "frmStudMenu")
            {
                parent.Visible = true;
            }
            else
            {
                //parent_2.Visible = true;
            }
            
        }

        private void frmStudAmd_Load(object sender, EventArgs e)
        {
            txtAmdSname.Focus();
            
            amdStud.getStudDetails(studId);

            // Load student details into form controls
            txtAmdSname.Text = amdStud.getSName().TrimEnd();
            txtAmdFname.Text = amdStud.getFName().TrimEnd();
            txtAmdEmail.Text = amdStud.getEmail().TrimEnd();
            dtpAmdDob.Value = Convert.ToDateTime(amdStud.getDOB());
        }

        private void btnAmdStud_Click(object sender, EventArgs e)
        {
            if (txtAmdSname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmdSname.Focus();
                return;
            }
            if (txtAmdFname.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmdFname.Focus();
                return;
            }
            if (txtAmdEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmdEmail.Focus();
                return;
            }

            String dob = String.Format("{0:dd-MMM-yy}", dtpAmdDob.Value);

            if (dtpAmdDob.Text.Equals(""))
            {
                MessageBox.Show("Date of Birth must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAmdDob.Focus();
                return;
            }

            if (txtAmdPsw.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmdPsw.Focus();
                return;
            }
            if (txtConfPsw.Text.Equals(""))
            {
                MessageBox.Show("Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPsw.Focus();
                return;
            }
            // Validate Passwords match
            if (!txtAmdPsw.Text.Equals(txtConfPsw.Text))
            {
                MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPsw.Focus();
                return;
            }

            String amdDate = (String.Format("{0:dd-MMM-yy}", DateTime.Now));

            // Instantiate instance variables with updated values from form controls
            amdStud.setSName(txtAmdSname.Text.ToUpper());
            amdStud.setFName(txtAmdFname.Text.ToUpper());
            amdStud.setEmail(txtAmdEmail.Text);
            amdStud.setDOB(dob);
            amdStud.setPassword(txtAmdPsw.Text);
            amdStud.setAmdDate(amdDate);

            //Update Database
            amdStud.updateStudent();

            //Confirm message
            MessageBox.Show("Student Details Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmStudMenu frmNext = new frmStudMenu(fName, studId);
            this.Close();
            frmNext.Show();

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

    }
}
