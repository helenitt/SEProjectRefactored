namespace TestSYS
{
    partial class frmTProfile
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
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.grdTests = new System.Windows.Forms.DataGridView();
            this.btnFinStud = new System.Windows.Forms.Button();
            this.grpLecturer = new System.Windows.Forms.GroupBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblStudList = new System.Windows.Forms.Label();
            this.grdStudList = new System.Windows.Forms.DataGridView();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblStudId = new System.Windows.Forms.Label();
            this.txtStudSname = new System.Windows.Forms.TextBox();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenuBar.SuspendLayout();
            this.grpStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTests)).BeginInit();
            this.grpLecturer.SuspendLayout();
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
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.grdTests);
            this.grpStudent.Controls.Add(this.btnFinStud);
            this.grpStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudent.Location = new System.Drawing.Point(149, 108);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(545, 388);
            this.grpStudent.TabIndex = 41;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Test Results";
            // 
            // grdTests
            // 
            this.grdTests.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTests.GridColor = System.Drawing.SystemColors.Menu;
            this.grdTests.Location = new System.Drawing.Point(24, 38);
            this.grdTests.Name = "grdTests";
            this.grdTests.ReadOnly = true;
            this.grdTests.Size = new System.Drawing.Size(490, 237);
            this.grdTests.TabIndex = 42;
            // 
            // btnFinStud
            // 
            this.btnFinStud.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFinStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinStud.Location = new System.Drawing.Point(289, 322);
            this.btnFinStud.Name = "btnFinStud";
            this.btnFinStud.Size = new System.Drawing.Size(225, 50);
            this.btnFinStud.TabIndex = 41;
            this.btnFinStud.Text = "Finished";
            this.btnFinStud.UseVisualStyleBackColor = false;
            this.btnFinStud.Click += new System.EventHandler(this.btnFinishedProfile_Click);
            // 
            // grpLecturer
            // 
            this.grpLecturer.Controls.Add(this.btnMainMenu);
            this.grpLecturer.Controls.Add(this.btnSelect);
            this.grpLecturer.Controls.Add(this.lblStudList);
            this.grpLecturer.Controls.Add(this.grdStudList);
            this.grpLecturer.Controls.Add(this.lblSname);
            this.grpLecturer.Controls.Add(this.lblStudId);
            this.grpLecturer.Controls.Add(this.txtStudSname);
            this.grpLecturer.Controls.Add(this.txtStudId);
            this.grpLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLecturer.Location = new System.Drawing.Point(80, 108);
            this.grpLecturer.Name = "grpLecturer";
            this.grpLecturer.Size = new System.Drawing.Size(617, 388);
            this.grpLecturer.TabIndex = 42;
            this.grpLecturer.TabStop = false;
            this.grpLecturer.Text = "Search Student by";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(34, 322);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 53;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(357, 322);
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
            this.grdStudList.Size = new System.Drawing.Size(548, 181);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(115, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(557, 41);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // frmTProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::TestSYS.Properties.Resources.bgd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Controls.Add(this.grpLecturer);
            this.Name = "frmTProfile";
            this.Text = "Test System - Student Test Profile";
            this.Load += new System.EventHandler(this.frmTProfile_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTests)).EndInit();
            this.grpLecturer.ResumeLayout(false);
            this.grpLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.DataGridView grdTests;
        private System.Windows.Forms.Button btnFinStud;
        private System.Windows.Forms.GroupBox grpLecturer;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.TextBox txtStudSname;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.DataGridView grdStudList;
        private System.Windows.Forms.Label lblStudList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMainMenu;
    }
}