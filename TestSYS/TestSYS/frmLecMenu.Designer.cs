namespace TestSYS
{
    partial class frmLecMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLecMenu));
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBulb = new System.Windows.Forms.PictureBox();
            this.btnAmdStud = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnStudProf = new System.Windows.Forms.Button();
            this.btnAddQuest = new System.Windows.Forms.Button();
            this.btnAmdQuest = new System.Windows.Forms.Button();
            this.btnDelQuest = new System.Windows.Forms.Button();
            this.mnuMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBulb)).BeginInit();
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
            this.mnuMenuBar.TabIndex = 3;
            this.mnuMenuBar.Text = "menuBar";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(49, 23);
            this.mnuBack.Text = "Back";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // picBulb
            // 
            this.picBulb.Image = ((System.Drawing.Image)(resources.GetObject("picBulb.Image")));
            this.picBulb.Location = new System.Drawing.Point(76, 132);
            this.picBulb.Name = "picBulb";
            this.picBulb.Size = new System.Drawing.Size(253, 361);
            this.picBulb.TabIndex = 7;
            this.picBulb.TabStop = false;
            // 
            // btnAmdStud
            // 
            this.btnAmdStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmdStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdStud.Location = new System.Drawing.Point(422, 380);
            this.btnAmdStud.Name = "btnAmdStud";
            this.btnAmdStud.Size = new System.Drawing.Size(225, 50);
            this.btnAmdStud.TabIndex = 12;
            this.btnAmdStud.Text = "Amend Student";
            this.btnAmdStud.UseVisualStyleBackColor = false;
            this.btnAmdStud.Click += new System.EventHandler(this.btnAmdStud_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(422, 442);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnDelStud.TabIndex = 13;
            this.btnDelStud.Text = "Deregister Student";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnStudProf
            // 
            this.btnStudProf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStudProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudProf.Location = new System.Drawing.Point(422, 318);
            this.btnStudProf.Name = "btnStudProf";
            this.btnStudProf.Size = new System.Drawing.Size(225, 50);
            this.btnStudProf.TabIndex = 16;
            this.btnStudProf.Text = "Student Profile";
            this.btnStudProf.UseVisualStyleBackColor = false;
            this.btnStudProf.Click += new System.EventHandler(this.btnStudProf_Click);
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuest.Location = new System.Drawing.Point(422, 132);
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(225, 50);
            this.btnAddQuest.TabIndex = 17;
            this.btnAddQuest.Text = "Create Question";
            this.btnAddQuest.UseVisualStyleBackColor = false;
            this.btnAddQuest.Click += new System.EventHandler(this.btnAddQuest_Click);
            // 
            // btnAmdQuest
            // 
            this.btnAmdQuest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmdQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdQuest.Location = new System.Drawing.Point(422, 194);
            this.btnAmdQuest.Name = "btnAmdQuest";
            this.btnAmdQuest.Size = new System.Drawing.Size(225, 50);
            this.btnAmdQuest.TabIndex = 18;
            this.btnAmdQuest.Text = "Amend Question";
            this.btnAmdQuest.UseVisualStyleBackColor = false;
            this.btnAmdQuest.Click += new System.EventHandler(this.btnAmdQuest_Click);
            // 
            // btnDelQuest
            // 
            this.btnDelQuest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelQuest.Location = new System.Drawing.Point(422, 256);
            this.btnDelQuest.Name = "btnDelQuest";
            this.btnDelQuest.Size = new System.Drawing.Size(225, 50);
            this.btnDelQuest.TabIndex = 19;
            this.btnDelQuest.Text = "Delete Question";
            this.btnDelQuest.UseVisualStyleBackColor = false;
            this.btnDelQuest.Click += new System.EventHandler(this.btnDelQuest_Click);
            // 
            // frmLecMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnDelQuest);
            this.Controls.Add(this.btnAmdQuest);
            this.Controls.Add(this.btnAddQuest);
            this.Controls.Add(this.btnStudProf);
            this.Controls.Add(this.btnDelStud);
            this.Controls.Add(this.btnAmdStud);
            this.Controls.Add(this.picBulb);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmLecMenu";
            this.Text = "Lecturer - Main Menu";
            this.Load += new System.EventHandler(this.frmLecMenu_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBulb;
        private System.Windows.Forms.Button btnAmdStud;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnStudProf;
        private System.Windows.Forms.Button btnAddQuest;
        private System.Windows.Forms.Button btnAmdQuest;
        private System.Windows.Forms.Button btnDelQuest;
    }
}