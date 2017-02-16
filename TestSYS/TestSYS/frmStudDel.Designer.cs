namespace TestSYS
{
    partial class frmStudDel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSDelete = new System.Windows.Forms.Label();
            this.lblConfPsw = new System.Windows.Forms.Label();
            this.txtConfPsw = new System.Windows.Forms.TextBox();
            this.lblAddSPsw = new System.Windows.Forms.Label();
            this.txtDelPsw = new System.Windows.Forms.TextBox();
            this.dtpDelDob = new System.Windows.Forms.DateTimePicker();
            this.lblAmendEmail = new System.Windows.Forms.Label();
            this.txtDelEmail = new System.Windows.Forms.TextBox();
            this.lblAmendDob = new System.Windows.Forms.Label();
            this.lblAmendForeN = new System.Windows.Forms.Label();
            this.txtDelFname = new System.Windows.Forms.TextBox();
            this.lblAmendSName = new System.Windows.Forms.Label();
            this.txtDelSname = new System.Windows.Forms.TextBox();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
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
            this.mnuMenuBar.TabIndex = 1;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // lblSDelete
            // 
            this.lblSDelete.AutoSize = true;
            this.lblSDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDelete.Location = new System.Drawing.Point(114, 113);
            this.lblSDelete.Name = "lblSDelete";
            this.lblSDelete.Size = new System.Drawing.Size(344, 20);
            this.lblSDelete.TabIndex = 9;
            this.lblSDelete.Text = "Deregister - Please enter and confirm password";
            // 
            // lblConfPsw
            // 
            this.lblConfPsw.AutoSize = true;
            this.lblConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPsw.Location = new System.Drawing.Point(114, 386);
            this.lblConfPsw.Name = "lblConfPsw";
            this.lblConfPsw.Size = new System.Drawing.Size(137, 20);
            this.lblConfPsw.TabIndex = 15;
            this.lblConfPsw.Text = "Confirm Password";
            // 
            // txtConfPsw
            // 
            this.txtConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPsw.Location = new System.Drawing.Point(252, 383);
            this.txtConfPsw.Name = "txtConfPsw";
            this.txtConfPsw.Size = new System.Drawing.Size(419, 26);
            this.txtConfPsw.TabIndex = 2;
            // 
            // lblAddSPsw
            // 
            this.lblAddSPsw.AutoSize = true;
            this.lblAddSPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSPsw.Location = new System.Drawing.Point(114, 340);
            this.lblAddSPsw.Name = "lblAddSPsw";
            this.lblAddSPsw.Size = new System.Drawing.Size(78, 20);
            this.lblAddSPsw.TabIndex = 14;
            this.lblAddSPsw.Text = "Password";
            // 
            // txtDelPsw
            // 
            this.txtDelPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelPsw.Location = new System.Drawing.Point(252, 337);
            this.txtDelPsw.Name = "txtDelPsw";
            this.txtDelPsw.Size = new System.Drawing.Size(419, 26);
            this.txtDelPsw.TabIndex = 1;
            // 
            // dtpDelDob
            // 
            this.dtpDelDob.Enabled = false;
            this.dtpDelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDelDob.Location = new System.Drawing.Point(252, 291);
            this.dtpDelDob.Name = "dtpDelDob";
            this.dtpDelDob.Size = new System.Drawing.Size(200, 26);
            this.dtpDelDob.TabIndex = 8;
            // 
            // lblAmendEmail
            // 
            this.lblAmendEmail.AutoSize = true;
            this.lblAmendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendEmail.Location = new System.Drawing.Point(114, 248);
            this.lblAmendEmail.Name = "lblAmendEmail";
            this.lblAmendEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAmendEmail.TabIndex = 12;
            this.lblAmendEmail.Text = "Email";
            // 
            // txtDelEmail
            // 
            this.txtDelEmail.Enabled = false;
            this.txtDelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelEmail.Location = new System.Drawing.Point(252, 245);
            this.txtDelEmail.Name = "txtDelEmail";
            this.txtDelEmail.Size = new System.Drawing.Size(419, 26);
            this.txtDelEmail.TabIndex = 7;
            // 
            // lblAmendDob
            // 
            this.lblAmendDob.AutoSize = true;
            this.lblAmendDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendDob.Location = new System.Drawing.Point(114, 296);
            this.lblAmendDob.Name = "lblAmendDob";
            this.lblAmendDob.Size = new System.Drawing.Size(99, 20);
            this.lblAmendDob.TabIndex = 13;
            this.lblAmendDob.Text = "Date of Birth";
            // 
            // lblAmendForeN
            // 
            this.lblAmendForeN.AutoSize = true;
            this.lblAmendForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendForeN.Location = new System.Drawing.Point(114, 202);
            this.lblAmendForeN.Name = "lblAmendForeN";
            this.lblAmendForeN.Size = new System.Drawing.Size(82, 20);
            this.lblAmendForeN.TabIndex = 11;
            this.lblAmendForeN.Text = "Forename";
            // 
            // txtDelFname
            // 
            this.txtDelFname.Enabled = false;
            this.txtDelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelFname.Location = new System.Drawing.Point(252, 199);
            this.txtDelFname.Name = "txtDelFname";
            this.txtDelFname.Size = new System.Drawing.Size(419, 26);
            this.txtDelFname.TabIndex = 6;
            // 
            // lblAmendSName
            // 
            this.lblAmendSName.AutoSize = true;
            this.lblAmendSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendSName.Location = new System.Drawing.Point(114, 156);
            this.lblAmendSName.Name = "lblAmendSName";
            this.lblAmendSName.Size = new System.Drawing.Size(74, 20);
            this.lblAmendSName.TabIndex = 10;
            this.lblAmendSName.Text = "Surname";
            // 
            // txtDelSname
            // 
            this.txtDelSname.Enabled = false;
            this.txtDelSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelSname.Location = new System.Drawing.Point(252, 153);
            this.txtDelSname.Name = "txtDelSname";
            this.txtDelSname.Size = new System.Drawing.Size(419, 26);
            this.txtDelSname.TabIndex = 5;
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(118, 466);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnDelStud.TabIndex = 3;
            this.btnDelStud.Text = "Delete Account";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(446, 466);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmStudDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnDelStud);
            this.Controls.Add(this.lblConfPsw);
            this.Controls.Add(this.txtConfPsw);
            this.Controls.Add(this.lblAddSPsw);
            this.Controls.Add(this.txtDelPsw);
            this.Controls.Add(this.dtpDelDob);
            this.Controls.Add(this.lblAmendEmail);
            this.Controls.Add(this.txtDelEmail);
            this.Controls.Add(this.lblAmendDob);
            this.Controls.Add(this.lblAmendForeN);
            this.Controls.Add(this.txtDelFname);
            this.Controls.Add(this.lblAmendSName);
            this.Controls.Add(this.txtDelSname);
            this.Controls.Add(this.lblSDelete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmStudDel";
            this.Text = "Test System - Delete Student";
            this.Load += new System.EventHandler(this.frmStudDel_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSDelete;
        private System.Windows.Forms.Label lblConfPsw;
        private System.Windows.Forms.TextBox txtConfPsw;
        private System.Windows.Forms.Label lblAddSPsw;
        private System.Windows.Forms.TextBox txtDelPsw;
        private System.Windows.Forms.DateTimePicker dtpDelDob;
        private System.Windows.Forms.Label lblAmendEmail;
        private System.Windows.Forms.TextBox txtDelEmail;
        private System.Windows.Forms.Label lblAmendDob;
        private System.Windows.Forms.Label lblAmendForeN;
        private System.Windows.Forms.TextBox txtDelFname;
        private System.Windows.Forms.Label lblAmendSName;
        private System.Windows.Forms.TextBox txtDelSname;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnMainMenu;
    }
}