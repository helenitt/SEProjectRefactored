﻿using System;
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
    public partial class frmQAdd : Form
    {
        Question quest = new Question();
        String fName;
        int lecId;
        
        public frmQAdd()
        {
            InitializeComponent();
        }

        public frmQAdd(String name, int id)
        {
            InitializeComponent();
            fName = name;
            lecId = id;
        }
        private void frmQAdd_Load(object sender, EventArgs e)
        {
            //get next question id to assign
            txtQuestId.Text = quest.getNextQuestId().ToString("0000");

            loadLevels();
            optAddQ1.Checked = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            frmMenu frmNext = new frmMenu(fName, lecId);

            this.Close();
            frmNext.Show();
        }        
        
        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQAddSubmit_Click(object sender, EventArgs e)
        {
            
            // Validate fields not empty

            if (txtQText.Text.Equals(""))
            {
                MessageBox.Show("Question text must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQText.Focus();
                return;
            }

            if (txtAddAns1.Text.Equals(""))
            {
                MessageBox.Show("First answer must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddAns1.Focus();
                return;
            }

            if (txtAddAns2.Text.Equals(""))
            {
                MessageBox.Show("second answer must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddAns2.Focus();
                return;
            }

            if (txtAddAns3.Text.Equals(""))
            {
                MessageBox.Show("Third answer must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddAns3.Focus();
                return;
            }

            if (txtAddAns4.Text.Equals(""))
            {
                MessageBox.Show("Forth answer must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddAns4.Focus();
                return;
            }


            //Set the correct answer, radio button 1, 2,3 or 4

            if (optAddQ1.Checked == true)
            {
                quest.setCorrectAns(1);
            }
            if (optAddQ2.Checked == true)
            {
                quest.setCorrectAns(2);
            }
            if (optAddQ3.Checked == true)
            {
                quest.setCorrectAns(3);
            }
            if (optAddQ4.Checked == true)
            {
                quest.setCorrectAns(4);
            }

            //Instantiate instance variables with values from form controls
            quest.setQuestId(Convert.ToInt32(txtQuestId.Text));
            quest.setQLevel(cboQLvl.Text.Substring(0,1));  //NEED TO GET FIRST LETTER
            quest.setQText(txtQText.Text);
            quest.setAns1(txtAddAns1.Text);
            quest.setAns2(txtAddAns2.Text);
            quest.setAns3(txtAddAns3.Text);
            quest.setAns4(txtAddAns4.Text);
            quest.setQAdd(String.Format("{0:dd-MMM-yy}", DateTime.Now));
            quest.setStatus("a");

            // INSERT QUESTION IN TO DATABASE
            quest.insertQuestion();

            // CONFIRMATION MESSAGE
            MessageBox.Show("Question Created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            // Clear UI
            txtQuestId.Text = quest.getNextQuestId().ToString("0000");
            cboQLvl.SelectedIndex = -1;
            txtQText.Text = "";
            optAddQ1.Checked = false;
            optAddQ2.Checked = false;
            optAddQ3.Checked = false;
            optAddQ4.Checked = false;
            txtAddAns1.Text = "";
            txtAddAns2.Text = "";
            txtAddAns3.Text = "";
            txtAddAns4.Text = "";

            return;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmNext = new frmMenu(fName, lecId);

            this.Close();
            frmNext.Show();
        }
        public void loadLevels()
        {
            //Create Database connection string
            OracleConnection myConn = new OracleConnection(DBConnectITT.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            String strSQL = "SELECT * FROM Levels";

            //Define Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            OracleDataReader dr = cmd.ExecuteReader();

            //Move data from dr to cboQLvls
            while (dr.Read())
            {
                cboQLvl.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }

            //Close DB connection
            myConn.Close();
        }


    }
}
