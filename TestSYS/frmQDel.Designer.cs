namespace TestSYS
{
    partial class frmQDel
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
            this.btnDelQ = new System.Windows.Forms.Button();
            this.lblDelPwdTitle = new System.Windows.Forms.Label();
            this.txtConfPwd = new System.Windows.Forms.TextBox();
            this.txtDelPwd = new System.Windows.Forms.TextBox();
            this.lblDelQTxt = new System.Windows.Forms.Label();
            this.txtQTxt = new System.Windows.Forms.TextBox();
            this.lblQDel = new System.Windows.Forms.Label();
            this.txtDelQID = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblDelPwd = new System.Windows.Forms.Label();
            this.lblConfPwd = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // btnDelQ
            // 
            this.btnDelQ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelQ.Location = new System.Drawing.Point(430, 443);
            this.btnDelQ.Name = "btnDelQ";
            this.btnDelQ.Size = new System.Drawing.Size(225, 50);
            this.btnDelQ.TabIndex = 5;
            this.btnDelQ.Text = "Delete";
            this.btnDelQ.UseVisualStyleBackColor = false;
            this.btnDelQ.Click += new System.EventHandler(this.btnDelQ_Click);
            // 
            // lblDelPwdTitle
            // 
            this.lblDelPwdTitle.AutoSize = true;
            this.lblDelPwdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelPwdTitle.Location = new System.Drawing.Point(123, 251);
            this.lblDelPwdTitle.Name = "lblDelPwdTitle";
            this.lblDelPwdTitle.Size = new System.Drawing.Size(245, 20);
            this.lblDelPwdTitle.TabIndex = 9;
            this.lblDelPwdTitle.Text = "Enter and Confirm your Password";
            // 
            // txtConfPwd
            // 
            this.txtConfPwd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPwd.Location = new System.Drawing.Point(266, 355);
            this.txtConfPwd.Name = "txtConfPwd";
            this.txtConfPwd.PasswordChar = '*';
            this.txtConfPwd.Size = new System.Drawing.Size(389, 26);
            this.txtConfPwd.TabIndex = 4;
            // 
            // txtDelPwd
            // 
            this.txtDelPwd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelPwd.Location = new System.Drawing.Point(266, 297);
            this.txtDelPwd.Name = "txtDelPwd";
            this.txtDelPwd.PasswordChar = '*';
            this.txtDelPwd.Size = new System.Drawing.Size(389, 26);
            this.txtDelPwd.TabIndex = 3;
            // 
            // lblDelQTxt
            // 
            this.lblDelQTxt.AutoSize = true;
            this.lblDelQTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelQTxt.Location = new System.Drawing.Point(123, 187);
            this.lblDelQTxt.Name = "lblDelQTxt";
            this.lblDelQTxt.Size = new System.Drawing.Size(107, 20);
            this.lblDelQTxt.TabIndex = 8;
            this.lblDelQTxt.Text = "Question Text";
            // 
            // txtQTxt
            // 
            this.txtQTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTxt.Location = new System.Drawing.Point(266, 189);
            this.txtQTxt.Name = "txtQTxt";
            this.txtQTxt.ReadOnly = true;
            this.txtQTxt.Size = new System.Drawing.Size(389, 19);
            this.txtQTxt.TabIndex = 2;
            // 
            // lblQDel
            // 
            this.lblQDel.AutoSize = true;
            this.lblQDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQDel.Location = new System.Drawing.Point(123, 135);
            this.lblQDel.Name = "lblQDel";
            this.lblQDel.Size = new System.Drawing.Size(325, 20);
            this.lblQDel.TabIndex = 7;
            this.lblQDel.Text = "Please enter Question ID to be Deleted";
            // 
            // txtDelQID
            // 
            this.txtDelQID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelQID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelQID.Location = new System.Drawing.Point(454, 129);
            this.txtDelQID.Name = "txtDelQID";
            this.txtDelQID.Size = new System.Drawing.Size(201, 26);
            this.txtDelQID.TabIndex = 1;
            this.txtDelQID.TextChanged += new System.EventHandler(this.txtDelQID_TextChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(127, 443);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(225, 50);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblDelPwd
            // 
            this.lblDelPwd.AutoSize = true;
            this.lblDelPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelPwd.Location = new System.Drawing.Point(123, 300);
            this.lblDelPwd.Name = "lblDelPwd";
            this.lblDelPwd.Size = new System.Drawing.Size(78, 20);
            this.lblDelPwd.TabIndex = 10;
            this.lblDelPwd.Text = "Password";
            // 
            // lblConfPwd
            // 
            this.lblConfPwd.AutoSize = true;
            this.lblConfPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPwd.Location = new System.Drawing.Point(123, 358);
            this.lblConfPwd.Name = "lblConfPwd";
            this.lblConfPwd.Size = new System.Drawing.Size(137, 20);
            this.lblConfPwd.TabIndex = 11;
            this.lblConfPwd.Text = "Confirm Password";
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
            // frmQDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::TestSYS.Properties.Resources.bgd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblConfPwd);
            this.Controls.Add(this.lblDelPwd);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txtDelQID);
            this.Controls.Add(this.btnDelQ);
            this.Controls.Add(this.lblDelPwdTitle);
            this.Controls.Add(this.txtConfPwd);
            this.Controls.Add(this.txtDelPwd);
            this.Controls.Add(this.lblDelQTxt);
            this.Controls.Add(this.txtQTxt);
            this.Controls.Add(this.lblQDel);
            this.Controls.Add(this.mnuMenuBar);
            this.DoubleBuffered = true;
            this.Name = "frmQDel";
            this.Text = "Test System - Delete Question";
            this.Load += new System.EventHandler(this.frmQDel_Load);
            this.mnuMenuBar.ResumeLayout(false);
            this.mnuMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnDelQ;
        private System.Windows.Forms.Label lblDelPwdTitle;
        private System.Windows.Forms.TextBox txtConfPwd;
        private System.Windows.Forms.TextBox txtDelPwd;
        private System.Windows.Forms.Label lblDelQTxt;
        private System.Windows.Forms.TextBox txtQTxt;
        private System.Windows.Forms.Label lblQDel;
        private System.Windows.Forms.TextBox txtDelQID;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblDelPwd;
        private System.Windows.Forms.Label lblConfPwd;
        private System.Windows.Forms.Label lblTitle;
    }
}