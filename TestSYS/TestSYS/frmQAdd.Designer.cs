namespace TestSYS
{
    partial class frmQAdd
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
            this.lblQAdd = new System.Windows.Forms.Label();
            this.lblQLvl = new System.Windows.Forms.Label();
            this.txtQText = new System.Windows.Forms.TextBox();
            this.lblQTxt = new System.Windows.Forms.Label();
            this.cboQLvl = new System.Windows.Forms.ComboBox();
            this.txtAddAns1 = new System.Windows.Forms.TextBox();
            this.txtAddAns2 = new System.Windows.Forms.TextBox();
            this.txtAddAns3 = new System.Windows.Forms.TextBox();
            this.txtAddAns4 = new System.Windows.Forms.TextBox();
            this.optAddQ1 = new System.Windows.Forms.RadioButton();
            this.optAddQ2 = new System.Windows.Forms.RadioButton();
            this.optAddQ3 = new System.Windows.Forms.RadioButton();
            this.optAddQ4 = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQAns = new System.Windows.Forms.Label();
            this.btnQAddSubmit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblQuestID = new System.Windows.Forms.Label();
            this.txtQuestId = new System.Windows.Forms.TextBox();
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
            // lblQAdd
            // 
            this.lblQAdd.AutoSize = true;
            this.lblQAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAdd.Location = new System.Drawing.Point(123, 113);
            this.lblQAdd.Name = "lblQAdd";
            this.lblQAdd.Size = new System.Drawing.Size(259, 20);
            this.lblQAdd.TabIndex = 13;
            this.lblQAdd.Text = "Please enter Question Details:-";
            // 
            // lblQLvl
            // 
            this.lblQLvl.AutoSize = true;
            this.lblQLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLvl.Location = new System.Drawing.Point(123, 155);
            this.lblQLvl.Name = "lblQLvl";
            this.lblQLvl.Size = new System.Drawing.Size(114, 20);
            this.lblQLvl.TabIndex = 14;
            this.lblQLvl.Text = "Question Level";
            // 
            // txtQText
            // 
            this.txtQText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQText.Location = new System.Drawing.Point(255, 192);
            this.txtQText.Name = "txtQText";
            this.txtQText.Size = new System.Drawing.Size(400, 26);
            this.txtQText.TabIndex = 2;
            // 
            // lblQTxt
            // 
            this.lblQTxt.AutoSize = true;
            this.lblQTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTxt.Location = new System.Drawing.Point(123, 195);
            this.lblQTxt.Name = "lblQTxt";
            this.lblQTxt.Size = new System.Drawing.Size(107, 20);
            this.lblQTxt.TabIndex = 15;
            this.lblQTxt.Text = "Question Text";
            // 
            // cboQLvl
            // 
            this.cboQLvl.AllowDrop = true;
            this.cboQLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQLvl.FormattingEnabled = true;
            this.cboQLvl.Location = new System.Drawing.Point(255, 147);
            this.cboQLvl.Name = "cboQLvl";
            this.cboQLvl.Size = new System.Drawing.Size(148, 28);
            this.cboQLvl.TabIndex = 1;
            // 
            // txtAddAns1
            // 
            this.txtAddAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAns1.Location = new System.Drawing.Point(255, 298);
            this.txtAddAns1.Name = "txtAddAns1";
            this.txtAddAns1.Size = new System.Drawing.Size(400, 26);
            this.txtAddAns1.TabIndex = 4;
            // 
            // txtAddAns2
            // 
            this.txtAddAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAns2.Location = new System.Drawing.Point(255, 334);
            this.txtAddAns2.Name = "txtAddAns2";
            this.txtAddAns2.Size = new System.Drawing.Size(400, 26);
            this.txtAddAns2.TabIndex = 6;
            // 
            // txtAddAns3
            // 
            this.txtAddAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAns3.Location = new System.Drawing.Point(255, 370);
            this.txtAddAns3.Name = "txtAddAns3";
            this.txtAddAns3.Size = new System.Drawing.Size(400, 26);
            this.txtAddAns3.TabIndex = 8;
            // 
            // txtAddAns4
            // 
            this.txtAddAns4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAns4.Location = new System.Drawing.Point(255, 406);
            this.txtAddAns4.Name = "txtAddAns4";
            this.txtAddAns4.Size = new System.Drawing.Size(400, 26);
            this.txtAddAns4.TabIndex = 10;
            // 
            // optAddQ1
            // 
            this.optAddQ1.AutoSize = true;
            this.optAddQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAddQ1.Location = new System.Drawing.Point(127, 299);
            this.optAddQ1.Name = "optAddQ1";
            this.optAddQ1.Size = new System.Drawing.Size(93, 24);
            this.optAddQ1.TabIndex = 3;
            this.optAddQ1.Text = "Answer 1";
            this.optAddQ1.UseVisualStyleBackColor = true;
            // 
            // optAddQ2
            // 
            this.optAddQ2.AutoSize = true;
            this.optAddQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAddQ2.Location = new System.Drawing.Point(127, 335);
            this.optAddQ2.Name = "optAddQ2";
            this.optAddQ2.Size = new System.Drawing.Size(93, 24);
            this.optAddQ2.TabIndex = 5;
            this.optAddQ2.Text = "Answer 2";
            this.optAddQ2.UseVisualStyleBackColor = true;
            // 
            // optAddQ3
            // 
            this.optAddQ3.AutoSize = true;
            this.optAddQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAddQ3.Location = new System.Drawing.Point(127, 371);
            this.optAddQ3.Name = "optAddQ3";
            this.optAddQ3.Size = new System.Drawing.Size(93, 24);
            this.optAddQ3.TabIndex = 7;
            this.optAddQ3.Text = "Answer 3";
            this.optAddQ3.UseVisualStyleBackColor = true;
            // 
            // optAddQ4
            // 
            this.optAddQ4.AutoSize = true;
            this.optAddQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAddQ4.Location = new System.Drawing.Point(127, 407);
            this.optAddQ4.Name = "optAddQ4";
            this.optAddQ4.Size = new System.Drawing.Size(93, 24);
            this.optAddQ4.TabIndex = 9;
            this.optAddQ4.Text = "Answer 4";
            this.optAddQ4.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // lblQAns
            // 
            this.lblQAns.AutoSize = true;
            this.lblQAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAns.Location = new System.Drawing.Point(123, 266);
            this.lblQAns.Name = "lblQAns";
            this.lblQAns.Size = new System.Drawing.Size(280, 20);
            this.lblQAns.TabIndex = 16;
            this.lblQAns.Text = "Indicate Correct Aswer and Insert Text";
            // 
            // btnQAddSubmit
            // 
            this.btnQAddSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQAddSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQAddSubmit.Location = new System.Drawing.Point(127, 466);
            this.btnQAddSubmit.Name = "btnQAddSubmit";
            this.btnQAddSubmit.Size = new System.Drawing.Size(225, 50);
            this.btnQAddSubmit.TabIndex = 11;
            this.btnQAddSubmit.Text = "SUBMIT";
            this.btnQAddSubmit.UseVisualStyleBackColor = false;
            this.btnQAddSubmit.Click += new System.EventHandler(this.btnQAddSubmit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(430, 466);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblQuestID
            // 
            this.lblQuestID.AutoSize = true;
            this.lblQuestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestID.Location = new System.Drawing.Point(405, 113);
            this.lblQuestID.Name = "lblQuestID";
            this.lblQuestID.Size = new System.Drawing.Size(113, 20);
            this.lblQuestID.TabIndex = 18;
            this.lblQuestID.Text = "Question Id:-";
            // 
            // txtQuestId
            // 
            this.txtQuestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestId.Location = new System.Drawing.Point(517, 110);
            this.txtQuestId.Name = "txtQuestId";
            this.txtQuestId.ReadOnly = true;
            this.txtQuestId.Size = new System.Drawing.Size(138, 26);
            this.txtQuestId.TabIndex = 19;
            this.txtQuestId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmQAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtQuestId);
            this.Controls.Add(this.lblQuestID);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnQAddSubmit);
            this.Controls.Add(this.lblQAns);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.optAddQ4);
            this.Controls.Add(this.optAddQ3);
            this.Controls.Add(this.optAddQ2);
            this.Controls.Add(this.optAddQ1);
            this.Controls.Add(this.txtAddAns4);
            this.Controls.Add(this.txtAddAns3);
            this.Controls.Add(this.txtAddAns2);
            this.Controls.Add(this.txtAddAns1);
            this.Controls.Add(this.cboQLvl);
            this.Controls.Add(this.lblQTxt);
            this.Controls.Add(this.txtQText);
            this.Controls.Add(this.lblQLvl);
            this.Controls.Add(this.lblQAdd);
            this.Controls.Add(this.mnuMenuBar);
            this.Name = "frmQAdd";
            this.Text = "Test System - Create Question";
            this.Load += new System.EventHandler(this.frmQAdd_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblQAdd;
        private System.Windows.Forms.Label lblQLvl;
        private System.Windows.Forms.TextBox txtQText;
        private System.Windows.Forms.Label lblQTxt;
        private System.Windows.Forms.ComboBox cboQLvl;
        private System.Windows.Forms.TextBox txtAddAns1;
        private System.Windows.Forms.TextBox txtAddAns2;
        private System.Windows.Forms.TextBox txtAddAns3;
        private System.Windows.Forms.TextBox txtAddAns4;
        private System.Windows.Forms.RadioButton optAddQ1;
        private System.Windows.Forms.RadioButton optAddQ2;
        private System.Windows.Forms.RadioButton optAddQ3;
        private System.Windows.Forms.RadioButton optAddQ4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQAns;
        private System.Windows.Forms.Button btnQAddSubmit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblQuestID;
        private System.Windows.Forms.TextBox txtQuestId;
    }
}