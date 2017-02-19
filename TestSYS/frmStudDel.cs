using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSYS
{
    public partial class frmStudDel : Form
    {
        Student deleteStudent;
        Lecturer lecturer;
        string forename;
        int id;
        int studentId;

        public frmStudDel()
        {
            InitializeComponent();
        }

        public frmStudDel(string name, int id)
        {
            InitializeComponent();
            forename = name;
            this.id = id;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(forename, id);
            Close();
            frmNext.Show();
        }

        private void frmStudDel_Load(object sender, EventArgs e)
        {
            
            // todo: Get rid of magic number
            // Check if student or lecturer
            if (id < 9000)
            {
                deleteStudent = new Student(); 
                
                grpStudDel.Visible = true;
                grpLecDel.Visible = false;

                txtDelPsw.Focus();

                deleteStudent.getStudDetails(id);

                // Load student details into form controls
                txtDelSname.Text = deleteStudent.getSName().TrimEnd(); ;
                txtDelFname.Text = deleteStudent.getFName().TrimEnd();
                txtDelEmail.Text = deleteStudent.getEmail().TrimEnd();
                dtpDelDob.Value = Convert.ToDateTime(deleteStudent.getDOB());
            }
            else
            {
                lecturer = new Lecturer();
                deleteStudent = new Student(); 
                
                grpLecDel.Visible = true;
                grpStudDel.Visible = false;

                txtStudId.Focus();
            }  
        }
        
        // STUDENT GROUP DELETE ACCOUNT
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(forename, id);
            Close();
            frmNext.Show();
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
            
            // Check whether user is a student or a lecturer
            if(id < 9000) 
            {
                // Check Passwords are Validate  
                if (!deleteStudent.validStudentLogin((Convert.ToInt16(id)), txtDelPsw.Text))
                {
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfPsw.Focus();
                    return;
                }

                MessageBox.Show("Are you sure you want to delete your account?\n\nTHIS ACTION CAN NOT BE UNDONE", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                try
                {
                    deleteStudent.deleteStudent(id);
                    MessageBox.Show("Account Sucessfully Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                catch
                {
                    MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                // Check Passwords are Validate  
                if (!lecturer.validLecLogin((Convert.ToInt16(id)), txtDelPsw.Text))
                {
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfPsw.Focus();
                    return;
                }

                MessageBox.Show("Are you sure you want to delete this account?\n\nTHIS ACTION CAN NOT BE UNDONE", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                deleteStudent.deleteStudent(studentId);

                MessageBox.Show("Account Sucessfully Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var frmNext = new frmMenu(forename, id);

                Close();
                frmNext.Show();
            }           
        }

        // LECTURER'S GROUP OF STUDENT AMEND
        private void txtStudId_TextChanged(object sender, EventArgs e)
        {
            if (txtStudId.Text.Equals(""))
                return;

            studentId = Convert.ToInt32(txtStudId.Text);

            if (!txtStudId.Text.Equals(""))
            {
                fillLecGridId((txtStudId.Text));
            }
            else
                fillLecGrid("Sname, Fname");
        }


        private void txtStudSname_TextChanged(object sender, EventArgs e)
        {
            fillLecGridName(txtStudSname.Text.ToUpper());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strId = grdStudList.Rows[grdStudList.CurrentCell.RowIndex].Cells[0].Value.ToString();
            studentId = Convert.ToInt32(strId);

            grpLecDel.Visible = false;
            grpStudDel.Visible = true;

            deleteStudent.getStudDetails(studentId);

            // Load student details into form controls
            txtDelSname.Text = deleteStudent.getSName().TrimEnd();
            txtDelFname.Text = deleteStudent.getFName().TrimEnd();
            txtDelEmail.Text = deleteStudent.getEmail().TrimEnd();
            dtpDelDob.Value = Convert.ToDateTime(deleteStudent.getDOB());
        }


        private void btnMenuSearch_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(forename, id);
            Close();
            frmNext.Show();
        }

        public void fillLecGrid(string sortOrder)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves Students details
            string strSQL = "SELECT StudId, Sname, Fname, DOB, RegDate FROM Students ORDER BY " + sortOrder;

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Execute Query using Oracle Data Adapter
            var dataAdapter = new SQLiteDataAdapter(cmd);
            var dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Students");
            grdStudList.DataSource = dataSet.Tables["Students"];

            //Close DB
            myConn.Close();
        }

        public void fillLecGridId(string idString)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

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

            //Close DB
            myConn.Close();
        }

        public void fillLecGridName(string name)
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);

            //Define SDQL query which retrieves MAX StudId in Students                              
            string strSQL = "SELECT StudId, Sname, Fname, DOB, RegDate FROM Students WHERE Sname LIKE '" + name + "%'";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Execute Query using Oracle Data Adapter
            var dataAdapter = new SQLiteDataAdapter(cmd);
            var dataSets = new DataSet();

            dataAdapter.Fill(dataSets, "Students");
            grdStudList.DataSource = dataSets.Tables["Students"];

            //Close DB
            myConn.Close();
        }
    }
}
