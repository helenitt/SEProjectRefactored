using System;
using System.Windows.Forms;

namespace TestSYS
{
    public partial class frmMenu : Form
    {
        Student student;
        Lecturer lecturer;
        string forename;
        int id;
        
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string foreName, int id)
        {
            // Get rid of magic number cnfig??? maxStudentUsers = 9000??? lec id 9001 -> 9999???
            InitializeComponent();
            if (id < 9000)
            {
                student = new Student();
            }
            else
            {
                lecturer = new Lecturer();
            }
            forename = foreName;
            this.id = id;
        }

        private void frmStudMenu_Load(object sender, EventArgs e)
        {
            txtName.Text = forename;
            
            //Check if student or lecturer
            if (id < 9000)
            {
                grpStudent.Visible = true;
                grpLecturer.Visible = false;
            }
            else
            {
                grpLecturer.Visible = true;
                grpStudent.Visible = false;
            }
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmTTake(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnStudProf_Click(object sender, EventArgs e)
        {
            var frmNext = new frmTProfile(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnAmdStudDet_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudAmd(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudDel(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmQAdd(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnAmdQuest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmQAmd(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnDelQuest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmQDel(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnLStudProf_Click(object sender, EventArgs e)
        {
            var frmNext = new frmTProfile(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnLAmdStud_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudAmd(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnLDelStud_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudDel(forename, id);
            Close();
            frmNext.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
