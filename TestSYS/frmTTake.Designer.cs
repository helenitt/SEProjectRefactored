namespace TestSYS
{
    partial class frmTTake
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
            this.btnTTSubmit = new System.Windows.Forms.Button();
            this.lblTTest = new System.Windows.Forms.Label();
            this.cboTTLvl = new System.Windows.Forms.ComboBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.grpTTQ1 = new System.Windows.Forms.GroupBox();
            this.txtAns4 = new System.Windows.Forms.TextBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.txtQText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQ1Txt = new System.Windows.Forms.Label();
            this.optFour = new System.Windows.Forms.RadioButton();
            this.optThree = new System.Windows.Forms.RadioButton();
            this.optTwo = new System.Windows.Forms.RadioButton();
            this.optOne = new System.Windows.Forms.RadioButton();
            this.btnTTNxQ = new System.Windows.Forms.Button();
            this.pgbTestProgress = new System.Windows.Forms.ProgressBar();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTTQ1.SuspendLayout();
            this.mnuMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTTSubmit
            // 
            this.btnTTSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTTSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTSubmit.Location = new System.Drawing.Point(413, 466);
            this.btnTTSubmit.Name = "btnTTSubmit";
            this.btnTTSubmit.Size = new System.Drawing.Size(225, 50);
            this.btnTTSubmit.TabIndex = 8;
            this.btnTTSubmit.Text = "Submit Test";
            this.btnTTSubmit.UseVisualStyleBackColor = false;
            this.btnTTSubmit.Visible = false;
            this.btnTTSubmit.Click += new System.EventHandler(this.btnTTSubmit_Click);
            // 
            // lblTTest
            // 
            this.lblTTest.AutoSize = true;
            this.lblTTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTest.Location = new System.Drawing.Point(123, 153);
            this.lblTTest.Name = "lblTTest";
            this.lblTTest.Size = new System.Drawing.Size(179, 20);
            this.lblTTest.TabIndex = 9;
            this.lblTTest.Text = "Please select Test Level";
            // 
            // cboTTLvl
            // 
            this.cboTTLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTTLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTTLvl.FormattingEnabled = true;
            this.cboTTLvl.Location = new System.Drawing.Point(310, 150);
            this.cboTTLvl.Name = "cboTTLvl";
            this.cboTTLvl.Size = new System.Drawing.Size(156, 28);
            this.cboTTLvl.TabIndex = 1;
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.Location = new System.Drawing.Point(478, 148);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(160, 33);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // grpTTQ1
            // 
            this.grpTTQ1.Controls.Add(this.txtAns4);
            this.grpTTQ1.Controls.Add(this.txtAns3);
            this.grpTTQ1.Controls.Add(this.txtAns2);
            this.grpTTQ1.Controls.Add(this.txtAns1);
            this.grpTTQ1.Controls.Add(this.txtQText);
            this.grpTTQ1.Controls.Add(this.label1);
            this.grpTTQ1.Controls.Add(this.lblQ1Txt);
            this.grpTTQ1.Controls.Add(this.optFour);
            this.grpTTQ1.Controls.Add(this.optThree);
            this.grpTTQ1.Controls.Add(this.optTwo);
            this.grpTTQ1.Controls.Add(this.optOne);
            this.grpTTQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTQ1.Location = new System.Drawing.Point(127, 200);
            this.grpTTQ1.Name = "grpTTQ1";
            this.grpTTQ1.Size = new System.Drawing.Size(511, 248);
            this.grpTTQ1.TabIndex = 16;
            this.grpTTQ1.TabStop = false;
            this.grpTTQ1.Visible = false;
            // 
            // txtAns4
            // 
            this.txtAns4.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAns4.Location = new System.Drawing.Point(62, 200);
            this.txtAns4.Name = "txtAns4";
            this.txtAns4.ReadOnly = true;
            this.txtAns4.Size = new System.Drawing.Size(415, 26);
            this.txtAns4.TabIndex = 43;
            // 
            // txtAns3
            // 
            this.txtAns3.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAns3.Location = new System.Drawing.Point(62, 161);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.ReadOnly = true;
            this.txtAns3.Size = new System.Drawing.Size(415, 26);
            this.txtAns3.TabIndex = 42;
            // 
            // txtAns2
            // 
            this.txtAns2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAns2.Location = new System.Drawing.Point(62, 122);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.ReadOnly = true;
            this.txtAns2.Size = new System.Drawing.Size(415, 26);
            this.txtAns2.TabIndex = 41;
            // 
            // txtAns1
            // 
            this.txtAns1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAns1.Location = new System.Drawing.Point(62, 83);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.ReadOnly = true;
            this.txtAns1.Size = new System.Drawing.Size(415, 26);
            this.txtAns1.TabIndex = 40;
            // 
            // txtQText
            // 
            this.txtQText.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQText.Location = new System.Drawing.Point(36, 39);
            this.txtQText.Name = "txtQText";
            this.txtQText.ReadOnly = true;
            this.txtQText.Size = new System.Drawing.Size(441, 26);
            this.txtQText.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 38;
            // 
            // lblQ1Txt
            // 
            this.lblQ1Txt.AutoSize = true;
            this.lblQ1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1Txt.Location = new System.Drawing.Point(9, 42);
            this.lblQ1Txt.Name = "lblQ1Txt";
            this.lblQ1Txt.Size = new System.Drawing.Size(0, 20);
            this.lblQ1Txt.TabIndex = 11;
            // 
            // optFour
            // 
            this.optFour.AutoSize = true;
            this.optFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optFour.Location = new System.Drawing.Point(36, 202);
            this.optFour.Name = "optFour";
            this.optFour.Size = new System.Drawing.Size(14, 13);
            this.optFour.TabIndex = 37;
            this.optFour.UseVisualStyleBackColor = true;
            // 
            // optThree
            // 
            this.optThree.AutoSize = true;
            this.optThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optThree.Location = new System.Drawing.Point(36, 164);
            this.optThree.Name = "optThree";
            this.optThree.Size = new System.Drawing.Size(14, 13);
            this.optThree.TabIndex = 36;
            this.optThree.UseVisualStyleBackColor = true;
            // 
            // optTwo
            // 
            this.optTwo.AutoSize = true;
            this.optTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTwo.Location = new System.Drawing.Point(36, 129);
            this.optTwo.Name = "optTwo";
            this.optTwo.Size = new System.Drawing.Size(14, 13);
            this.optTwo.TabIndex = 35;
            this.optTwo.UseVisualStyleBackColor = true;
            // 
            // optOne
            // 
            this.optOne.AutoSize = true;
            this.optOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOne.Location = new System.Drawing.Point(36, 90);
            this.optOne.Name = "optOne";
            this.optOne.Size = new System.Drawing.Size(14, 13);
            this.optOne.TabIndex = 3;
            this.optOne.UseVisualStyleBackColor = true;
            // 
            // btnTTNxQ
            // 
            this.btnTTNxQ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTTNxQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTTNxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTNxQ.Location = new System.Drawing.Point(413, 466);
            this.btnTTNxQ.Name = "btnTTNxQ";
            this.btnTTNxQ.Size = new System.Drawing.Size(225, 50);
            this.btnTTNxQ.TabIndex = 4;
            this.btnTTNxQ.Text = "Next Question";
            this.btnTTNxQ.UseVisualStyleBackColor = false;
            this.btnTTNxQ.Click += new System.EventHandler(this.btnTTNxQ_Click);
            // 
            // pgbTestProgress
            // 
            this.pgbTestProgress.BackColor = System.Drawing.SystemColors.Menu;
            this.pgbTestProgress.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.pgbTestProgress.Location = new System.Drawing.Point(127, 478);
            this.pgbTestProgress.Maximum = 4;
            this.pgbTestProgress.Name = "pgbTestProgress";
            this.pgbTestProgress.Size = new System.Drawing.Size(241, 23);
            this.pgbTestProgress.TabIndex = 45;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(123, 111);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(75, 20);
            this.lblWelcome.TabIndex = 47;
            this.lblWelcome.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Test Id";
            // 
            // txtTestId
            // 
            this.txtTestId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTestId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestId.Location = new System.Drawing.Point(468, 112);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.ReadOnly = true;
            this.txtTestId.Size = new System.Drawing.Size(170, 19);
            this.txtTestId.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(204, 112);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(164, 19);
            this.txtName.TabIndex = 51;
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
            this.mnuMenuBar.TabIndex = 52;
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
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // frmTTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::TestSYS.Properties.Resources.bgd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuBar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTestId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pgbTestProgress);
            this.Controls.Add(this.btnTTNxQ);
            this.Controls.Add(this.grpTTQ1);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.cboTTLvl);
            this.Controls.Add(this.btnTTSubmit);
            this.Controls.Add(this.lblTTest);
            this.Name = "frmTTake";
            this.Text = "Test System - Take Test";
            this.Load += new System.EventHandler(this.frmTTake_Load);
            this.grpTTQ1.ResumeLayout(false);
            this.grpTTQ1.PerformLayout();
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTTSubmit;
        private System.Windows.Forms.Label lblTTest;
        private System.Windows.Forms.ComboBox cboTTLvl;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.GroupBox grpTTQ1;
        private System.Windows.Forms.Label lblQ1Txt;
        private System.Windows.Forms.RadioButton optFour;
        private System.Windows.Forms.RadioButton optThree;
        private System.Windows.Forms.RadioButton optTwo;
        private System.Windows.Forms.RadioButton optOne;
        private System.Windows.Forms.Button btnTTNxQ;
        private System.Windows.Forms.ProgressBar pgbTestProgress;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.TextBox txtQText;
        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.Label lblTitle;
    }
}