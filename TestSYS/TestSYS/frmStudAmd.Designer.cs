namespace TestSYS
{
    partial class frmStudAmd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAmendEmail = new System.Windows.Forms.Label();
            this.txtAmdEmail = new System.Windows.Forms.TextBox();
            this.lblAmendDob = new System.Windows.Forms.Label();
            this.lblAmendForeN = new System.Windows.Forms.Label();
            this.txtAmdFname = new System.Windows.Forms.TextBox();
            this.lblAmendSName = new System.Windows.Forms.Label();
            this.txtAmdSname = new System.Windows.Forms.TextBox();
            this.btnAmdStud = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSAmend = new System.Windows.Forms.Label();
            this.dtpAmdDob = new System.Windows.Forms.DateTimePicker();
            this.lblConfPsw = new System.Windows.Forms.Label();
            this.txtConfPsw = new System.Windows.Forms.TextBox();
            this.lblAddSPsw = new System.Windows.Forms.Label();
            this.txtAmdPsw = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.mnuMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.quitToolStripMenuItem});
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Size = new System.Drawing.Size(784, 27);
            this.mnuMenuBar.TabIndex = 16;
            this.mnuMenuBar.Text = "menuBar";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(49, 23);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // lblAmendEmail
            // 
            this.lblAmendEmail.AutoSize = true;
            this.lblAmendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendEmail.Location = new System.Drawing.Point(114, 251);
            this.lblAmendEmail.Name = "lblAmendEmail";
            this.lblAmendEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAmendEmail.TabIndex = 11;
            this.lblAmendEmail.Text = "Email";
            // 
            // txtAmdEmail
            // 
            this.txtAmdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdEmail.Location = new System.Drawing.Point(252, 248);
            this.txtAmdEmail.Name = "txtAmdEmail";
            this.txtAmdEmail.Size = new System.Drawing.Size(419, 26);
            this.txtAmdEmail.TabIndex = 3;
            // 
            // lblAmendDob
            // 
            this.lblAmendDob.AutoSize = true;
            this.lblAmendDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendDob.Location = new System.Drawing.Point(114, 299);
            this.lblAmendDob.Name = "lblAmendDob";
            this.lblAmendDob.Size = new System.Drawing.Size(99, 20);
            this.lblAmendDob.TabIndex = 12;
            this.lblAmendDob.Text = "Date of Birth";
            // 
            // lblAmendForeN
            // 
            this.lblAmendForeN.AutoSize = true;
            this.lblAmendForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendForeN.Location = new System.Drawing.Point(114, 205);
            this.lblAmendForeN.Name = "lblAmendForeN";
            this.lblAmendForeN.Size = new System.Drawing.Size(82, 20);
            this.lblAmendForeN.TabIndex = 10;
            this.lblAmendForeN.Text = "Forename";
            // 
            // txtAmdFname
            // 
            this.txtAmdFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdFname.Location = new System.Drawing.Point(252, 202);
            this.txtAmdFname.Name = "txtAmdFname";
            this.txtAmdFname.Size = new System.Drawing.Size(419, 26);
            this.txtAmdFname.TabIndex = 2;
            // 
            // lblAmendSName
            // 
            this.lblAmendSName.AutoSize = true;
            this.lblAmendSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendSName.Location = new System.Drawing.Point(114, 159);
            this.lblAmendSName.Name = "lblAmendSName";
            this.lblAmendSName.Size = new System.Drawing.Size(74, 20);
            this.lblAmendSName.TabIndex = 9;
            this.lblAmendSName.Text = "Surname";
            // 
            // txtAmdSname
            // 
            this.txtAmdSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdSname.Location = new System.Drawing.Point(252, 156);
            this.txtAmdSname.Name = "txtAmdSname";
            this.txtAmdSname.Size = new System.Drawing.Size(419, 26);
            this.txtAmdSname.TabIndex = 1;
            // 
            // btnAmdStud
            // 
            this.btnAmdStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmdStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdStud.Location = new System.Drawing.Point(118, 466);
            this.btnAmdStud.Name = "btnAmdStud";
            this.btnAmdStud.Size = new System.Drawing.Size(225, 50);
            this.btnAmdStud.TabIndex = 7;
            this.btnAmdStud.Text = "AMEND";
            this.btnAmdStud.UseVisualStyleBackColor = false;
            this.btnAmdStud.Click += new System.EventHandler(this.btnAmdStud_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // lblSAmend
            // 
            this.lblSAmend.AutoSize = true;
            this.lblSAmend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAmend.Location = new System.Drawing.Point(114, 113);
            this.lblSAmend.Name = "lblSAmend";
            this.lblSAmend.Size = new System.Drawing.Size(226, 20);
            this.lblSAmend.TabIndex = 8;
            this.lblSAmend.Text = "Please Amend Student Details";
            // 
            // dtpAmdDob
            // 
            this.dtpAmdDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAmdDob.Location = new System.Drawing.Point(252, 294);
            this.dtpAmdDob.Name = "dtpAmdDob";
            this.dtpAmdDob.Size = new System.Drawing.Size(200, 26);
            this.dtpAmdDob.TabIndex = 4;
            // 
            // lblConfPsw
            // 
            this.lblConfPsw.AutoSize = true;
            this.lblConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPsw.Location = new System.Drawing.Point(114, 421);
            this.lblConfPsw.Name = "lblConfPsw";
            this.lblConfPsw.Size = new System.Drawing.Size(137, 20);
            this.lblConfPsw.TabIndex = 14;
            this.lblConfPsw.Text = "Confirm Password";
            // 
            // txtConfPsw
            // 
            this.txtConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPsw.Location = new System.Drawing.Point(252, 418);
            this.txtConfPsw.Name = "txtConfPsw";
            this.txtConfPsw.Size = new System.Drawing.Size(419, 26);
            this.txtConfPsw.TabIndex = 6;
            // 
            // lblAddSPsw
            // 
            this.lblAddSPsw.AutoSize = true;
            this.lblAddSPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSPsw.Location = new System.Drawing.Point(114, 375);
            this.lblAddSPsw.Name = "lblAddSPsw";
            this.lblAddSPsw.Size = new System.Drawing.Size(78, 20);
            this.lblAddSPsw.TabIndex = 13;
            this.lblAddSPsw.Text = "Password";
            // 
            // txtAmdPsw
            // 
            this.txtAmdPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdPsw.Location = new System.Drawing.Point(252, 372);
            this.txtAmdPsw.Name = "txtAmdPsw";
            this.txtAmdPsw.Size = new System.Drawing.Size(419, 26);
            this.txtAmdPsw.TabIndex = 5;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(446, 466);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswd.Location = new System.Drawing.Point(114, 342);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(407, 20);
            this.lblPasswd.TabIndex = 20;
            this.lblPasswd.Text = "Enter and Confirm your Passwod or Reset and Confirm it";
            // 
            // frmStudAmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblConfPsw);
            this.Controls.Add(this.txtConfPsw);
            this.Controls.Add(this.lblAddSPsw);
            this.Controls.Add(this.txtAmdPsw);
            this.Controls.Add(this.dtpAmdDob);
            this.Controls.Add(this.lblAmendEmail);
            this.Controls.Add(this.txtAmdEmail);
            this.Controls.Add(this.lblAmendDob);
            this.Controls.Add(this.lblAmendForeN);
            this.Controls.Add(this.txtAmdFname);
            this.Controls.Add(this.lblAmendSName);
            this.Controls.Add(this.txtAmdSname);
            this.Controls.Add(this.btnAmdStud);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSAmend);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmStudAmd";
            this.Text = "Test System - Amend Student";
            this.Load += new System.EventHandler(this.frmStudAmd_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblAmendEmail;
        private System.Windows.Forms.TextBox txtAmdEmail;
        private System.Windows.Forms.Label lblAmendDob;
        private System.Windows.Forms.Label lblAmendForeN;
        private System.Windows.Forms.TextBox txtAmdFname;
        private System.Windows.Forms.Label lblAmendSName;
        private System.Windows.Forms.TextBox txtAmdSname;
        private System.Windows.Forms.Button btnAmdStud;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSAmend;
        private System.Windows.Forms.DateTimePicker dtpAmdDob;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblConfPsw;
        private System.Windows.Forms.TextBox txtConfPsw;
        private System.Windows.Forms.Label lblAddSPsw;
        private System.Windows.Forms.TextBox txtAmdPsw;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblPasswd;
    }
}