namespace TestSYS
{
    partial class frmMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnAmdStudDet = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.btnStudProf = new System.Windows.Forms.Button();
            this.grpLecturer = new System.Windows.Forms.GroupBox();
            this.btnDelQuest = new System.Windows.Forms.Button();
            this.btnAmdQuest = new System.Windows.Forms.Button();
            this.btnAddQuest = new System.Windows.Forms.Button();
            this.btnLStudProf = new System.Windows.Forms.Button();
            this.btnLDelStud = new System.Windows.Forms.Button();
            this.btnLAmdStud = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMenuBar.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuit});
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Size = new System.Drawing.Size(784, 27);
            this.mnuMenuBar.TabIndex = 15;
            this.mnuMenuBar.Text = "menuBar";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(48, 23);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(73, 100);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 20);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Welcome";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(152, 97);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(177, 26);
            this.txtName.TabIndex = 17;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.btnDelStud);
            this.grpStudent.Controls.Add(this.btnAmdStudDet);
            this.grpStudent.Controls.Add(this.btnQuit);
            this.grpStudent.Controls.Add(this.btnTakeTest);
            this.grpStudent.Controls.Add(this.btnStudProf);
            this.grpStudent.Location = new System.Drawing.Point(393, 100);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(270, 418);
            this.grpStudent.TabIndex = 26;
            this.grpStudent.TabStop = false;
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(23, 240);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnDelStud.TabIndex = 19;
            this.btnDelStud.Text = "Deregister";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnAmdStudDet
            // 
            this.btnAmdStudDet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAmdStudDet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmdStudDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdStudDet.Location = new System.Drawing.Point(23, 171);
            this.btnAmdStudDet.Name = "btnAmdStudDet";
            this.btnAmdStudDet.Size = new System.Drawing.Size(225, 50);
            this.btnAmdStudDet.TabIndex = 18;
            this.btnAmdStudDet.Text = "Amend Details";
            this.btnAmdStudDet.UseVisualStyleBackColor = false;
            this.btnAmdStudDet.Click += new System.EventHandler(this.btnAmdStudDet_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(22, 309);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(225, 50);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakeTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeTest.Location = new System.Drawing.Point(22, 33);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(225, 50);
            this.btnTakeTest.TabIndex = 16;
            this.btnTakeTest.Text = "TakeTest";
            this.btnTakeTest.UseVisualStyleBackColor = false;
            this.btnTakeTest.Click += new System.EventHandler(this.btnTakeTest_Click);
            // 
            // btnStudProf
            // 
            this.btnStudProf.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStudProf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudProf.Location = new System.Drawing.Point(23, 102);
            this.btnStudProf.Name = "btnStudProf";
            this.btnStudProf.Size = new System.Drawing.Size(225, 50);
            this.btnStudProf.TabIndex = 15;
            this.btnStudProf.Text = "Student Test Profile";
            this.btnStudProf.UseVisualStyleBackColor = false;
            this.btnStudProf.Click += new System.EventHandler(this.btnStudProf_Click);
            // 
            // grpLecturer
            // 
            this.grpLecturer.Controls.Add(this.btnDelQuest);
            this.grpLecturer.Controls.Add(this.btnAmdQuest);
            this.grpLecturer.Controls.Add(this.btnAddQuest);
            this.grpLecturer.Controls.Add(this.btnLStudProf);
            this.grpLecturer.Controls.Add(this.btnLDelStud);
            this.grpLecturer.Controls.Add(this.btnLAmdStud);
            this.grpLecturer.Location = new System.Drawing.Point(395, 100);
            this.grpLecturer.Name = "grpLecturer";
            this.grpLecturer.Size = new System.Drawing.Size(302, 390);
            this.grpLecturer.TabIndex = 27;
            this.grpLecturer.TabStop = false;
            // 
            // btnDelQuest
            // 
            this.btnDelQuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelQuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelQuest.Location = new System.Drawing.Point(23, 141);
            this.btnDelQuest.Name = "btnDelQuest";
            this.btnDelQuest.Size = new System.Drawing.Size(225, 50);
            this.btnDelQuest.TabIndex = 31;
            this.btnDelQuest.Text = "Delete Question";
            this.btnDelQuest.UseVisualStyleBackColor = false;
            this.btnDelQuest.Click += new System.EventHandler(this.btnDelQuest_Click);
            // 
            // btnAmdQuest
            // 
            this.btnAmdQuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAmdQuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmdQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdQuest.Location = new System.Drawing.Point(23, 79);
            this.btnAmdQuest.Name = "btnAmdQuest";
            this.btnAmdQuest.Size = new System.Drawing.Size(225, 50);
            this.btnAmdQuest.TabIndex = 30;
            this.btnAmdQuest.Text = "Amend Question";
            this.btnAmdQuest.UseVisualStyleBackColor = false;
            this.btnAmdQuest.Click += new System.EventHandler(this.btnAmdQuest_Click);
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddQuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuest.Location = new System.Drawing.Point(23, 17);
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(225, 50);
            this.btnAddQuest.TabIndex = 29;
            this.btnAddQuest.Text = "Create Question";
            this.btnAddQuest.UseVisualStyleBackColor = false;
            this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
            // 
            // btnLStudProf
            // 
            this.btnLStudProf.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLStudProf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLStudProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLStudProf.Location = new System.Drawing.Point(23, 203);
            this.btnLStudProf.Name = "btnLStudProf";
            this.btnLStudProf.Size = new System.Drawing.Size(225, 50);
            this.btnLStudProf.TabIndex = 28;
            this.btnLStudProf.Text = "Student Test Profile";
            this.btnLStudProf.UseVisualStyleBackColor = false;
            this.btnLStudProf.Click += new System.EventHandler(this.btnLStudProf_Click);
            // 
            // btnLDelStud
            // 
            this.btnLDelStud.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLDelStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLDelStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLDelStud.Location = new System.Drawing.Point(23, 327);
            this.btnLDelStud.Name = "btnLDelStud";
            this.btnLDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnLDelStud.TabIndex = 27;
            this.btnLDelStud.Text = "Deregister Student";
            this.btnLDelStud.UseVisualStyleBackColor = false;
            this.btnLDelStud.Click += new System.EventHandler(this.btnLDelStud_Click);
            // 
            // btnLAmdStud
            // 
            this.btnLAmdStud.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLAmdStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLAmdStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAmdStud.Location = new System.Drawing.Point(23, 265);
            this.btnLAmdStud.Name = "btnLAmdStud";
            this.btnLAmdStud.Size = new System.Drawing.Size(225, 50);
            this.btnLAmdStud.TabIndex = 26;
            this.btnLAmdStud.Text = "Amend Student";
            this.btnLAmdStud.UseVisualStyleBackColor = false;
            this.btnLAmdStud.Click += new System.EventHandler(this.btnLAmdStud_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestSYS.Properties.Resources.bulb;
            this.pictureBox1.Location = new System.Drawing.Point(100, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 308);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::TestSYS.Properties.Resources.bgd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.mnuMenuBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.grpLecturer);
            this.Name = "frmMenu";
            this.Text = "Test System - Main Menu";
            this.Load += new System.EventHandler(this.frmStudMenu_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpLecturer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnAmdStudDet;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTakeTest;
        private System.Windows.Forms.Button btnStudProf;
        private System.Windows.Forms.GroupBox grpLecturer;
        private System.Windows.Forms.Button btnDelQuest;
        private System.Windows.Forms.Button btnAmdQuest;
        private System.Windows.Forms.Button btnAddQuest;
        private System.Windows.Forms.Button btnLStudProf;
        private System.Windows.Forms.Button btnLDelStud;
        private System.Windows.Forms.Button btnLAmdStud;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

