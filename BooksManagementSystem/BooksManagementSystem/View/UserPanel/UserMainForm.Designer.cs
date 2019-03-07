namespace BooksManagementSystem.View.UserPanel
{
    partial class UserMainForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.buttonModifyUserInfo = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.statusStripBottomStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerBottomStatusTimeFresher = new System.Windows.Forms.Timer(this.components);
            this.labelWelcome = new System.Windows.Forms.Label();
            this.statusStripBottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturnBook.Location = new System.Drawing.Point(280, 127);
            this.buttonReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(150, 150);
            this.buttonReturnBook.TabIndex = 1;
            this.buttonReturnBook.Text = "归还书籍";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // buttonModifyUserInfo
            // 
            this.buttonModifyUserInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonModifyUserInfo.Location = new System.Drawing.Point(510, 127);
            this.buttonModifyUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyUserInfo.Name = "buttonModifyUserInfo";
            this.buttonModifyUserInfo.Size = new System.Drawing.Size(150, 150);
            this.buttonModifyUserInfo.TabIndex = 2;
            this.buttonModifyUserInfo.Text = "修改资料";
            this.buttonModifyUserInfo.UseVisualStyleBackColor = true;
            this.buttonModifyUserInfo.Click += new System.EventHandler(this.buttonModifyUserInfo_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearchBook.Location = new System.Drawing.Point(46, 127);
            this.buttonSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(150, 150);
            this.buttonSearchBook.TabIndex = 0;
            this.buttonSearchBook.Text = "查询书籍";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // statusStripBottomStatus
            // 
            this.statusStripBottomStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripBottomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUsername,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelCurrentDate,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelCurrentTime});
            this.statusStripBottomStatus.Location = new System.Drawing.Point(0, 324);
            this.statusStripBottomStatus.Name = "statusStripBottomStatus";
            this.statusStripBottomStatus.Size = new System.Drawing.Size(720, 25);
            this.statusStripBottomStatus.SizingGrip = false;
            this.statusStripBottomStatus.TabIndex = 6;
            this.statusStripBottomStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUsername
            // 
            this.toolStripStatusLabelUsername.Name = "toolStripStatusLabelUsername";
            this.toolStripStatusLabelUsername.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabelUsername.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabelCurrentDate
            // 
            this.toolStripStatusLabelCurrentDate.Name = "toolStripStatusLabelCurrentDate";
            this.toolStripStatusLabelCurrentDate.Size = new System.Drawing.Size(247, 20);
            this.toolStripStatusLabelCurrentDate.Text = "toolStripStatusLabelCurrentDate";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabelCurrentTime
            // 
            this.toolStripStatusLabelCurrentTime.Name = "toolStripStatusLabelCurrentTime";
            this.toolStripStatusLabelCurrentTime.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabelCurrentTime.Text = "toolStripStatusLabel2";
            // 
            // timerBottomStatusTimeFresher
            // 
            this.timerBottomStatusTimeFresher.Interval = 800;
            this.timerBottomStatusTimeFresher.Tick += new System.EventHandler(this.timerBottomStatusTimeFresher_Tick);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWelcome.Location = new System.Drawing.Point(12, 22);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(696, 77);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "label1";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 349);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.statusStripBottomStatus);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.buttonModifyUserInfo);
            this.Controls.Add(this.buttonReturnBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMainForm_FormClosed);
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.statusStripBottomStatus.ResumeLayout(false);
            this.statusStripBottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Button buttonModifyUserInfo;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.StatusStrip statusStripBottomStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsername;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentTime;
        private System.Windows.Forms.Timer timerBottomStatusTimeFresher;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label labelWelcome;
    }
}