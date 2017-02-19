using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestSYS
{
    public partial class frmQAdd : Form
    {
        Question question = new Question();
        string forname;
        int lecturerId;
        
        public frmQAdd()
        {
            InitializeComponent();
        }

        public frmQAdd(string name, int id)
        {
            InitializeComponent();
            forname = name;
            lecturerId = id;
        }
        private void frmQAdd_Load(object sender, EventArgs e)
        {
            //get next question id to assign
            txtQuestId.Text = question.getNextQuestId().ToString("0000");

            loadLevels();
            optAddQ1.Checked = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            var frmNext = new frmMenu(forname, lecturerId);

            Close();
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

            // Use for loop and concatenate txtAddAns1 and i
            // Use for each loop and look at cycling through controls
            if (txtAddAns1.Text.Equals(""))
            {
                MessageBox.Show("First answer must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddAns1.Focus();
                return;
            }

            if (txtAddAns2.Text.Equals(""))
            {
                MessageBox.Show("Second answer must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                question.setCorrectAns(1);
            }
            if (optAddQ2.Checked == true)
            {
                question.setCorrectAns(2);
            }
            if (optAddQ3.Checked == true)
            {
                question.setCorrectAns(3);
            }
            if (optAddQ4.Checked == true)
            {
                question.setCorrectAns(4);
            }

            //Instantiate instance variables with values from form controls
            question.setQuestId(Convert.ToInt32(txtQuestId.Text));
            question.setQLevel(cboQLvl.Text.Substring(0,1));  //NEED TO GET FIRST LETTER
            question.setQText(txtQText.Text);
            question.setAns1(txtAddAns1.Text);
            question.setAns2(txtAddAns2.Text);
            question.setAns3(txtAddAns3.Text);
            question.setAns4(txtAddAns4.Text);
            question.setQAdd(string.Format("{0:dd-MMM-yy}", DateTime.Now));
            question.setStatus("a");

            // INSERT QUESTION IN TO DATABASE
            question.insertQuestion();

            // CONFIRMATION MESSAGE
            MessageBox.Show("Question Created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            // Clear UI
            // Extract
            txtQuestId.Text = question.getNextQuestId().ToString("0000");
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
            var frmNext = new frmMenu(forname, lecturerId);
            Close();
            frmNext.Show();
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
            var dataReader = cmd.ExecuteReader();

            //Move data from dr to cboQLvls
            while (dataReader.Read())
            {
                cboQLvl.Items.Add(dataReader.GetString(0) + " " + dataReader.GetString(1));
            }

            DbConnect.CloseDb();
        }
    }
}
