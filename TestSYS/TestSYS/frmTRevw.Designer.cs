namespace TestSYS
{
    partial class frmTRevw
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.btnFinishedReview = new System.Windows.Forms.Button();
            this.lstStudProfile = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(658, 35);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Tutorial Performance Test System ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.AutoSize = true;
            this.lblReviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewDate.Location = new System.Drawing.Point(141, 124);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(182, 20);
            this.lblReviewDate.TabIndex = 31;
            this.lblReviewDate.Text = "Review Tests Taken on:-";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTestDate.Location = new System.Drawing.Point(373, 124);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(205, 26);
            this.dtpTestDate.TabIndex = 32;
            this.dtpTestDate.ValueChanged += new System.EventHandler(this.dtpTestDate_ValueChanged);
            // 
            // btnFinishedReview
            // 
            this.btnFinishedReview.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinishedReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishedReview.Location = new System.Drawing.Point(528, 411);
            this.btnFinishedReview.Name = "btnFinishedReview";
            this.btnFinishedReview.Size = new System.Drawing.Size(113, 59);
            this.btnFinishedReview.TabIndex = 34;
            this.btnFinishedReview.Text = "Finished";
            this.btnFinishedReview.UseVisualStyleBackColor = false;
            // 
            // lstStudProfile
            // 
            this.lstStudProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudProfile.FormattingEnabled = true;
            this.lstStudProfile.ItemHeight = 20;
            this.lstStudProfile.Items.AddRange(new object[] {
            "Test Id \t\tDate Taken\t\tScore",
            "10022         \t20-11-2015        \t\t69%",
            "10023\t\t20-11-2015    \t\t75%",
            "10026\t\t20-11-2015\t\t86%",
            "10127\t\t20-11-2015\t\t97%\t"});
            this.lstStudProfile.Location = new System.Drawing.Point(145, 194);
            this.lstStudProfile.Name = "lstStudProfile";
            this.lstStudProfile.Size = new System.Drawing.Size(496, 124);
            this.lstStudProfile.TabIndex = 41;
            // 
            // frmTRevw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lstStudProfile);
            this.Controls.Add(this.btnFinishedReview);
            this.Controls.Add(this.dtpTestDate);
            this.Controls.Add(this.lblReviewDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTRevw";
            this.Text = "Test System -Review Test";
            this.Load += new System.EventHandler(this.frmTRevw_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Button btnFinishedReview;
        private System.Windows.Forms.ListBox lstStudProfile;
    }
}