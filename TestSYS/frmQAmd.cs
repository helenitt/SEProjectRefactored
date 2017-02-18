using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSYS
{
    public partial class frmQAmd : Form
    {
        Question quest = new Question();
        string fName;
        int questId, lecId;

        public frmQAmd()
        {
            InitializeComponent();
        }

        public frmQAmd(string name, int id)
        {
            InitializeComponent();
            fName = name;
            lecId = id;
        }

        private void frmQAmd_Load(object sender, EventArgs e)
        {
            txtAmdQID.Focus();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(fName, lecId);
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

            questId = Convert.ToInt32(txtAmdQID.Text);   

            //CHECK TO SEE ID IS WITHIN BOUNDS
            int count = quest.getQuestCount();

            if (questId < 1 || questId > count)
            {
                txtAmdQID.Text= "";

                MessageBox.Show("Invalid Question Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtAmdQID.Focus();
                return;
            }

            quest.getQuestionDetails(questId);

            // Load question details into form controls
            loadLevels();
            
            txtQText.Text = quest.getQText().TrimEnd();

            //Make sure first radio button is checked          
            optAmd1.Checked = true;
            
            txtAmdAns1.Text = quest.getAns1().TrimEnd();
            txtAmdAns2.Text = quest.getAns2().TrimEnd();
            txtAmdAns3.Text = quest.getAns3().TrimEnd();
            txtAmdAns4.Text = quest.getAns4().TrimEnd();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(fName, lecId);
            Close();
            frmNext.Show();
        }

        private void btnAmdSubmit_Click(object sender, EventArgs e)
        {
            string amdDate = (string.Format("{0:dd-MMM-yy}", DateTime.Now));

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
            quest.setQAmd(string.Format("{0:dd-MMM-yy}", DateTime.Now));

            // INSERT QUESTION IN TO DATABASE
            try
            {
                quest.updateQuestion();

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
            var myConn = new SQLiteConnection(Db.ConnectionString);
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

            //Close DB connection
            myConn.Close();
        }
    }
}
