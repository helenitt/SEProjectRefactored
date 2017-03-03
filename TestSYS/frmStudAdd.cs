using System;
using System.Windows.Forms;
using LightInject;

namespace TestSYS
{
    public partial class frmStudAdd : Form
    {
        private IServiceContainer _container;

        frmWelcome parent;
        Student newStudent = new Student();

        public frmStudAdd()
        {
            InitializeComponent();
        }

        public frmStudAdd(IServiceContainer container)
        {
            _container = container;
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
            txtStudId.Text = newStudent.getNextStudId().ToString("0000");
            dtpAddDob.MaxDate = DateTime.Today.AddYears(-17);

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }
        
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
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
            newStudent.setStudId(Convert.ToInt16(txtStudId.Text));
            newStudent.setSName(txtAddSNm.Text.ToUpper());
            newStudent.setFName(txtAddFNm.Text.ToUpper());
            newStudent.setDOB(String.Format("{0:dd-MMM-yy}", dtpAddDob.Value));
            newStudent.setEmail(txtAddEmail.Text);
            newStudent.setPassword(txtAddSPsw.Text);
            newStudent.setRegDate(String.Format("{0:dd-MMM-yy}", DateTime.Now));

            DateTime expDate = Convert.ToDateTime(newStudent.getRegDate()).AddDays(91);
            newStudent.setExpDate(String.Format("{0:dd-MMM-yy}", expDate));
            
            //Insert into Database
            newStudent.insertStudent();

            //Confirm message
            MessageBox.Show("Student Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var frmNext = _container.GetInstance<frmMenu>();
            Close();
            frmNext.Show();
        }
    }    
}
