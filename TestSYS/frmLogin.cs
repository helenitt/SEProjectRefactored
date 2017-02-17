﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace TestSYS
{
    public partial class frmLogin : Form
    {
        frmWelcome parent;
        Student logStud;
        Lecturer logLec;

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
            this.Close();
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

            // CHECK IF STUDENT OR LECTURER            
            if (Convert.ToInt32(txtID.Text) < 9000)
            {
                logStud = new Student();

                if (logStud.validStudLogin((Convert.ToInt16(txtID.Text)), txtPassWord.Text))
                {
                    // get and set details
                    logStud.getStudDetails(Convert.ToInt16(txtID.Text));
                    
                    frmMenu frmNext = new frmMenu(logStud.getFName(), logStud.getStudId());

                    this.Close();
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
                logLec = new Lecturer();

                if (logLec.validLecLogin((Convert.ToInt16(txtID.Text)), txtPassWord.Text))
                {
                    // get and set details
                    logLec.getLecDetails(Convert.ToInt16(txtID.Text));                 
                    
                    frmMenu frmNext = new frmMenu(logLec.getFName(), logLec.getLecId());
                    
                    this.Close();
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
