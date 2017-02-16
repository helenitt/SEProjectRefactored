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
        frmLecMenu parent;
        Question quest = new Question();
        int questId;

        public frmQDel()
        {
            InitializeComponent();
        }

        public frmQDel(frmLecMenu Parent)
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

        private void frmQDel_Load(object sender, EventArgs e)
        {
            txtDelQID.Focus();
        }

        private void txtDelQID_TextChanged(object sender, EventArgs e)
        {
            questId = Convert.ToInt32(txtDelQID.Text);

            quest.getQuestionDetails(questId);

            txtQTxt.Text = quest.getQText();
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
        }


    }
}
