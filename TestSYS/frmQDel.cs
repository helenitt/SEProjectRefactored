using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSYS
{

    public partial class frmQDel : Form
    {
        Question quest = new Question();
        String fName;
        int questId, lecId;

        public frmQDel()
        {
            InitializeComponent();
        }

        public frmQDel(String name, int id)
        {
            InitializeComponent();
            fName = name;
            lecId = id;
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

            questId = Convert.ToInt32(txtDelQID.Text);

            //CHECK TO SEE ID IS WITHIN BOUNDS
            int count = quest.getQuestCount();

            if (questId < 1 || questId > count)
            {
                txtDelQID.Text = "";

                MessageBox.Show("Invalid Question Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDelQID.Focus();
                return;
            }

            quest.getQuestionDetails(questId);

            txtQTxt.Text = quest.getQText();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmNext = new frmMenu(fName, lecId);

            this.Close();
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

            quest.deleteQuestion(questId);

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
