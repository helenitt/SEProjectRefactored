namespace TestSYS
{
    partial class frmStudentList
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
            this.grdStudList = new System.Windows.Forms.DataGridView();
            this.grpStudList = new System.Windows.Forms.GroupBox();
            this.radSname = new System.Windows.Forms.RadioButton();
            this.radStudId = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.mnuMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).BeginInit();
            this.grpStudList.SuspendLayout();
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
            this.lblTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(658, 35);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // grdStudList
            // 
            this.grdStudList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudList.Location = new System.Drawing.Point(107, 275);
            this.grdStudList.Name = "grdStudList";
            this.grdStudList.Size = new System.Drawing.Size(548, 179);
            this.grdStudList.TabIndex = 29;
            // 
            // grpStudList
            // 
            this.grpStudList.Controls.Add(this.btnFind);
            this.grpStudList.Controls.Add(this.radSname);
            this.grpStudList.Controls.Add(this.radStudId);
            this.grpStudList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudList.Location = new System.Drawing.Point(107, 176);
            this.grpStudList.Name = "grpStudList";
            this.grpStudList.Size = new System.Drawing.Size(548, 79);
            this.grpStudList.TabIndex = 30;
            this.grpStudList.TabStop = false;
            this.grpStudList.Text = "List Students";
            // 
            // radSname
            // 
            this.radSname.AutoSize = true;
            this.radSname.Location = new System.Drawing.Point(226, 35);
            this.radSname.Name = "radSname";
            this.radSname.Size = new System.Drawing.Size(92, 24);
            this.radSname.TabIndex = 1;
            this.radSname.TabStop = true;
            this.radSname.Text = "Surname";
            this.radSname.UseVisualStyleBackColor = true;
            this.radSname.Click += new System.EventHandler(this.radSname_Click);
            // 
            // radStudId
            // 
            this.radStudId.AutoSize = true;
            this.radStudId.Checked = true;
            this.radStudId.Location = new System.Drawing.Point(43, 35);
            this.radStudId.Name = "radStudId";
            this.radStudId.Size = new System.Drawing.Size(102, 24);
            this.radStudId.TabIndex = 0;
            this.radStudId.TabStop = true;
            this.radStudId.Text = "Student Id";
            this.radStudId.UseVisualStyleBackColor = true;
            this.radStudId.Click += new System.EventHandler(this.radStudId_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(436, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 37);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpStudList);
            this.Controls.Add(this.grdStudList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmStudentList";
            this.Text = "frmStudentList";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudList)).EndInit();
            this.grpStudList.ResumeLayout(false);
            this.grpStudList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdStudList;
        private System.Windows.Forms.GroupBox grpStudList;
        private System.Windows.Forms.RadioButton radSname;
        private System.Windows.Forms.RadioButton radStudId;
        private System.Windows.Forms.Button btnFind;
    }
}