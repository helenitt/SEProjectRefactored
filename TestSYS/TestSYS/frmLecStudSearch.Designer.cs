namespace TestSYS
{
    partial class frmLecStudSearch
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
            this.grpStudList = new System.Windows.Forms.GroupBox();
            this.txtStudSname = new System.Windows.Forms.TextBox();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.btnAmdStud = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.lblStudList = new System.Windows.Forms.Label();
            this.grdStudList = new System.Windows.Forms.DataGridView();
            this.lblStudId = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.mnuMenuBar.SuspendLayout();
            this.grpStudList.SuspendLayout();
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
            this.mnuMenuBar.TabIndex = 4;
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
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // grpStudList
            // 
            this.grpStudList.Controls.Add(this.lblSname);
            this.grpStudList.Controls.Add(this.lblStudId);
            this.grpStudList.Controls.Add(this.txtStudSname);
            this.grpStudList.Controls.Add(this.txtStudId);
            this.grpStudList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudList.Location = new System.Drawing.Point(114, 117);
            this.grpStudList.Name = "grpStudList";
            this.grpStudList.Size = new System.Drawing.Size(548, 79);
            this.grpStudList.TabIndex = 31;
            this.grpStudList.TabStop = false;
            this.grpStudList.Text = "Search Students By:-";
            // 
            // txtStudSname
            // 
            this.txtStudSname.Location = new System.Drawing.Point(318, 34);
            this.txtStudSname.Name = "txtStudSname";
            this.txtStudSname.Size = new System.Drawing.Size(230, 26);
            this.txtStudSname.TabIndex = 3;
            this.txtStudSname.TextChanged += new System.EventHandler(this.txtStudSname_TextChanged);
            // 
            // txtStudId
            // 
            this.txtStudId.Location = new System.Drawing.Point(108, 34);
            this.txtStudId.MaxLength = 8;
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.Size = new System.Drawing.Size(81, 26);
            this.txtStudId.TabIndex = 2;
            this.txtStudId.TextChanged += new System.EventHandler(this.txtStudId_TextChanged);
            // 
            // btnAmdStud
            // 
            this.btnAmdStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmdStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdStud.Location = new System.Drawing.Point(114, 466);
            this.btnAmdStud.Name = "btnAmdStud";
            this.btnAmdStud.Size = new System.Drawing.Size(225, 50);
            this.btnAmdStud.TabIndex = 34;
            this.btnAmdStud.Text = "Amend Student";
            this.btnAmdStud.UseVisualStyleBackColor = false;
            this.btnAmdStud.Click += new System.EventHandler(this.btnAmdStud_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStud.Location = new System.Drawing.Point(446, 466);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(225, 50);
            this.btnDelStud.TabIndex = 35;
            this.btnDelStud.Text = "Deregister Student";
            this.btnDelStud.UseVisualStyleBackColor = false;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // lblStudList
            // 
            this.lblStudList.AutoSize = true;
            this.lblStudList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudList.Location = new System.Drawing.Point(110, 222);
            this.lblStudList.Name = "lblStudList";
            this.lblStudList.Size = new System.Drawing.Size(123, 20);
            this.lblStudList.TabIndex = 36;
            this.lblStudList.Text = "  Select Student";
            // 
            // grdStudList
            // 
            this.grdStudList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudList.Location = new System.Drawing.Point(114, 246);
            this.grdStudList.Name = "grdStudList";
            this.grdStudList.Size = new System.Drawing.Size(548, 182);
            this.grdStudList.TabIndex = 38;
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(8, 37);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(84, 20);
            this.lblStudId.TabIndex = 4;
            this.lblStudId.Text = "Student Id";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(216, 37);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(74, 20);
            this.lblSname.TabIndex = 5;
            this.lblSname.Text = "Surname";
            // 
            // frmLecStudSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grdStudList);
            this.Controls.Add(this.lblStudList);
            this.Controls.Add(this.btnDelStud);
            this.Controls.Add(this.btnAmdStud);
            this.Controls.Add(this.grpStudList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmLecStudSearch";
            this.Text = "Lecturer - Student Search";
            this.Load += new System.EventHandler(this.frmLecStudSearch_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.grpStudList.ResumeLayout(false);
            this.grpStudList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStudList;
        private System.Windows.Forms.TextBox txtStudSname;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Button btnAmdStud;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Label lblStudList;
        private System.Windows.Forms.DataGridView grdStudList;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.Label lblSname;
    }
}