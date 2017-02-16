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
    public partial class frmQAmd : Form
    {
        frmLecMenu parent;
        Question quest = new Question();
        int questId;

        public frmQAmd()
        {
            InitializeComponent();
        }
        public frmQAmd(frmLecMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
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

        private void frmQAmd_Load(object sender, EventArgs e)
        {
            txtAmdQID.Focus();
        }

        private void txtAmdQID_TextChanged(object sender, EventArgs e)
        {
            questId = Convert.ToInt32(txtAmdQID.Text);   //TRY ADDING THE TRAILING OOO

            quest.getQuestionDetails(questId);

            // Load question details into form controls
              loadLevels();
            //cboQLvl.Text = quest.getQLevel();
            cboQLvl.SelectedText = quest.getQLevel();    
            //cboQLvl.SelectedValue.ToString();

            txtQText.Text = quest.getQText().TrimEnd();
            // Radio button checked either 1 2 3 or 4       NOT WORKING!!!!!!
            if (quest.getCorrectAns() == 1) 
            {
                optAmd1.Checked = true;
            }
            else if (quest.getCorrectAns() == 2)
            {
                optAmd2.Checked = true;
            }
            else if (quest.getCorrectAns() == 3)
            {
                optAmd3.Checked = true;
            }
            else if (quest.getCorrectAns() == 4)
            {
                optAmd4.Checked = true;
            }

            txtAmdAns1.Text = quest.getAns1().TrimEnd();
            txtAmdAns2.Text = quest.getAns2().TrimEnd();
            txtAmdAns3.Text = quest.getAns3().TrimEnd();
            txtAmdAns4.Text = quest.getAns4().TrimEnd();
        }

        private void btnAmdSubmit_Click(object sender, EventArgs e)
        {
            String amdDate = (String.Format("{0:dd-MMM-yy}", DateTime.Now));

            // Instantiate instance variables with updated values from form controls
            quest.setQLevel(cboQLvl.Text.Substring(0, 1));
            quest.setQText(txtQText.Text);
            quest.setAns1(txtAmdAns1.Text);
            quest.setAns2(txtAmdAns2.Text);
            quest.setAns3(txtAmdAns3.Text);
            quest.setAns4(txtAmdAns4.Text);

            //Set the correct answer, radio button 1, 2,3 or 4
            if (optAmd1.Checked == true)
            {
                quest.setCorrectAns(1);
            }
            if (optAmd2.Checked == true)
            {
                quest.setCorrectAns(2);
            }
            if (optAmd3.Checked == true)
            {
                quest.setCorrectAns(3);
            }
            if (optAmd4.Checked == true)
            {
                quest.setCorrectAns(4);
            }                                       
            quest.setQAmd(String.Format("{0:dd-MMM-yy}", DateTime.Now));

            // INSERT QUESTION IN TO DATABASE
            // TRY THIS TRY
            //try
            //{
                quest.updateQuestion();

                // CONFIRMATION MESSAGE
                MessageBox.Show("Question Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear UI
                txtAmdQID.Focus();
                cboQLvl.SelectedIndex = -1;
                txtQText.Text = "";
                optAmd1.Checked = false;
                optAmd2.Checked = false;
                optAmd3.Checked = false;
                optAmd4.Checked = false;
                txtAmdAns1.Text = "";
                txtAmdAns2.Text = "";
                txtAmdAns3.Text = "";
                txtAmdAns4.Text = "";
            //
            //catch // (Exception err)
            //{
            //    MessageBox.Show("An Error has Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
