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
        frmStudMenu parent;
        int studId;

        public frmTProfile()
        {
            InitializeComponent();
        }
        public frmTProfile(frmStudMenu Parent, int ID)
        {
            InitializeComponent();
            parent = Parent;
            studId = ID;
        }

        // FEED IN studId AND CHANGE TABLE AND BUTTONS
       private void frmTProfile_Load(object sender, EventArgs e)
        {
            fillGrid("StudId");
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

        private void grdTestReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            grdTests.DataSource = ds.Tables["Students"];

            //Close DB
            myConn.Close();

        }
    }
}
