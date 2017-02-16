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
    public partial class frmStudAdd : Form
    {
        frmWelcome parent;
        Student newStud = new Student();

        public frmStudAdd()
        {
            InitializeComponent();
        }

        public frmStudAdd(frmWelcome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
       
        private void frmStudAdd_Load(object sender, EventArgs e)
        {
            //get next stud id to assign
            txtStudId.Text = newStud.getNextStudId().ToString("0000");
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();   
        }
 
        private void btnAddSSubmit_Click(object sender, EventArgs e)
        {
            if (txtAddSNm.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddSNm.Focus();
                return;
            }
            if (txtAddFNm.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddFNm.Focus();
                return;
            }
            if (txtAddEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddEmail.Focus();
                return;
            }

            
            if (dtpAddDob.Text.Equals(""))
            {
                MessageBox.Show("Date of Birth must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpAddDob.Focus();
                return;
            }

            if (txtAddSPsw.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddSPsw.Focus();
                return;
            }
            if (txtConfPsw.Text.Equals(""))  
            {
                MessageBox.Show("Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPsw.Focus();
                return;
            }
            // Validate Passwords match
           if (!txtAddSPsw.Text.Equals(txtConfPsw.Text))  
            {
                MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPsw.Focus();
                return;
            } 

            //Instantiate instance variables with values from form controls
            newStud.setStudId(Convert.ToInt16(txtStudId.Text));
            newStud.setSName(txtAddSNm.Text.ToUpper());
            newStud.setFName(txtAddFNm.Text.ToUpper());
            newStud.setDOB(String.Format("{0:dd-MMM-yy}", dtpAddDob.Value));
            newStud.setEmail(txtAddEmail.Text);
            newStud.setPassword(txtAddSPsw.Text);
            newStud.setRegDate(String.Format("{0:dd-MMM-yy}", DateTime.Now));
            
            //DON'T FORGET EXPIRY DATE !!!!!!!


            //Insert into Database
            newStud.insertStudent();

            //Confirm message
            MessageBox.Show("Student Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmStudMenu nextForm = new frmStudMenu();
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }







    }
    
}
