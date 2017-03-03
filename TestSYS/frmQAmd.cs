using System;
using System.Windows.Forms;
using System.Data.SQLite;
using LightInject;

namespace TestSYS
{
    public partial class frmQAmd : Form
    {
        private IServiceContainer _container;

        Question question = new Question();
        string forename;
        int questionId;
        int lecturerId;

        public frmQAmd()
        {
            InitializeComponent();
        }

        public frmQAmd(IServiceContainer container)
        {
            _container = container;
            InitializeComponent();
        }

        // Instead of
        public frmQAmd(string name, int id)
        {
            InitializeComponent();
            forename = name;
            lecturerId = id;
        }

        private void frmQAmd_Load(object sender, EventArgs e)
        {
            txtAmdQID.Focus();
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

        private void txtAmdQID_TextChanged(object sender, EventArgs e)
        {
            if (txtAmdQID.Text == "")
            {
                txtAmdQID.Focus();
                cboQLvl.SelectedIndex = -1;
                cboQLvl.Items.Clear();
                txtQText.Text = "";
                optAmd1.Checked = true;
                txtAmdAns1.Text = "";
                txtAmdAns2.Text = "";
                txtAmdAns3.Text = "";
                txtAmdAns4.Text = "";
                return;
            }

            questionId = Convert.ToInt32(txtAmdQID.Text);   

            //CHECK TO SEE ID IS WITHIN BOUNDS
            int count = question.getQuestCount();

            if (questionId < 1 || questionId > count)
            {
                txtAmdQID.Text= "";

                MessageBox.Show("Invalid Question Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtAmdQID.Focus();
                return;
            }

            question.getQuestionDetails(questionId);

            // Load question details into form controls
            loadLevels();
            
            txtQText.Text = question.getQText().TrimEnd();

            //Make sure first radio button is checked          
            optAmd1.Checked = true;
            
            txtAmdAns1.Text = question.getAns1().TrimEnd();
            txtAmdAns2.Text = question.getAns2().TrimEnd();
            txtAmdAns3.Text = question.getAns3().TrimEnd();
            txtAmdAns4.Text = question.getAns4().TrimEnd();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmMenu>();
            Close();
            frmNext.Show();
        }

        private void btnAmdSubmit_Click(object sender, EventArgs e)
        {
            string amdDate = (string.Format("{0:dd-MMM-yy}", DateTime.Now));

            // Instantiate instance variables with updated values from form controls
            question.setQLevel(cboQLvl.Text.Substring(0, 1));
            question.setQText(txtQText.Text);
            question.setAns1(txtAmdAns1.Text);
            question.setAns2(txtAmdAns2.Text);
            question.setAns3(txtAmdAns3.Text);
            question.setAns4(txtAmdAns4.Text);

            //Set the correct answer, radio button 1, 2,3 or 4
            if (optAmd1.Checked == true)
            {
                question.setCorrectAns(1);
            }
            if (optAmd2.Checked == true)
            {
                question.setCorrectAns(2);
            }
            if (optAmd3.Checked == true)
            {
                question.setCorrectAns(3);
            }
            if (optAmd4.Checked == true)
            {
                question.setCorrectAns(4);
            }                                       
            question.setQAmd(string.Format("{0:dd-MMM-yy}", DateTime.Now));

            // INSERT QUESTION IN TO DATABASE
            try
            {
                question.updateQuestion();

                // CONFIRMATION MESSAGE
                MessageBox.Show("Question Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            catch 
            {
                MessageBox.Show("An Error has Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Extract
            // Clear UI
            txtAmdQID.Text = "";
            txtAmdQID.Focus();
            cboQLvl.SelectedIndex = -1;
            cboQLvl.Items.Clear();
            txtQText.Text = "";
            optAmd1.Checked = false;
            optAmd2.Checked = false;
            optAmd3.Checked = false;
            optAmd4.Checked = false;
            txtAmdAns1.Text = "";
            txtAmdAns2.Text = "";
            txtAmdAns3.Text = "";
            txtAmdAns4.Text = "";
        }

        public void loadLevels()
        {
            //Create Database connection string
            var myConn = new SQLiteConnection(DbSetup.ConnectionString);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);

            //Define SDQL query which retrieves MAX QuestId in Questions
            string strSQL = "SELECT * FROM Levels";

            //Define Oracle Command
            var cmd = new SQLiteCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //Exectute SQL command
            //OracleDataReader dr = cmd.ExecuteReader();
            SQLiteDataReader dr = cmd.ExecuteReader();

            //Move data from dr to cboQLvls
            while (dr.Read())
            {
                cboQLvl.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }

            DbConnect.CloseDb();
        }
    }
}
