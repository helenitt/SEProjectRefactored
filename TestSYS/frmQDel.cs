using System;
using System.Windows.Forms;
using TestSYS.LightInject;

namespace TestSYS
{

    public partial class frmQDel : Form
    {
        private IServiceContainer _container;

        Question question = new Question();
        string forename;
        int questionId;
        int lecturerId;

        public frmQDel()
        {
            InitializeComponent();
        }

        public frmQDel(IServiceContainer container)
        {
            _container = container;
            InitializeComponent();
        }

        public frmQDel(string name, int id)
        {
            InitializeComponent();
            forename = name;
            lecturerId = id;
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

        private void frmQDel_Load(object sender, EventArgs e)
        {
            txtDelQID.Focus();
        }

        private void txtDelQID_TextChanged(object sender, EventArgs e)
        {
            if (txtDelQID.Text == "")
            {
                txtDelQID.Focus();
                txtQTxt.Text = "";
                return;
            }

            questionId = Convert.ToInt32(txtDelQID.Text);

            //CHECK TO SEE ID IS WITHIN BOUNDS
            int count = question.getQuestCount();

            if (questionId < 1 || questionId > count)
            {
                txtDelQID.Text = "";

                MessageBox.Show("Invalid Question Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDelQID.Focus();
                return;
            }

            question.getQuestionDetails(questionId);

            txtQTxt.Text = question.getQText();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmMenu>();
            Close();
            frmNext.Show();
        }

        private void btnDelQ_Click(object sender, EventArgs e)
        {
            if (txtDelPwd.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDelPwd.Focus();
                return;
            }
            if (txtConfPwd.Text.Equals(""))
            {
                MessageBox.Show("Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPwd.Focus();
                return;
            }
            // Validate Passwords match
            if (!txtDelPwd.Text.Equals(txtConfPwd.Text))
            {
                MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfPwd.Focus();
                return;
            }

            MessageBox.Show("Are you sure you want to delete this question\n\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            question.deleteQuestion(questionId);

            // CONFIRMATION MESSAGE
            MessageBox.Show("Question Deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear UI
            txtDelQID.Focus();
            txtQTxt.Text = "";
            txtDelPwd.Text = "";
            txtConfPwd.Text = "";

            return;
        }
    }
}
