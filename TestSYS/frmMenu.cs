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
    public partial class frmMenu : Form
    {
        Student stud;
        Lecturer lec;
        String fName;
        int id;
        
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(String foreName, int id)
        {
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
            frmTTake frmNext = new frmTTake(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudProf_Click(object sender, EventArgs e)
        {
            frmTProfile frmNext = new frmTProfile(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnAmdStudDet_Click(object sender, EventArgs e)
        {
            frmStudAmd frmNext = new frmStudAmd(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            frmStudDel frmNext = new frmStudDel(fName, id);

            this.Close();
            frmNext.Show();
        }


        private void btnAddQuest_Click(object sender, EventArgs e)
        {
            frmQAdd frmNext = new frmQAdd(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnAmdQuest_Click(object sender, EventArgs e)
        {
            frmQAmd frmNext = new frmQAmd(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnDelQuest_Click(object sender, EventArgs e)
        {
            frmQDel frmNext = new frmQDel(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnLStudProf_Click(object sender, EventArgs e)
        {
            frmTProfile frmNext = new frmTProfile(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnLAmdStud_Click(object sender, EventArgs e)
        {
            frmStudAmd frmNext = new frmStudAmd(fName, id);

            this.Close();
            frmNext.Show();
        }

        private void btnLDelStud_Click(object sender, EventArgs e)
        {
            frmStudDel frmNext = new frmStudDel(fName, id);

            this.Close();
            frmNext.Show();
        }

    }
}
