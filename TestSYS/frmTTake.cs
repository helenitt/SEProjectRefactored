using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSYS
{
    public partial class frmTTake : Form
    {
        Test test = new Test();
        TestQuestion testQuest = new TestQuestion();
        Question quest = new Question();
               
        string fName;
        int id, score, questNo;
        int[] testQuestId;
        int []answers = new int[4];

        public frmTTake()
        {
            InitializeComponent();
        }

        public frmTTake(string foreName, int id)
        {
            InitializeComponent();
            fName = foreName;
            this.id = id;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            frmMenu frmNext = new frmMenu(fName, id);

            this.Close();
            frmNext.Show();
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
            pgbTestProgress.Visible = false;
            btnTTNxQ.Visible = false;
            btnTTSubmit.Visible = false;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (cboTTLvl.Text.Equals(""))
            {
                MessageBox.Show("Please choose a test level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboTTLvl.Focus();
                return;
            }

            //Get all question id of that level store in array levelQuestIds            
            int[] levelQuestIds = quest.getLevelQuestIds(cboTTLvl.Text.Substring(0, 1));

            // CREATE TEST - store in array testQuestId      
            testQuestId = testQuest.getTestQuestions(levelQuestIds);
 
            //initialise score and questNo
            score = 0;
            questNo = 1;

            // GET NEXT QUESTION 
            quest.displayQuestion(testQuestId, questNo-1);

            // Load question details into form controls
            grpTTQ1.Text = "Question" + questNo.ToString();
            txtQText.Text = quest.getQText();    //.TrimEnd();
            txtAns1.Text = quest.getAns1();
            txtAns2.Text = quest.getAns2();
            txtAns3.Text = quest.getAns3();
            txtAns4.Text = quest.getAns4();
            //Make sure first radio button is checked  
            optOne.Checked = true;
            //Load question group box
            btnStartTest.Visible = false;
            grpTTQ1.Visible = true;
            //Load progress bar set max to represent questoins
            pgbTestProgress.Visible = true;
            pgbTestProgress.Maximum = 4;
            pgbTestProgress.Step = 1;
            //Load next question button
            btnTTNxQ.Visible = true;
        }

        private void btnTTNxQ_Click(object sender, EventArgs e)
        {
            //SAVE ANSWER
            if (optOne.Checked == true)
            {
                answers[questNo - 1] = 1;
            }
            if (optTwo.Checked == true)
            {
                answers[questNo - 1] = 2;
            }
            if (optThree.Checked == true)
            {
                answers[questNo - 1] = 3;
            }
            if (optFour.Checked == true)
            {
                answers[questNo - 1] = 4;
            }

            //CHECK ANSWER GIVEN AGAINST CORRECT ANSWER & INCREMENT SCORE                        
            if (answers[questNo - 1] == quest.getCorrectAns())
            {
                score += 25;
            }

            //INCREMENT PROGRESS BAR AND GET NEXT QUESTION
            questNo++;
            pgbTestProgress.PerformStep();
            quest.displayQuestion(testQuestId, questNo - 1);

            // Load question details into form controls
            grpTTQ1.Text = "Question" + (questNo);
            txtQText.Text = quest.getQText();    //.TrimEnd();
            txtAns1.Text = quest.getAns1();
            txtAns2.Text = quest.getAns2();
            txtAns3.Text = quest.getAns3();
            txtAns4.Text = quest.getAns4();
            //Make sure first radio button is checked  
            optOne.Checked = true;
            //Load group box
            grpTTQ1.Visible = true;
 
            if (questNo == 4)
            {
                btnTTNxQ.Visible = false;
                btnTTSubmit.Visible = true;
            }
            
        }

        private void btnTTSubmit_Click(object sender, EventArgs e)
        {
            //SAVE ANSWER
            if (optOne.Checked == true)
            {
                answers[questNo - 1] = 1;
            }
            if (optTwo.Checked == true)
            {
                answers[questNo - 1] = 2;
            }
            if (optThree.Checked == true)
            {
                answers[questNo - 1] = 3;
            }
            if (optFour.Checked == true)
            {
                answers[questNo - 1] = 4;
            }

            //Increment Progress Bar
            pgbTestProgress.PerformStep();

            //CHECK ANSWER GIVEN AGAINST CORRECT ANSWER & INCREMENT SCORE                        
            if (answers[questNo - 1] == quest.getCorrectAns())
            {
                score += 25;
            }
           
            MessageBox.Show("Your test is complete - Your score is " + score + "%", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            /*//Test what array is holding
            string toDisplay = string.Join(Environment.NewLine, answers);
            MessageBox.Show("Answers Array \n" + toDisplay);      */

            // Instantiate instance variables with values from form controls
            test.setTestId(Convert.ToInt32(txtTestId.Text));
            test.setDateTaken(string.Format("{0:dd-MMM-yy}", DateTime.Now));
            test.setTestScore(score);
            test.setStudId(id);
            test.setTLevel(cboTTLvl.Text.Substring(0,1));

            // Save Test
            test.saveTest();

            testQuest.setTestId(Convert.ToInt32(txtTestId.Text));
            testQuest.setQuestId(testQuestId);                                     
            testQuest.setAnsGiven(answers);                                      
            testQuest.saveTestQuest();

            frmMenu frmNext = new frmMenu(fName, id);

            Close();
            frmNext.Show();   
        }

        private void loadLevels()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(Db.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            string strSQL = "SELECT * FROM Levels";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            SQLiteDataReader dataReader = cmd.ExecuteReader();

            //Move data from dataReader to cboQLvls
            while (dataReader.Read())
            {
                cboTTLvl.Items.Add(dataReader.GetString(0) + " " + dataReader.GetString(1));
            }

            //Close DB connection
            myConn.Close();
        }

    }
}
