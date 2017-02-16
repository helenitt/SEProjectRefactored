namespace TestSYS
{
    partial class frmStudMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStudProf = new System.Windows.Forms.Button();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.btnRevTest = new System.Windows.Forms.Button();
            this.btnAmdStudDet = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.picBulb = new System.Windows.Forms.PictureBox();
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBulb)).BeginInit();
            this.mnuMenuBar.SuspendLayout();
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
            // btnStudProf
            // 
            this.btnStudProf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStudProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudProf.Location = new System.Drawing.Point(422, 270);
            this.btnStudProf.Name = "btnStudProf";
            this.btnStudProf.Size = new System.Drawing.Size(225, 50);
            this.btnStudProf.TabIndex = 9;
            this.btnStudProf.Text = "Student Profile";
            this.btnStudProf.UseVisualStyleBackColor = false;
            this.btnStudProf.Click += new System.EventHandler(this.btnStudProf_Click);
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTakeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeTest.Location = new System.Drawing.Point(422, 132);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(225, 50);
            this.btnTakeTest.TabIndex = 10;
            this.btnTakeTest.Text = "TakeTest";
            this.btnTakeTest.UseVisualStyleBackColor = false;
            this.btnTakeTest.Click += new System.EventHandler(this.btnTakeTest_Click);
            // 
            // btnRevTest
            // 
            this.btnRevTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRevTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevTest.Location = new System.Drawing.Point(422, 201);
            this.btnRevTest.Name = "btnRevTest";
            this.btnRevTest.Size = new System.Drawing.Size(225, 50);
            this.btnRevTest.TabIndex = 11;
            this.btnRevTest.Text = "Review Test";
            this.btnRevTest.UseVisualStyleBackColor = false;
            this.btnRevTest.Click += new System.EventHandler(this.btnRevTest_Click);
            // 
            // btnAmdStudDet
            // 
            this.btnAmdStudDet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmdStudDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdStudDet.Location = new System.Drawing.Point(422, 339);
            this.btnAmdStudDet.Name = "btnAmdStudDet";
            this.btnAmdStudDet.Size = new System.Drawing.Size(225, 50);
            this.btnAmdStudDet.TabIndex = 12;
            this.btnAmdStudDet.Text = "Amend Details";
            this.btnAmdStudDet.UseVisualStyleBackColor = false;
            this.btnAmdStudDet.Click += new System.EventHandler(this.btnAmdStudDet_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(422, 408);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnDelStud.TabIndex = 14;
            this.btnDelStud.Text = "Deregister";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // picBulb
            // 
            this.picBulb.Image = ((System.Drawing.Image)(resources.GetObject("picBulb.Image")));
            this.picBulb.Location = new System.Drawing.Point(76, 132);
            this.picBulb.Name = "picBulb";
            this.picBulb.Size = new System.Drawing.Size(253, 361);
            this.picBulb.TabIndex = 6;
            this.picBulb.TabStop = false;
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
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(73, 100);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Welcome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 97);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // frmStudMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.mnuMenuBar);
            this.Controls.Add(this.btnDelStud);
            this.Controls.Add(this.btnAmdStudDet);
            this.Controls.Add(this.btnRevTest);
            this.Controls.Add(this.btnTakeTest);
            this.Controls.Add(this.btnStudProf);
            this.Controls.Add(this.picBulb);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStudMenu";
            this.Text = "Test System - Main Menu";
            this.Load += new System.EventHandler(this.frmStudMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBulb)).EndInit();
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBulb;
        private System.Windows.Forms.Button btnStudProf;
        private System.Windows.Forms.Button btnTakeTest;
        private System.Windows.Forms.Button btnRevTest;
        private System.Windows.Forms.Button btnAmdStudDet;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
    }
}

