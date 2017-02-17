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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpStudAmd = new System.Windows.Forms.GroupBox();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblConfPsw = new System.Windows.Forms.Label();
            this.txtConfPsw = new System.Windows.Forms.TextBox();
            this.lblAddSPsw = new System.Windows.Forms.Label();
            this.txtAmdPsw = new System.Windows.Forms.TextBox();
            this.dtpAmdDob = new System.Windows.Forms.DateTimePicker();
            this.lblAmendEmail = new System.Windows.Forms.Label();
            this.txtAmdEmail = new System.Windows.Forms.TextBox();
            this.lblAmendDob = new System.Windows.Forms.Label();
            this.lblAmendForeN = new System.Windows.Forms.Label();
            this.txtAmdFname = new System.Windows.Forms.TextBox();
            this.lblAmendSName = new System.Windows.Forms.Label();
            this.txtAmdSname = new System.Windows.Forms.TextBox();
            this.btnAmdStud = new System.Windows.Forms.Button();
            this.lblSAmend = new System.Windows.Forms.Label();
            this.grpLecAmd = new System.Windows.Forms.GroupBox();
            this.btnMenuSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblStudList = new System.Windows.Forms.Label();
            this.grdStudList = new System.Windows.Forms.DataGridView();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblStudId = new System.Windows.Forms.Label();
            this.txtStudSname = new System.Windows.Forms.TextBox();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.mnuMenuBar.SuspendLayout();
            this.grpStudAmd.SuspendLayout();
            this.grpLecAmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).BeginInit();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(115, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(557, 41);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // grpStudAmd
            // 
            this.grpStudAmd.Controls.Add(this.lblPasswd);
            this.grpStudAmd.Controls.Add(this.btnMainMenu);
            this.grpStudAmd.Controls.Add(this.lblConfPsw);
            this.grpStudAmd.Controls.Add(this.txtConfPsw);
            this.grpStudAmd.Controls.Add(this.lblAddSPsw);
            this.grpStudAmd.Controls.Add(this.txtAmdPsw);
            this.grpStudAmd.Controls.Add(this.dtpAmdDob);
            this.grpStudAmd.Controls.Add(this.lblAmendEmail);
            this.grpStudAmd.Controls.Add(this.txtAmdEmail);
            this.grpStudAmd.Controls.Add(this.lblAmendDob);
            this.grpStudAmd.Controls.Add(this.lblAmendForeN);
            this.grpStudAmd.Controls.Add(this.txtAmdFname);
            this.grpStudAmd.Controls.Add(this.lblAmendSName);
            this.grpStudAmd.Controls.Add(this.txtAmdSname);
            this.grpStudAmd.Controls.Add(this.btnAmdStud);
            this.grpStudAmd.Controls.Add(this.lblSAmend);
            this.grpStudAmd.Location = new System.Drawing.Point(83, 94);
            this.grpStudAmd.Name = "grpStudAmd";
            this.grpStudAmd.Size = new System.Drawing.Size(629, 405);
            this.grpStudAmd.TabIndex = 22;
            this.grpStudAmd.TabStop = false;
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswd.Location = new System.Drawing.Point(33, 216);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(407, 20);
            this.lblPasswd.TabIndex = 53;
            this.lblPasswd.Text = "Enter and Confirm your Passwod or Reset and Confirm it";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(37, 343);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 52;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblConfPsw
            // 
            this.lblConfPsw.AutoSize = true;
            this.lblConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPsw.Location = new System.Drawing.Point(33, 290);
            this.lblConfPsw.Name = "lblConfPsw";
            this.lblConfPsw.Size = new System.Drawing.Size(137, 20);
            this.lblConfPsw.TabIndex = 51;
            this.lblConfPsw.Text = "Confirm Password";
            // 
            // txtConfPsw
            // 
            this.txtConfPsw.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPsw.Location = new System.Drawing.Point(171, 287);
            this.txtConfPsw.Name = "txtConfPsw";
            this.txtConfPsw.PasswordChar = '*';
            this.txtConfPsw.Size = new System.Drawing.Size(419, 26);
            this.txtConfPsw.TabIndex = 43;
            // 
            // lblAddSPsw
            // 
            this.lblAddSPsw.AutoSize = true;
            this.lblAddSPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSPsw.Location = new System.Drawing.Point(33, 249);
            this.lblAddSPsw.Name = "lblAddSPsw";
            this.lblAddSPsw.Size = new System.Drawing.Size(78, 20);
            this.lblAddSPsw.TabIndex = 50;
            this.lblAddSPsw.Text = "Password";
            // 
            // txtAmdPsw
            // 
            this.txtAmdPsw.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAmdPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdPsw.Location = new System.Drawing.Point(171, 246);
            this.txtAmdPsw.Name = "txtAmdPsw";
            this.txtAmdPsw.PasswordChar = '*';
            this.txtAmdPsw.Size = new System.Drawing.Size(419, 26);
            this.txtAmdPsw.TabIndex = 42;
            // 
            // dtpAmdDob
            // 
            this.dtpAmdDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAmdDob.Location = new System.Drawing.Point(171, 171);
            this.dtpAmdDob.Name = "dtpAmdDob";
            this.dtpAmdDob.Size = new System.Drawing.Size(200, 26);
            this.dtpAmdDob.TabIndex = 41;
            // 
            // lblAmendEmail
            // 
            this.lblAmendEmail.AutoSize = true;
            this.lblAmendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendEmail.Location = new System.Drawing.Point(33, 131);
            this.lblAmendEmail.Name = "lblAmendEmail";
            this.lblAmendEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAmendEmail.TabIndex = 48;
            this.lblAmendEmail.Text = "Email";
            // 
            // txtAmdEmail
            // 
            this.txtAmdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdEmail.Location = new System.Drawing.Point(171, 128);
            this.txtAmdEmail.Name = "txtAmdEmail";
            this.txtAmdEmail.Size = new System.Drawing.Size(419, 26);
            this.txtAmdEmail.TabIndex = 40;
            // 
            // lblAmendDob
            // 
            this.lblAmendDob.AutoSize = true;
            this.lblAmendDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendDob.Location = new System.Drawing.Point(33, 176);
            this.lblAmendDob.Name = "lblAmendDob";
            this.lblAmendDob.Size = new System.Drawing.Size(99, 20);
            this.lblAmendDob.TabIndex = 49;
            this.lblAmendDob.Text = "Date of Birth";
            // 
            // lblAmendForeN
            // 
            this.lblAmendForeN.AutoSize = true;
            this.lblAmendForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendForeN.Location = new System.Drawing.Point(33, 90);
            this.lblAmendForeN.Name = "lblAmendForeN";
            this.lblAmendForeN.Size = new System.Drawing.Size(82, 20);
            this.lblAmendForeN.TabIndex = 47;
            this.lblAmendForeN.Text = "Forename";
            // 
            // txtAmdFname
            // 
            this.txtAmdFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdFname.Location = new System.Drawing.Point(171, 87);
            this.txtAmdFname.Name = "txtAmdFname";
            this.txtAmdFname.Size = new System.Drawing.Size(419, 26);
            this.txtAmdFname.TabIndex = 39;
            // 
            // lblAmendSName
            // 
            this.lblAmendSName.AutoSize = true;
            this.lblAmendSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendSName.Location = new System.Drawing.Point(33, 50);
            this.lblAmendSName.Name = "lblAmendSName";
            this.lblAmendSName.Size = new System.Drawing.Size(74, 20);
            this.lblAmendSName.TabIndex = 46;
            this.lblAmendSName.Text = "Surname";
            // 
            // txtAmdSname
            // 
            this.txtAmdSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdSname.Location = new System.Drawing.Point(171, 47);
            this.txtAmdSname.Name = "txtAmdSname";
            this.txtAmdSname.Size = new System.Drawing.Size(419, 26);
            this.txtAmdSname.TabIndex = 38;
            // 
            // btnAmdStud
            // 
            this.btnAmdStud.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAmdStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmdStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdStud.Location = new System.Drawing.Point(365, 343);
            this.btnAmdStud.Name = "btnAmdStud";
            this.btnAmdStud.Size = new System.Drawing.Size(225, 50);
            this.btnAmdStud.TabIndex = 44;
            this.btnAmdStud.Text = "Amend";
            this.btnAmdStud.UseVisualStyleBackColor = false;
            this.btnAmdStud.Click += new System.EventHandler(this.btnAmdStud_Click);
            // 
            // lblSAmend
            // 
            this.lblSAmend.AutoSize = true;
            this.lblSAmend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAmend.Location = new System.Drawing.Point(33, 17);
            this.lblSAmend.Name = "lblSAmend";
            this.lblSAmend.Size = new System.Drawing.Size(254, 20);
            this.lblSAmend.TabIndex = 45;
            this.lblSAmend.Text = "Please Amend Student Details";
            // 
            // grpLecAmd
            // 
            this.grpLecAmd.Controls.Add(this.btnMenuSearch);
            this.grpLecAmd.Controls.Add(this.btnSelect);
            this.grpLecAmd.Controls.Add(this.lblStudList);
            this.grpLecAmd.Controls.Add(this.grdStudList);
            this.grpLecAmd.Controls.Add(this.lblSname);
            this.grpLecAmd.Controls.Add(this.lblStudId);
            this.grpLecAmd.Controls.Add(this.txtStudSname);
            this.grpLecAmd.Controls.Add(this.txtStudId);
            this.grpLecAmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLecAmd.Location = new System.Drawing.Point(88, 94);
            this.grpLecAmd.Name = "grpLecAmd";
            this.grpLecAmd.Size = new System.Drawing.Size(617, 405);
            this.grpLecAmd.TabIndex = 43;
            this.grpLecAmd.TabStop = false;
            this.grpLecAmd.Text = "Search Student by";
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSearch.Location = new System.Drawing.Point(34, 344);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Size = new System.Drawing.Size(225, 50);
            this.btnMenuSearch.TabIndex = 53;
            this.btnMenuSearch.Text = "Main Menu";
            this.btnMenuSearch.UseVisualStyleBackColor = false;
            this.btnMenuSearch.Click += new System.EventHandler(this.btnMenuSearch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(357, 343);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(225, 50);
            this.btnSelect.TabIndex = 44;
            this.btnSelect.Text = "Select Student";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblStudList
            // 
            this.lblStudList.AutoSize = true;
            this.lblStudList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudList.Location = new System.Drawing.Point(21, 93);
            this.lblStudList.Name = "lblStudList";
            this.lblStudList.Size = new System.Drawing.Size(123, 20);
            this.lblStudList.TabIndex = 43;
            this.lblStudList.Text = "  Select Student";
            // 
            // grdStudList
            // 
            this.grdStudList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdStudList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudList.GridColor = System.Drawing.SystemColors.Menu;
            this.grdStudList.Location = new System.Drawing.Point(34, 118);
            this.grdStudList.Name = "grdStudList";
            this.grdStudList.Size = new System.Drawing.Size(548, 195);
            this.grdStudList.TabIndex = 42;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(248, 42);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(74, 20);
            this.lblSname.TabIndex = 9;
            this.lblSname.Text = "Surname";
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(30, 42);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(84, 20);
            this.lblStudId.TabIndex = 8;
            this.lblStudId.Text = "Student Id";
            // 
            // txtStudSname
            // 
            this.txtStudSname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStudSname.Location = new System.Drawing.Point(335, 39);
            this.txtStudSname.Name = "txtStudSname";
            this.txtStudSname.Size = new System.Drawing.Size(247, 26);
            this.txtStudSname.TabIndex = 7;
            this.txtStudSname.TextChanged += new System.EventHandler(this.txtStudSname_TextChanged);
            // 
            // txtStudId
            // 
            this.txtStudId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStudId.Location = new System.Drawing.Point(140, 39);
            this.txtStudId.MaxLength = 8;
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.Size = new System.Drawing.Size(81, 26);
            this.txtStudId.TabIndex = 6;
            this.txtStudId.TextChanged += new System.EventHandler(this.txtStudId_TextChanged);
            // 
            // frmStudAmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::TestSYS.Properties.Resources.bgd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpLecAmd);
            this.Controls.Add(this.grpStudAmd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmStudAmd";
            this.Text = "Test System - Amend Student";
            this.Load += new System.EventHandler(this.frmStudAmd_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.grpStudAmd.ResumeLayout(false);
            this.grpStudAmd.PerformLayout();
            this.grpLecAmd.ResumeLayout(false);
            this.grpLecAmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStudAmd;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblAddSPsw;
        private System.Windows.Forms.TextBox txtAmdPsw;
        private System.Windows.Forms.DateTimePicker dtpAmdDob;
        private System.Windows.Forms.Label lblAmendEmail;
        private System.Windows.Forms.TextBox txtAmdEmail;
        private System.Windows.Forms.Label lblAmendDob;
        private System.Windows.Forms.Label lblAmendForeN;
        private System.Windows.Forms.TextBox txtAmdFname;
        private System.Windows.Forms.Label lblAmendSName;
        private System.Windows.Forms.TextBox txtAmdSname;
        private System.Windows.Forms.Button btnAmdStud;
        private System.Windows.Forms.Label lblSAmend;
        private System.Windows.Forms.GroupBox grpLecAmd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblStudList;
        private System.Windows.Forms.DataGridView grdStudList;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.TextBox txtStudSname;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Button btnMenuSearch;
        private System.Windows.Forms.Label lblConfPsw;
        private System.Windows.Forms.TextBox txtConfPsw;
    }
}