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
    public partial class frmTTake : Form
    {
        frmStudMenu parent;
        Test test = new Test();
        TestQuestion testQuest = new TestQuestion();
        Question quest = new Question();       
        String level;
        String fName;
        int studId;
        int index = 1;
        int countQuest;
        int nxtQuest;
        int score;
        int[] testQuestId;

        public frmTTake()
        {
            InitializeComponent();
        }

        public frmTTake(frmStudMenu Parent, String foreName, int ID)
        {
            InitializeComponent();
            parent = Parent;
            fName = foreName;
            studId = ID;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTTake_Load(object sender, EventArgs e)
        {
            //Get next test id to assign
            txtTestId.Text = test.getNextTestId().ToString("0000");
            txtName.Text = fName;
            loadLevels();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (cboTTLvl.Text.Equals(""))
            {
                MessageBox.Show("Please choose a test level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboTTLvl.Focus();
                return;
            }

            //Get all question id of that level store in array nxtQuestion            
            int[] levelQuestIds = test.getLevelQuestIds(cboTTLvl.Text.Substring(0, 1));
            
            // CREATE TEST           
            testQuestId = quest.getTestQuestions(levelQuestIds);

               //  FOR TESTING
               for (int i = 0; i < testQuestId.Length; i++)
               {
                   MessageBox.Show(" testQuestId " + testQuestId[i], "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
            score = 0;

            // GET NEXT QUESTION 
            quest.displayQuestion(testQuestId);

            //LOAD QUESTION ONE AND MAKE VISIBLE
            grpTTQ1.Visible = true;  //remove til get to that stage!!!!
            // Load question details into form controls
            grpTTQ1.Text = "Question" + index;
            txtQText.Text = quest.getQText();    //.TrimEnd();
            txtAns1.Text = quest.getAns1();
            txtAns2.Text = quest.getAns2();
            txtAns3.Text = quest.getAns3();
            txtAns4.Text = quest.getAns4();
            optOne.Checked = true;
//string[] answers = new string[4];    NOT HERE I THINK !!!!!
            

        }

        private void btnTTNxQ_Click(object sender, EventArgs e)
        {
            //SAVE ANSWER
            //Set the correct answer from checked radio button, 1, 2,3 or 4

            if (optOne.Checked == true)
            {
                testQuest.setAnsGiven(1);
            }
            if (optTwo.Checked == true)
            {
                testQuest.setAnsGiven(2);
            }
            if (optThree.Checked == true)
            {
                testQuest.setAnsGiven(3);
            }
            if (optFour.Checked == true)
            {
                testQuest.setAnsGiven(4);
            }

            //CHECK AGAINST CORRECT ANSWER & INCREMENT SCORE
            if (testQuest.getAnsGiven() == quest.getCorrectAns())   
            {
                score += 25;
            }

            //HERE GO FROM HERE!!!
            MessageBox.Show("AnsGiven" + testQuestId[i], "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);




            // GET RID AFTER THIS
            if (grpTTQ1.Visible == true)
            {
   //Get Next Question    
                grpTTQ1.Visible = false;
                grpTTQ2.Visible = true;
            }
            else if (grpTTQ2.Visible == true)
            {
                grpTTQ2.Visible = false;
                grpTTQ3.Visible = true;
            }
            else 
            {
                grpTTQ3.Visible = false;
                grpTTQ4.Visible = true;
                btnTTNxQ.Visible = false;
                btnTTSubmit.Visible = true;
            }
            
            
        }

        private void btnTTSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your test is complete - Your score is 100%", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            parent.Visible = true;    // GO TO REVIEW !!!!!!
        }

        private void loadLevels()
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
                cboTTLvl.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }

            //Close DB connection
            myConn.Close();
        }
    }
}
