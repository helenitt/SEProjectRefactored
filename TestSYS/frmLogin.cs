﻿using System;
using System.Windows.Forms;

namespace TestSYS
{
    public partial class frmLogin : Form
    {
        frmWelcome parent;  
        Student loginStudent;
        Lecturer loginLecturer;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(frmWelcome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Id must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (txtPassWord.Text.Equals(""))
            {
                MessageBox.Show("Password must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassWord.Focus();
                return;
            }

            // Get rid of magic number config??
            // CHECK IF STUDENT OR LECTURER            
            if (Convert.ToInt32(txtID.Text) < 9000)
            {
                loginStudent = new Student();

                if (loginStudent.validStudLogin((Convert.ToInt16(txtID.Text)), txtPassWord.Text))
                {
                    // get and set details
                    loginStudent.getStudDetails(Convert.ToInt16(txtID.Text));
                    
                    var frmNext = new frmMenu(loginStudent.getFName(), loginStudent.getStudId());

                    Close();
                    frmNext.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                    return;
                }
            }
            else
            {
                loginLecturer = new Lecturer();

                if (loginLecturer.validLecLogin((Convert.ToInt16(txtID.Text)), txtPassWord.Text))
                {
                    // get and set details
                    loginLecturer.getLecDetails(Convert.ToInt16(txtID.Text));                 
                    
                    var frmNext = new frmMenu(loginLecturer.getFName(), loginLecturer.getLecId());
                    
                    Close();
                    frmNext.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                    return;
                }
            }          
        }      
    }
}
