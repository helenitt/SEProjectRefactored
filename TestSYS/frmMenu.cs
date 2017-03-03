using Shared;
using System;
using System.Windows.Forms;
using LightInject;

namespace TestSYS
{
    public partial class frmMenu : Form
    {
        Config config = new Config();
        
        private IServiceContainer _container;

        Student student;
        Lecturer lecturer;
        string forename;
        int id;
        
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(IServiceContainer contianer)
        {
            _container = contianer;
            InitializeComponent();
        }

        // I think the stuff in the one below is what will be extracted
        public frmMenu(string forename, int id)
        {
            InitializeComponent();

            var maxStudentId = Convert.ToInt32(config.MaxStudentId);
            if (id < maxStudentId)
            {
                student = new Student();
            }
            else
            {
                lecturer = new Lecturer();
            }
            this.forename = forename;
            this.id = id;
        }

        private void frmStudMenu_Load(object sender, EventArgs e)
        {
            txtName.Text = forename;

            //Check if student or lecturer
            var maxStudentId = Convert.ToInt32(config.MaxStudentId);
            if (id < maxStudentId)
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
            var frmNext = _container.GetInstance<frmTTake>();
            Close();
            frmNext.Show();
        }

        private void btnStudProf_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmTProfile>();
            Close();
            frmNext.Show();
        }

        private void btnAmdStudDet_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmStudAmd>();
            Close();
            frmNext.Show();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmStudDel>();
            Close();
            frmNext.Show();
        }

        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmQAdd>();
            Close();
            frmNext.Show();
        }

        private void btnAmdQuest_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmQAmd>();
            Close();
            frmNext.Show();
        }

        private void btnDelQuest_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmQDel>();
            Close();
            frmNext.Show();
        }

        private void btnLStudProf_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmTProfile>();
            Close();
            frmNext.Show();
        }

        private void btnLAmdStud_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmStudAmd>();
            Close();
            frmNext.Show();
        }

        private void btnLDelStud_Click(object sender, EventArgs e)
        {
            var frmNext = _container.GetInstance<frmStudDel>();
            Close();
            frmNext.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
