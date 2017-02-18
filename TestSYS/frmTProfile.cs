﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSYS
{
    public partial class frmTProfile : Form
    {
        string fName;
        int id;

        public frmTProfile()
        {
            InitializeComponent();
        }
        public frmTProfile(string fName, int id)
        {
            InitializeComponent();
            this.fName = fName;
            this.id = id;
        }

        // FEED IN studId AND CHANGE TABLE AND BUTTONS
       private void frmTProfile_Load(object sender, EventArgs e)
        {
            // Get rid of magic number
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
            var frmNext = new frmMenu(fName, id);

            Close();
            frmNext.Show();
        }
        
        //STUDENT TEST PROFILE
        private void btnFinishedProfile_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(fName, id);

            Close();
            frmNext.Show();
        }

         // FILL GRID FOR STUDENT TEST PROFILE
         public void fillStudGrid(string sortOrder, int id)
         {
             //Create Database connection string
             var myConn = new SQLiteConnection(Db.ConnectionString);

             //Define SQL query which retrieves Students Test Results
             string strSQL = "SELECT TestId,TestDate, Score, LevelCode FROM Tests WHERE StudId = " + id + " ORDER BY " + sortOrder;     

             //Define Oracle Command
             var cmd = new SQLiteCommand(strSQL, myConn);

             //Open DB Connection
             myConn.Open();

             //Execute Query using Oracle Data Adapter
             var dataAdapter = new SQLiteDataAdapter(cmd);
             DataSet dataSet = new DataSet();

             dataAdapter.Fill(dataSet, "Tests");
             grdTests.DataSource = dataSet.Tables["Tests"];

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
             string strId = grdStudList.Rows[grdStudList.CurrentCell.RowIndex].Cells[0].Value.ToString();
             int sId = Convert.ToInt32(strId);

             grpLecturer.Visible = false;
             grpStudent.Visible = true;
             fillStudGrid("TestId", sId);
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
             string strSQL = "SELECT StudId,Sname,Fname,DOB,RegDate FROM Students WHERE StudId = " + id;

             //Define Oracle Command
             var cmd = new SQLiteCommand(strSQL, myConn);

             //Open DB Connection
             myConn.Open();

             //Execute Query using Oracle Data Adapter
             var dataAdapter = new SQLiteDataAdapter(cmd);
             DataSet dataSet = new DataSet();

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
             var dataSet = new DataSet();

             dataAdapter.Fill(dataSet, "Students");
             grdStudList.DataSource = dataSet.Tables["Students"];

             //Close DB
             myConn.Close();
         }

         private void btnMainMenu_Click(object sender, EventArgs e)
         {
             var frmNext = new frmMenu(fName, id);

             Close();
             frmNext.Show();
         }
    }
}
