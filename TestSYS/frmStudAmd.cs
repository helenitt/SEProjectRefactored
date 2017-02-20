using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSYS
{
    public partial class frmStudAmd : Form
    {
        Student amendStudent = new Student();
        Lecturer lecturer = new Lecturer();

        string forname;
        int id;
        int studentId;
       
        public frmStudAmd()
        {
            InitializeComponent();
        }
        public frmStudAmd(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public frmStudAmd(string foreName, int id)
        {
            InitializeComponent();
            forname = foreName;
            this.id = id;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            var nextForm = new frmMenu(forname, id);
            Close();
            nextForm.Show();
        }

        private void frmStudAmd_Load(object sender, EventArgs e)
        {
            dtpAmdDob.MaxDate = DateTime.Today.AddYears(-17);
       
            //Get rid of magic number
            //Check if student or lecturer
            if (id < 9000)
            {
                grpStudAmd.Visible = true;
                grpLecAmd.Visible = false;
    
                txtAmdSname.Focus();

                amendStudent.getStudDetails(id);

                // Load student details into form controls
                txtAmdSname.Text = amendStudent.getSName().TrimEnd();
                txtAmdFname.Text = amendStudent.getFName().TrimEnd();
                txtAmdEmail.Text = amendStudent.getEmail().TrimEnd();
                dtpAmdDob.Value = Convert.ToDateTime(amendStudent.getDOB());

            }
            else
            {
                grpLecAmd.Visible = true;
                grpStudAmd.Visible = false;

                txtStudId.Focus();
            }      
            
        }

        //STUDENT AMEND GROUP
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

            string dob = string.Format("{0:dd-MMM-yy}", dtpAmdDob.Value);

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
           
            string amdDate = (string.Format("{0:dd-MMM-yy}", DateTime.Now));

            // Instantiate instance variables with updated values from form controls
            amendStudent.setSName(txtAmdSname.Text.ToUpper());
            amendStudent.setFName(txtAmdFname.Text.ToUpper());
            amendStudent.setEmail(txtAmdEmail.Text);
            amendStudent.setDOB(dob);
            amendStudent.setAmdDate(amdDate);

            // Get rid of magic number
            if (id < 9000)
            {
                amendStudent.setPassword(txtAmdPsw.Text);
            }
            else
            {
                try
                {
                    lecturer.validLecLogin(id, txtAmdPsw.Text);
                }
                catch
                {
                    MessageBox.Show("Incorrect Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Update Database
            amendStudent.updateStudent();

            //Confirm message
            MessageBox.Show("Student Details Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMenu frmNext;

            if (id < 9000)
            {
                frmNext = new frmMenu(txtAmdFname.Text.ToUpper(), id);
            }
            else
            {
                frmNext = new frmMenu(forname, id);
            }
            
            Close();
            frmNext.Show();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(forname, id);
            Close();
            frmNext.Show();
        }

        // LECTURER'S GROUP STUDENT SEARCH
        private void txtStudId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtStudId.Text.Equals(""))
                {
                    studentId = Convert.ToInt32(txtStudId.Text);
                    fillLecGridId((txtStudId.Text));
                }
                else
                {
                    fillLecGrid("Sname, Fname");
                }    
            }
            catch
            {
                txtStudId.Focus();
                return;
            }
        }

        private void txtStudSname_TextChanged(object sender, EventArgs e)
        {
            fillLecGridName(txtStudSname.Text.ToUpper());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strId = grdStudList.Rows[grdStudList.CurrentCell.RowIndex].Cells[0].Value.ToString();
            studentId = Convert.ToInt32(strId);

            grpLecAmd.Visible = false;
            grpStudAmd.Visible = true;

            amendStudent.getStudDetails(studentId);

            // Load student details into form controls
            txtAmdSname.Text = amendStudent.getSName().TrimEnd();
            txtAmdFname.Text = amendStudent.getFName().TrimEnd();
            txtAmdEmail.Text = amendStudent.getEmail().TrimEnd();
            dtpAmdDob.Value = Convert.ToDateTime(amendStudent.getDOB());
        }

        private void btnMenuSearch_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(forname, id);
            Close();
            frmNext.Show();
        }

        public void fillLecGrid(String sortOrder)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(DbSetup.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves Students details
            string strSQL = "SELECT StudId, Sname, Fname, DOB, RegDate FROM Students ORDER BY " + sortOrder;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Execute Query using Oracle Data Adapter
            var dataAdpter = new SQLiteDataAdapter(cmd);
            var dataSet = new DataSet();

            dataAdpter.Fill(dataSet, "Students");
            grdStudList.DataSource = dataSet.Tables["Students"];

            DbConnect.CloseDb();
        }

        public void fillLecGridId(string idString)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(DbSetup.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students
            int id = Convert.ToInt32(idString);
            string strSQL = "SELECT StudId, Sname, Fname, DOB, RegDate FROM Students WHERE StudId = " + id;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Execute Query using Oracle Data Adapter
            var dataAdapter = new SQLiteDataAdapter(cmd);
            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Students");
            grdStudList.DataSource = dataSet.Tables["Students"];

            DbConnect.CloseDb();
        }

        public void fillLecGridName(string name)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(DbSetup.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students                              
            string strSQL = "SELECT StudId, Sname, Fname, DOB, RegDate FROM Students WHERE Sname LIKE '" + name + "%'";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Execute Query using Oracle Data Adapter
            var dataAdapter = new SQLiteDataAdapter(cmd);
            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Students");
            grdStudList.DataSource = dataSet.Tables["Students"];

            DbConnect.CloseDb();
        }
    }
}
