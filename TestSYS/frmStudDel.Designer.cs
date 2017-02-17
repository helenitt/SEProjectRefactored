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
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpStudDel = new System.Windows.Forms.GroupBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
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
            this.lblSDelete = new System.Windows.Forms.Label();
            this.grpLecDel = new System.Windows.Forms.GroupBox();
            this.btnMenuSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblStudList = new System.Windows.Forms.Label();
            this.grdStudList = new System.Windows.Forms.DataGridView();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblStudId = new System.Windows.Forms.Label();
            this.txtStudSname = new System.Windows.Forms.TextBox();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.mnuMenuBar.SuspendLayout();
            this.grpStudDel.SuspendLayout();
            this.grpLecDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuQuit});
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
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(48, 23);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
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
            // grpStudDel
            // 
            this.grpStudDel.Controls.Add(this.btnMainMenu);
            this.grpStudDel.Controls.Add(this.btnDelStud);
            this.grpStudDel.Controls.Add(this.lblConfPsw);
            this.grpStudDel.Controls.Add(this.txtConfPsw);
            this.grpStudDel.Controls.Add(this.lblAddSPsw);
            this.grpStudDel.Controls.Add(this.txtDelPsw);
            this.grpStudDel.Controls.Add(this.dtpDelDob);
            this.grpStudDel.Controls.Add(this.lblAmendEmail);
            this.grpStudDel.Controls.Add(this.txtDelEmail);
            this.grpStudDel.Controls.Add(this.lblAmendDob);
            this.grpStudDel.Controls.Add(this.lblAmendForeN);
            this.grpStudDel.Controls.Add(this.txtDelFname);
            this.grpStudDel.Controls.Add(this.lblAmendSName);
            this.grpStudDel.Controls.Add(this.txtDelSname);
            this.grpStudDel.Controls.Add(this.lblSDelete);
            this.grpStudDel.Location = new System.Drawing.Point(82, 94);
            this.grpStudDel.Name = "grpStudDel";
            this.grpStudDel.Size = new System.Drawing.Size(624, 405);
            this.grpStudDel.TabIndex = 22;
            this.grpStudDel.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(38, 343);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(365, 343);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnDelStud.TabIndex = 18;
            this.btnDelStud.Text = "Delete Account";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // lblConfPsw
            // 
            this.lblConfPsw.AutoSize = true;
            this.lblConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPsw.Location = new System.Drawing.Point(34, 290);
            this.lblConfPsw.Name = "lblConfPsw";
            this.lblConfPsw.Size = new System.Drawing.Size(137, 20);
            this.lblConfPsw.TabIndex = 30;
            this.lblConfPsw.Text = "Confirm Password";
            // 
            // txtConfPsw
            // 
            this.txtConfPsw.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPsw.Location = new System.Drawing.Point(172, 287);
            this.txtConfPsw.Name = "txtConfPsw";
            this.txtConfPsw.PasswordChar = '*';
            this.txtConfPsw.Size = new System.Drawing.Size(419, 26);
            this.txtConfPsw.TabIndex = 17;
            // 
            // lblAddSPsw
            // 
            this.lblAddSPsw.AutoSize = true;
            this.lblAddSPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSPsw.Location = new System.Drawing.Point(34, 244);
            this.lblAddSPsw.Name = "lblAddSPsw";
            this.lblAddSPsw.Size = new System.Drawing.Size(78, 20);
            this.lblAddSPsw.TabIndex = 29;
            this.lblAddSPsw.Text = "Password";
            // 
            // txtDelPsw
            // 
            this.txtDelPsw.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelPsw.Location = new System.Drawing.Point(172, 241);
            this.txtDelPsw.Name = "txtDelPsw";
            this.txtDelPsw.PasswordChar = '*';
            this.txtDelPsw.Size = new System.Drawing.Size(419, 26);
            this.txtDelPsw.TabIndex = 16;
            // 
            // dtpDelDob
            // 
            this.dtpDelDob.Enabled = false;
            this.dtpDelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDelDob.Location = new System.Drawing.Point(172, 195);
            this.dtpDelDob.Name = "dtpDelDob";
            this.dtpDelDob.Size = new System.Drawing.Size(200, 26);
            this.dtpDelDob.TabIndex = 23;
            // 
            // lblAmendEmail
            // 
            this.lblAmendEmail.AutoSize = true;
            this.lblAmendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendEmail.Location = new System.Drawing.Point(34, 152);
            this.lblAmendEmail.Name = "lblAmendEmail";
            this.lblAmendEmail.Size = new System.Drawing.Size(48, 20);
            this.lblAmendEmail.TabIndex = 27;
            this.lblAmendEmail.Text = "Email";
            // 
            // txtDelEmail
            // 
            this.txtDelEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDelEmail.Enabled = false;
            this.txtDelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelEmail.Location = new System.Drawing.Point(172, 149);
            this.txtDelEmail.Name = "txtDelEmail";
            this.txtDelEmail.ReadOnly = true;
            this.txtDelEmail.Size = new System.Drawing.Size(419, 26);
            this.txtDelEmail.TabIndex = 22;
            // 
            // lblAmendDob
            // 
            this.lblAmendDob.AutoSize = true;
            this.lblAmendDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendDob.Location = new System.Drawing.Point(34, 200);
            this.lblAmendDob.Name = "lblAmendDob";
            this.lblAmendDob.Size = new System.Drawing.Size(99, 20);
            this.lblAmendDob.TabIndex = 28;
            this.lblAmendDob.Text = "Date of Birth";
            // 
            // lblAmendForeN
            // 
            this.lblAmendForeN.AutoSize = true;
            this.lblAmendForeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendForeN.Location = new System.Drawing.Point(34, 106);
            this.lblAmendForeN.Name = "lblAmendForeN";
            this.lblAmendForeN.Size = new System.Drawing.Size(82, 20);
            this.lblAmendForeN.TabIndex = 26;
            this.lblAmendForeN.Text = "Forename";
            // 
            // txtDelFname
            // 
            this.txtDelFname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDelFname.Enabled = false;
            this.txtDelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelFname.Location = new System.Drawing.Point(172, 103);
            this.txtDelFname.Name = "txtDelFname";
            this.txtDelFname.ReadOnly = true;
            this.txtDelFname.Size = new System.Drawing.Size(419, 26);
            this.txtDelFname.TabIndex = 21;
            // 
            // lblAmendSName
            // 
            this.lblAmendSName.AutoSize = true;
            this.lblAmendSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmendSName.Location = new System.Drawing.Point(34, 60);
            this.lblAmendSName.Name = "lblAmendSName";
            this.lblAmendSName.Size = new System.Drawing.Size(74, 20);
            this.lblAmendSName.TabIndex = 25;
            this.lblAmendSName.Text = "Surname";
            // 
            // txtDelSname
            // 
            this.txtDelSname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDelSname.Enabled = false;
            this.txtDelSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelSname.Location = new System.Drawing.Point(172, 57);
            this.txtDelSname.Name = "txtDelSname";
            this.txtDelSname.ReadOnly = true;
            this.txtDelSname.Size = new System.Drawing.Size(419, 26);
            this.txtDelSname.TabIndex = 20;
            // 
            // lblSDelete
            // 
            this.lblSDelete.AutoSize = true;
            this.lblSDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDelete.Location = new System.Drawing.Point(34, 17);
            this.lblSDelete.Name = "lblSDelete";
            this.lblSDelete.Size = new System.Drawing.Size(390, 20);
            this.lblSDelete.TabIndex = 24;
            this.lblSDelete.Text = "Deregister - Please enter and confirm password";
            // 
            // grpLecDel
            // 
            this.grpLecDel.Controls.Add(this.btnMenuSearch);
            this.grpLecDel.Controls.Add(this.btnSelect);
            this.grpLecDel.Controls.Add(this.lblStudList);
            this.grpLecDel.Controls.Add(this.grdStudList);
            this.grpLecDel.Controls.Add(this.lblSname);
            this.grpLecDel.Controls.Add(this.lblStudId);
            this.grpLecDel.Controls.Add(this.txtStudSname);
            this.grpLecDel.Controls.Add(this.txtStudId);
            this.grpLecDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLecDel.Location = new System.Drawing.Point(86, 94);
            this.grpLecDel.Name = "grpLecDel";
            this.grpLecDel.Size = new System.Drawing.Size(617, 405);
            this.grpLecDel.TabIndex = 44;
            this.grpLecDel.TabStop = false;
            this.grpLecDel.Text = "Search Student by";
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSearch.Location = new System.Drawing.Point(34, 343);
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
            // frmStudDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::TestSYS.Properties.Resources.bgd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpLecDel);
            this.Controls.Add(this.grpStudDel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmStudDel";
            this.Text = "Test System - Delete Student";
            this.Load += new System.EventHandler(this.frmStudDel_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.grpStudDel.ResumeLayout(false);
            this.grpStudDel.PerformLayout();
            this.grpLecDel.ResumeLayout(false);
            this.grpLecDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStudDel;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnDelStud;
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
        private System.Windows.Forms.Label lblSDelete;
        private System.Windows.Forms.GroupBox grpLecDel;
        private System.Windows.Forms.Button btnMenuSearch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblStudList;
        private System.Windows.Forms.DataGridView grdStudList;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.TextBox txtStudSname;
        private System.Windows.Forms.TextBox txtStudId;
    }
}