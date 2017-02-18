using System;
using System.Windows.Forms;

namespace TestSYS
{
    public partial class frmMenu : Form
    {
        Student stud;
        Lecturer lec;
        string fName;
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
                stud = new Student();
            }
            else
            {
                lec = new Lecturer();
            }
            fName = foreName;
            this.id = id;
        }

        private void frmStudMenu_Load(object sender, EventArgs e)
        {
            txtName.Text = fName;
            
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
            var frmNext = new frmTTake(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnStudProf_Click(object sender, EventArgs e)
        {
            var frmNext = new frmTProfile(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnAmdStudDet_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudAmd(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudDel(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmQAdd(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnAmdQuest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmQAmd(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnDelQuest_Click(object sender, EventArgs e)
        {
            var frmNext = new frmQDel(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnLStudProf_Click(object sender, EventArgs e)
        {
            var frmNext = new frmTProfile(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnLAmdStud_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudAmd(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnLDelStud_Click(object sender, EventArgs e)
        {
            var frmNext = new frmStudDel(fName, id);
            Close();
            frmNext.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
