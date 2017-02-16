namespace TestSYS
{
    partial class frmQAmd
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
            this.btnAmdSubmit = new System.Windows.Forms.Button();
            this.lblQAmendAns = new System.Windows.Forms.Label();
            this.optAmd4 = new System.Windows.Forms.RadioButton();
            this.optAmd3 = new System.Windows.Forms.RadioButton();
            this.optAmd2 = new System.Windows.Forms.RadioButton();
            this.optAmd1 = new System.Windows.Forms.RadioButton();
            this.txtAmdAns4 = new System.Windows.Forms.TextBox();
            this.txtAmdAns3 = new System.Windows.Forms.TextBox();
            this.txtAmdAns2 = new System.Windows.Forms.TextBox();
            this.txtAmdAns1 = new System.Windows.Forms.TextBox();
            this.lblQAmendTxt = new System.Windows.Forms.Label();
            this.txtQText = new System.Windows.Forms.TextBox();
            this.lblQAmendLvl = new System.Windows.Forms.Label();
            this.lblQAmend = new System.Windows.Forms.Label();
            this.txtAmdQID = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.cboQLvl = new System.Windows.Forms.ComboBox();
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
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // btnAmdSubmit
            // 
            this.btnAmdSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmdSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdSubmit.Location = new System.Drawing.Point(127, 466);
            this.btnAmdSubmit.Name = "btnAmdSubmit";
            this.btnAmdSubmit.Size = new System.Drawing.Size(225, 50);
            this.btnAmdSubmit.TabIndex = 12;
            this.btnAmdSubmit.Text = "AMEND";
            this.btnAmdSubmit.UseVisualStyleBackColor = false;
            this.btnAmdSubmit.Click += new System.EventHandler(this.btnAmdSubmit_Click);
            // 
            // lblQAmendAns
            // 
            this.lblQAmendAns.AutoSize = true;
            this.lblQAmendAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAmendAns.Location = new System.Drawing.Point(123, 251);
            this.lblQAmendAns.Name = "lblQAmendAns";
            this.lblQAmendAns.Size = new System.Drawing.Size(290, 20);
            this.lblQAmendAns.TabIndex = 17;
            this.lblQAmendAns.Text = "Indicate Correct Aswer and Amend Text";
            // 
            // optAmd4
            // 
            this.optAmd4.AutoSize = true;
            this.optAmd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAmd4.Location = new System.Drawing.Point(127, 405);
            this.optAmd4.Name = "optAmd4";
            this.optAmd4.Size = new System.Drawing.Size(93, 24);
            this.optAmd4.TabIndex = 10;
            this.optAmd4.Text = "Answer 4";
            this.optAmd4.UseVisualStyleBackColor = true;
            // 
            // optAmd3
            // 
            this.optAmd3.AutoSize = true;
            this.optAmd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAmd3.Location = new System.Drawing.Point(127, 369);
            this.optAmd3.Name = "optAmd3";
            this.optAmd3.Size = new System.Drawing.Size(93, 24);
            this.optAmd3.TabIndex = 8;
            this.optAmd3.Text = "Answer 3";
            this.optAmd3.UseVisualStyleBackColor = true;
            // 
            // optAmd2
            // 
            this.optAmd2.AutoSize = true;
            this.optAmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAmd2.Location = new System.Drawing.Point(127, 334);
            this.optAmd2.Name = "optAmd2";
            this.optAmd2.Size = new System.Drawing.Size(93, 24);
            this.optAmd2.TabIndex = 6;
            this.optAmd2.Text = "Answer 2";
            this.optAmd2.UseVisualStyleBackColor = true;
            // 
            // optAmd1
            // 
            this.optAmd1.AutoSize = true;
            this.optAmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAmd1.Location = new System.Drawing.Point(127, 299);
            this.optAmd1.Name = "optAmd1";
            this.optAmd1.Size = new System.Drawing.Size(93, 24);
            this.optAmd1.TabIndex = 4;
            this.optAmd1.Text = "Answer 1";
            this.optAmd1.UseVisualStyleBackColor = true;
            // 
            // txtAmdAns4
            // 
            this.txtAmdAns4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdAns4.Location = new System.Drawing.Point(255, 403);
            this.txtAmdAns4.Name = "txtAmdAns4";
            this.txtAmdAns4.Size = new System.Drawing.Size(400, 26);
            this.txtAmdAns4.TabIndex = 11;
            // 
            // txtAmdAns3
            // 
            this.txtAmdAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdAns3.Location = new System.Drawing.Point(255, 367);
            this.txtAmdAns3.Name = "txtAmdAns3";
            this.txtAmdAns3.Size = new System.Drawing.Size(400, 26);
            this.txtAmdAns3.TabIndex = 9;
            // 
            // txtAmdAns2
            // 
            this.txtAmdAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdAns2.Location = new System.Drawing.Point(255, 332);
            this.txtAmdAns2.Name = "txtAmdAns2";
            this.txtAmdAns2.Size = new System.Drawing.Size(400, 26);
            this.txtAmdAns2.TabIndex = 7;
            // 
            // txtAmdAns1
            // 
            this.txtAmdAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdAns1.Location = new System.Drawing.Point(255, 297);
            this.txtAmdAns1.Name = "txtAmdAns1";
            this.txtAmdAns1.Size = new System.Drawing.Size(400, 26);
            this.txtAmdAns1.TabIndex = 5;
            // 
            // lblQAmendTxt
            // 
            this.lblQAmendTxt.AutoSize = true;
            this.lblQAmendTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAmendTxt.Location = new System.Drawing.Point(123, 195);
            this.lblQAmendTxt.Name = "lblQAmendTxt";
            this.lblQAmendTxt.Size = new System.Drawing.Size(107, 20);
            this.lblQAmendTxt.TabIndex = 16;
            this.lblQAmendTxt.Text = "Question Text";
            // 
            // txtQText
            // 
            this.txtQText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQText.Location = new System.Drawing.Point(255, 197);
            this.txtQText.Name = "txtQText";
            this.txtQText.Size = new System.Drawing.Size(400, 26);
            this.txtQText.TabIndex = 3;
            // 
            // lblQAmendLvl
            // 
            this.lblQAmendLvl.AutoSize = true;
            this.lblQAmendLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAmendLvl.Location = new System.Drawing.Point(123, 155);
            this.lblQAmendLvl.Name = "lblQAmendLvl";
            this.lblQAmendLvl.Size = new System.Drawing.Size(114, 20);
            this.lblQAmendLvl.TabIndex = 15;
            this.lblQAmendLvl.Text = "Question Level";
            // 
            // lblQAmend
            // 
            this.lblQAmend.AutoSize = true;
            this.lblQAmend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAmend.Location = new System.Drawing.Point(123, 113);
            this.lblQAmend.Name = "lblQAmend";
            this.lblQAmend.Size = new System.Drawing.Size(302, 20);
            this.lblQAmend.TabIndex = 14;
            this.lblQAmend.Text = "Please Enter Question ID to be Amended";
            // 
            // txtAmdQID
            // 
            this.txtAmdQID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmdQID.Location = new System.Drawing.Point(431, 113);
            this.txtAmdQID.MaxLength = 4;
            this.txtAmdQID.Name = "txtAmdQID";
            this.txtAmdQID.Size = new System.Drawing.Size(224, 26);
            this.txtAmdQID.TabIndex = 1;
            this.txtAmdQID.TextChanged += new System.EventHandler(this.txtAmdQID_TextChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(430, 466);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            // 
            // cboQLvl
            // 
            this.cboQLvl.AllowDrop = true;
            this.cboQLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQLvl.FormattingEnabled = true;
            this.cboQLvl.Location = new System.Drawing.Point(255, 152);
            this.cboQLvl.Name = "cboQLvl";
            this.cboQLvl.Size = new System.Drawing.Size(148, 28);
            this.cboQLvl.TabIndex = 2;
            // 
            // frmQAmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cboQLvl);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txtAmdQID);
            this.Controls.Add(this.btnAmdSubmit);
            this.Controls.Add(this.lblQAmendAns);
            this.Controls.Add(this.optAmd4);
            this.Controls.Add(this.optAmd3);
            this.Controls.Add(this.optAmd2);
            this.Controls.Add(this.optAmd1);
            this.Controls.Add(this.txtAmdAns4);
            this.Controls.Add(this.txtAmdAns3);
            this.Controls.Add(this.txtAmdAns2);
            this.Controls.Add(this.txtAmdAns1);
            this.Controls.Add(this.lblQAmendTxt);
            this.Controls.Add(this.txtQText);
            this.Controls.Add(this.lblQAmendLvl);
            this.Controls.Add(this.lblQAmend);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmQAmd";
            this.Text = "Test System - Amend Question";
            this.Load += new System.EventHandler(this.frmQAmd_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAmdSubmit;
        private System.Windows.Forms.Label lblQAmendAns;
        private System.Windows.Forms.RadioButton optAmd4;
        private System.Windows.Forms.RadioButton optAmd3;
        private System.Windows.Forms.RadioButton optAmd2;
        private System.Windows.Forms.RadioButton optAmd1;
        private System.Windows.Forms.TextBox txtAmdAns4;
        private System.Windows.Forms.TextBox txtAmdAns3;
        private System.Windows.Forms.TextBox txtAmdAns2;
        private System.Windows.Forms.TextBox txtAmdAns1;
        private System.Windows.Forms.Label lblQAmendTxt;
        private System.Windows.Forms.TextBox txtQText;
        private System.Windows.Forms.Label lblQAmendLvl;
        private System.Windows.Forms.Label lblQAmend;
        private System.Windows.Forms.TextBox txtAmdQID;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.ComboBox cboQLvl;
    }
}