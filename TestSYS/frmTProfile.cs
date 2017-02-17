using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace TestSYS
{
    public partial class frmTProfile : Form
    {
        String fName;
        int id;

        public frmTProfile()
        {
            InitializeComponent();
        }
        public frmTProfile(String fName, int id)
        {
            InitializeComponent();
            this.fName = fName;
            this.id = id;
        }

        // FEED IN studId AND CHANGE TABLE AND BUTTONS
       private void frmTProfile_Load(object sender, EventArgs e)
        {
            //Check if student or lecturer
            if (id < 9000)
            {
                grpStudent.Visible = true;
                grpLecturer.Visible = false;

                fillStudGrid("TestId", id);
            }
            else
            {
                grpLecturer.Visible = true;
                grpStudent.Visible = false;

                txtStudId.Focus();
            }           
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         private void mnuBack_Click(object sender, EventArgs e)
        {
            frmMenu frmNext = new frmMenu(fName, id);

            this.Close();
            frmNext.Show();
        }
        
        //STUDENT TEST PROFILE
        private void btnFinishedProfile_Click(object sender, EventArgs e)
        {
            frmMenu frmNext = new frmMenu(fName, id);

            this.Close();
            frmNext.Show();
        }

         // FILL GRID FOR STUDENT TEST PROFILE
         public void fillStudGrid(String sortOrder, int id)
         {
             //Create Database connection string
             OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
             //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

             //Define SQL query which retrieves Students Test Results
             String strSQL = "SELECT TestId,TestDate,Score,LevelCode FROM Tests WHERE StudId = " + id + " ORDER BY " + sortOrder;     

             //Define Oracle Command
             OracleCommand cmd = new OracleCommand(strSQL, myConn);

             //Open DB Connection
             myConn.Open();

             //Execute Query using Oracle Data Adapter
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             DataSet ds = new DataSet();

             da.Fill(ds, "Tests");
             grdTests.DataSource = ds.Tables["Tests"];

             //Close DB
             myConn.Close();

         }


        // LECTURER'S VIEW OF STUDENT TEST PROFILE

         private void txtStudId_TextChanged(object sender, EventArgs e)
         {
             //id = Convert.ToInt32(txtStudId.Text);

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
             String strId = grdStudList.Rows[grdStudList.CurrentCell.RowIndex].Cells[0].Value.ToString();
             int sId = Convert.ToInt32(strId);

             grpLecturer.Visible = false;
             grpStudent.Visible = true;
             fillStudGrid("TestId", sId);
         }

         public void fillLecGrid(String sortOrder)
         {
             //Create Database connection string
             OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
             //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

             //Define SDQL query which retrieves Students details
             String strSQL = "SELECT StudId,Sname,Fname,DOB,RegDate FROM Students ORDER BY " + sortOrder;

             //Define Oracle Command
             OracleCommand cmd = new OracleCommand(strSQL, myConn);

             //Open DB Connection
             myConn.Open();

             //Execute Query using Oracle Data Adapter
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             DataSet ds = new DataSet();

             da.Fill(ds, "Students");
             grdStudList.DataSource = ds.Tables["Students"];

             //Close DB
             myConn.Close();

         }

         public void fillLecGridId(String idString)
         {
             //Create Database connection string
             OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
             //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

             //Define SDQL query which retrieves MAX StudId in Students
             int id = Convert.ToInt32(idString);
             String strSQL = "SELECT StudId,Sname,Fname,DOB,RegDate FROM Students WHERE StudId = " + id;

             //Define Oracle Command
             OracleCommand cmd = new OracleCommand(strSQL, myConn);

             //Open DB Connection
             myConn.Open();

             //Execute Query using Oracle Data Adapter
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             DataSet ds = new DataSet();

             da.Fill(ds, "Students");
             grdStudList.DataSource = ds.Tables["Students"];

             //Close DB
             myConn.Close();

         }

         public void fillLecGridName(String name)
         {
             //Create Database connection string
             OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
             //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

             //Define SDQL query which retrieves MAX StudId in Students                              
             String strSQL = "SELECT StudId,Sname,Fname,DOB,RegDate FROM Students WHERE Sname LIKE '" + name + "%'";

             //Define Oracle Command
             OracleCommand cmd = new OracleCommand(strSQL, myConn);

             //Open DB Connection
             myConn.Open();

             //Execute Query using Oracle Data Adapter
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             DataSet ds = new DataSet();

             da.Fill(ds, "Students");
             grdStudList.DataSource = ds.Tables["Students"];

             //Close DB
             myConn.Close();

         }

         private void btnMainMenu_Click(object sender, EventArgs e)
         {
             frmMenu frmNext = new frmMenu(fName, id);

             this.Close();
             frmNext.Show();
         }
    }
}
