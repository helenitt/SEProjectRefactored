namespace TestSYS
{
    partial class frmStudAdd
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
            this.btnAddSSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSAdd = new System.Windows.Forms.Label();
            this.lblAddSNm = new System.Windows.Forms.Label();
            this.txtAddSNm = new System.Windows.Forms.TextBox();
            this.txtAddFNm = new System.Windows.Forms.TextBox();
            this.lblAddSPsw = new System.Windows.Forms.Label();
            this.txtAddSPsw = new System.Windows.Forms.TextBox();
            this.lblAddForeN = new System.Windows.Forms.Label();
            this.lblConfPsw = new System.Windows.Forms.Label();
            this.txtConfPsw = new System.Windows.Forms.TextBox();
            this.lblAddDob = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblStudID = new System.Windows.Forms.Label();
            this.dtpAddDob = new System.Windows.Forms.DateTimePicker();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.mnuMenuBar.TabIndex = 15;
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
            // btnAddSSubmit
            // 
            this.btnAddSSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddSSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSSubmit.Location = new System.Drawing.Point(122, 466);
            this.btnAddSSubmit.Name = "btnAddSSubmit";
            this.btnAddSSubmit.Size = new System.Drawing.Size(225, 50);
            this.btnAddSSubmit.TabIndex = 7;
            this.btnAddSSubmit.Text = "Register";
            this.btnAddSSubmit.UseVisualStyleBackColor = false;
            this.btnAddSSubmit.Click += new System.EventHandler(this.btnAddSSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // lblSAdd
            // 
            this.lblSAdd.AutoSize = true;
            this.lblSAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAdd.Location = new System.Drawing.Point(112, 113);
            this.lblSAdd.Name = "lblSAdd";
            this.lblSAdd.Size = new System.Drawing.Size(289, 20);
            this.lblSAdd.TabIndex = 8;
            this.lblSAdd.Text = "PLEASE ENTER YOUR DETAILS:-";
            // 
            // lblAddSNm
            // 
            this.lblAddSNm.AutoSize = true;
            this.lblAddSNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSNm.Location = new System.Drawing.Point(118, 161);
            this.lblAddSNm.Name = "lblAddSNm";
            this.lblAddSNm.Size = new System.Drawing.Size(74, 20);
            this.lblAddSNm.TabIndex = 11;
            this.lblAddSNm.Text = "Surname";
            // 
            // txtAddSNm
            // 
            this.txtAddSNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSNm.Location = new System.Drawing.Point(261, 155);
            this.txtAddSNm.Name = "txtAddSNm";
            this.txtAddSNm.Size = new System.Drawing.Size(414, 26);
            this.txtAddSNm.TabIndex = 1;
            // 
            // txtAddFNm
            // 
            this.txtAddFNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFNm.Location = new System.Drawing.Point(261, 203);
            this.txtAddFNm.Name = "txtAddFNm";
            this.txtAddFNm.Size = new System.Drawing.Size(414, 26);
            this.txtAddFNm.TabIndex = 2;
            // 
            // lblAddSPsw
            // 
            this.lblAddSPsw.AutoSize = true;
            this.lblAddSPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSPsw.Location = new System.Drawing.Point(118, 380);
            this.lblAddSPsw.Name = "lblAddSPsw";
            this.lblAddSPsw.Size = new System.Drawing.Size(78, 20);
            this.lblAddSPsw.TabIndex = 15;
            this.lblAddSPsw.Text = "Password";
            // 
            // txtAddSPsw
            // 
            this.txtAddSPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSPsw.Location = new System.Drawing.Point(261, 374);
            this.txtAddSPsw.Name = "txtAddSPsw";
            this.txtAddSPsw.Size = new System.Drawing.Size(414, 26);
            this.txtAddSPsw.TabIndex = 5;
            // 
            // lblAddForeN
            // 
            this.lblAddForeN.AutoSize = true;
            this.lblAddForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddForeN.Location = new System.Drawing.Point(118, 209);
            this.lblAddForeN.Name = "lblAddForeN";
            this.lblAddForeN.Size = new System.Drawing.Size(82, 20);
            this.lblAddForeN.TabIndex = 12;
            this.lblAddForeN.Text = "Forename";
            // 
            // lblConfPsw
            // 
            this.lblConfPsw.AutoSize = true;
            this.lblConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPsw.Location = new System.Drawing.Point(118, 423);
            this.lblConfPsw.Name = "lblConfPsw";
            this.lblConfPsw.Size = new System.Drawing.Size(137, 20);
            this.lblConfPsw.TabIndex = 16;
            this.lblConfPsw.Text = "Confirm Password";
            // 
            // txtConfPsw
            // 
            this.txtConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPsw.Location = new System.Drawing.Point(261, 417);
            this.txtConfPsw.Name = "txtConfPsw";
            this.txtConfPsw.Size = new System.Drawing.Size(414, 26);
            this.txtConfPsw.TabIndex = 6;
            // 
            // lblAddDob
            // 
            this.lblAddDob.AutoSize = true;
            this.lblAddDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDob.Location = new System.Drawing.Point(118, 304);
            this.lblAddDob.Name = "lblAddDob";
            this.lblAddDob.Size = new System.Drawing.Size(99, 20);
            this.lblAddDob.TabIndex = 14;
            this.lblAddDob.Text = "Date of Birth";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmail.Location = new System.Drawing.Point(118, 257);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAddEmail.TabIndex = 13;
            this.lblAddEmail.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmail.Location = new System.Drawing.Point(261, 251);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(414, 26);
            this.txtAddEmail.TabIndex = 3;
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudID.Location = new System.Drawing.Point(418, 113);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(105, 20);
            this.lblStudID.TabIndex = 9;
            this.lblStudID.Text = "Student Id:-";
            // 
            // dtpAddDob
            // 
            this.dtpAddDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddDob.Location = new System.Drawing.Point(261, 299);
            this.dtpAddDob.Name = "dtpAddDob";
            this.dtpAddDob.Size = new System.Drawing.Size(200, 26);
            this.dtpAddDob.TabIndex = 4;
            // 
            // txtStudId
            // 
            this.txtStudId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudId.Location = new System.Drawing.Point(529, 107);
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.ReadOnly = true;
            this.txtStudId.Size = new System.Drawing.Size(138, 26);
            this.txtStudId.TabIndex = 10;
            this.txtStudId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(450, 466);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 50);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswd.Location = new System.Drawing.Point(118, 343);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(322, 20);
            this.lblPasswd.TabIndex = 19;
            this.lblPasswd.Text = "Enter and Confirm Password (Numeric  3 - 8)";
            // 
            // frmStudAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtStudId);
            this.Controls.Add(this.dtpAddDob);
            this.Controls.Add(this.lblStudID);
            this.Controls.Add(this.lblAddEmail);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.lblAddDob);
            this.Controls.Add(this.lblConfPsw);
            this.Controls.Add(this.txtConfPsw);
            this.Controls.Add(this.lblAddSPsw);
            this.Controls.Add(this.txtAddSPsw);
            this.Controls.Add(this.lblAddForeN);
            this.Controls.Add(this.txtAddFNm);
            this.Controls.Add(this.lblAddSNm);
            this.Controls.Add(this.txtAddSNm);
            this.Controls.Add(this.btnAddSSubmit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSAdd);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmStudAdd";
            this.Text = "Test System - Register Student";
            this.Load += new System.EventHandler(this.frmStudAdd_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnAddSSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSAdd;
        private System.Windows.Forms.Label lblAddSNm;
        private System.Windows.Forms.TextBox txtAddSNm;
        private System.Windows.Forms.TextBox txtAddFNm;
        private System.Windows.Forms.Label lblAddSPsw;
        private System.Windows.Forms.TextBox txtAddSPsw;
        private System.Windows.Forms.Label lblAddForeN;
        private System.Windows.Forms.Label lblConfPsw;
        private System.Windows.Forms.TextBox txtConfPsw;
        private System.Windows.Forms.Label lblAddDob;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.DateTimePicker dtpAddDob;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPasswd;
    }
}