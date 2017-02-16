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
    public partial class frmLecStudSearch : Form
    {
        Student stud = new Student();
        int id;
        String idString, name;

        public frmLecStudSearch()
        {
            InitializeComponent();
        }

        private void frmLecStudSearch_Load(object sender, EventArgs e)
        {
            fillGrid("StudId");
            //grdStudList.FullRowSelect = true;
        }

        private void radStudId_Click(object sender, EventArgs e)
        {
            fillGrid("StudId");
        }
        private void txtStudId_TextChanged(object sender, EventArgs e)
        {
            //id = Convert.ToInt32(txtStudId.Text);

            if (!txtStudId.Text.Equals(""))
            {
                fillGridId((txtStudId.Text));
            }
            else
                fillGrid("Sname, Fname");
        }       
        private void radSname_Click(object sender, EventArgs e)
        {
            fillGrid("Sname,Fname");
        }
        private void radSname_CheckedChanged(object sender, EventArgs e)
        {
            txtStudId.Clear();
        }
        private void txtStudSname_TextChanged(object sender, EventArgs e)
        {
            fillGridName(txtStudSname.Text);
        }
        private void grdStudList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String strId = grdStudList.Rows[grdStudList.CurrentCell.RowIndex].Cells[0].Value.ToString();

            //NOT SURE WHERE TO GO NOW!!
        } 
       
        private void btnAmdStud_Click(object sender, EventArgs e)
        {
            frmStudAmd frmNext = new frmStudAmd(Convert.ToInt32(grdStudList.Rows[grdStudList.CurrentCell.RowIndex].Cells[0].Value)); // May possibly have to be different forms or just invoke the method
 
            this.Close();
            frmNext.Show();            
        }
      
        private void btnDelStud_Click(object sender, EventArgs e)
        {
            frmStudDel frmNext = new frmStudDel(); // May possibly have to be different forms  or just invoke the method

            this.Hide();
            frmNext.Show();
        }

        public void fillGrid(String sortOrder)
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX StudId in Students
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

        public void fillGridId(String idString)
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

        public void fillGridName(String name)
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





    }
}
