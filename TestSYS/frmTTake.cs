using System;
using System.Windows.Forms;
using System.Data.SQLite;
using LightInject;

namespace TestSYS
{
    public partial class frmTTake : Form
    {
        private IServiceContainer _container;

        Test test = new Test();
        TestQuestion testQuestion = new TestQuestion();
        Question question = new Question();
               
        string forename;
        int id;
        int score;
        int questionNumber;
        int[] testQuestId;
        int[] answers = new int[4];

        public frmTTake()
        {
            InitializeComponent();
        }

        public frmTTake(IServiceContainer container)
        {
            _container = container;
            InitializeComponent();
        }

        public frmTTake(string forename, int id)
        {
            InitializeComponent();
            this.forename = forename;
            this.id = id;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmMenu>();
            Close();
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
            txtName.Text = forename;
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
            int[] levelQuestIds = question.getLevelQuestIds(cboTTLvl.Text.Substring(0, 1));

            // CREATE TEST - store in array testQuestId      
            testQuestId = testQuestion.getTestQuestions(levelQuestIds);
 
            //initialise score and questNo
            score = 0;
            questionNumber = 1;

            // GET NEXT QUESTION 
            question.displayQuestion(testQuestId, questionNumber-1);

            // Load question details into form controls
            grpTTQ1.Text = "Question" + questionNumber.ToString();
            txtQText.Text = question.getQText();    //.TrimEnd();
            txtAns1.Text = question.getAns1();
            txtAns2.Text = question.getAns2();
            txtAns3.Text = question.getAns3();
            txtAns4.Text = question.getAns4();
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
                answers[questionNumber - 1] = 1;
            }
            if (optTwo.Checked == true)
            {
                answers[questionNumber - 1] = 2;
            }
            if (optThree.Checked == true)
            {
                answers[questionNumber - 1] = 3;
            }
            if (optFour.Checked == true)
            {
                answers[questionNumber - 1] = 4;
            }

            //CHECK ANSWER GIVEN AGAINST CORRECT ANSWER & INCREMENT SCORE                        
            if (answers[questionNumber - 1] == question.getCorrectAns())
            {
                score += 25;
            }

            //INCREMENT PROGRESS BAR AND GET NEXT QUESTION
            questionNumber++;
            pgbTestProgress.PerformStep();
            question.displayQuestion(testQuestId, questionNumber - 1);

            // Load question details into form controls
            grpTTQ1.Text = "Question" + (questionNumber);
            txtQText.Text = question.getQText();    //.TrimEnd();
            txtAns1.Text = question.getAns1();
            txtAns2.Text = question.getAns2();
            txtAns3.Text = question.getAns3();
            txtAns4.Text = question.getAns4();
            //Make sure first radio button is checked  
            optOne.Checked = true;
            //Load group box
            grpTTQ1.Visible = true;
 
            if (questionNumber == 4)
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
                answers[questionNumber - 1] = 1;
            }
            if (optTwo.Checked == true)
            {
                answers[questionNumber - 1] = 2;
            }
            if (optThree.Checked == true)
            {
                answers[questionNumber - 1] = 3;
            }
            if (optFour.Checked == true)
            {
                answers[questionNumber - 1] = 4;
            }

            //Increment Progress Bar
            pgbTestProgress.PerformStep();

            //CHECK ANSWER GIVEN AGAINST CORRECT ANSWER & INCREMENT SCORE                        
            if (answers[questionNumber - 1] == question.getCorrectAns())
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

            testQuestion.setTestId(Convert.ToInt32(txtTestId.Text));
            testQuestion.setQuestId(testQuestId);                                     
            testQuestion.setAnsGiven(answers);                                      
            testQuestion.saveTestQuest();

            var frmNext = _container.GetInstance<frmMenu>();
            Close();
            frmNext.Show();   
        }

        private void loadLevels()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(DbSetup.ConnectionString);

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

            DbConnect.CloseDb();
        }
    }
}
