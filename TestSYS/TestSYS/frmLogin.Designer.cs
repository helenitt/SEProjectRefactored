namespace TestSYS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoginSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudID = new System.Windows.Forms.Label();
            this.lblStudPssword = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.picBulb = new System.Windows.Forms.PictureBox();
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
            this.mnuMenuBar.TabIndex = 7;
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
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoginSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSubmit.Location = new System.Drawing.Point(429, 385);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(201, 50);
            this.btnLoginSubmit.TabIndex = 3;
            this.btnLoginSubmit.Text = "SUBMIT";
            this.btnLoginSubmit.UseVisualStyleBackColor = false;
            this.btnLoginSubmit.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudID.Location = new System.Drawing.Point(425, 184);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(153, 20);
            this.lblStudID.TabIndex = 4;
            this.lblStudID.Text = "Please enter your ID";
            // 
            // lblStudPssword
            // 
            this.lblStudPssword.AutoSize = true;
            this.lblStudPssword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudPssword.Location = new System.Drawing.Point(425, 285);
            this.lblStudPssword.Name = "lblStudPssword";
            this.lblStudPssword.Size = new System.Drawing.Size(205, 20);
            this.lblStudPssword.TabIndex = 5;
            this.lblStudPssword.Text = "Please enter your Password";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(429, 220);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 26);
            this.txtID.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(429, 318);
            this.txtPassWord.MaxLength = 8;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(201, 26);
            this.txtPassWord.TabIndex = 2;
            // 
            // picBulb
            // 
            this.picBulb.Image = ((System.Drawing.Image)(resources.GetObject("picBulb.Image")));
            this.picBulb.Location = new System.Drawing.Point(76, 132);
            this.picBulb.Name = "picBulb";
            this.picBulb.Size = new System.Drawing.Size(253, 361);
            this.picBulb.TabIndex = 28;
            this.picBulb.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblStudPssword);
            this.Controls.Add(this.picBulb);
            this.Controls.Add(this.lblStudID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLoginSubmit);
            this.Controls.Add(this.mnuMenuBar);
            this.Location = new System.Drawing.Point(76, 132);
            this.Name = "frmLogin";
            this.Text = "Test System - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
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
        private System.Windows.Forms.Button btnLoginSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.PictureBox picBulb;
        private System.Windows.Forms.Label lblStudPssword;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.TextBox txtPassWord;
    }
}