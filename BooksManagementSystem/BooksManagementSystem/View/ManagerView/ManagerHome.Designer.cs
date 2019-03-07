namespace BooksManagementSystem.View.ManagerView
{
    partial class ManagerHome
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.btnBookManage = new System.Windows.Forms.Button();
            this.btnBorrowManage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.statusStripBottomStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerBottomStatusTimeFresher = new System.Windows.Forms.Timer(this.components);
            this.buttonCategoryManager = new System.Windows.Forms.Button();
            this.statusStripBottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserManage
            // 
            this.btnUserManage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUserManage.Location = new System.Drawing.Point(51, 162);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(150, 150);
            this.btnUserManage.TabIndex = 1;
            this.btnUserManage.Text = "用户管理";
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // btnBookManage
            // 
            this.btnBookManage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBookManage.Location = new System.Drawing.Point(245, 162);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Size = new System.Drawing.Size(150, 150);
            this.btnBookManage.TabIndex = 2;
            this.btnBookManage.Text = "图书管理";
            this.btnBookManage.UseVisualStyleBackColor = true;
            this.btnBookManage.Click += new System.EventHandler(this.btnBookManage_Click);
            // 
            // btnBorrowManage
            // 
            this.btnBorrowManage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBorrowManage.Location = new System.Drawing.Point(637, 162);
            this.btnBorrowManage.Name = "btnBorrowManage";
            this.btnBorrowManage.Size = new System.Drawing.Size(150, 150);
            this.btnBorrowManage.TabIndex = 4;
            this.btnBorrowManage.Text = "借阅查询";
            this.btnBorrowManage.UseVisualStyleBackColor = true;
            this.btnBorrowManage.Click += new System.EventHandler(this.btnBorrowManage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExit.Location = new System.Drawing.Point(838, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 150);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWelcome.Location = new System.Drawing.Point(12, 36);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(1008, 77);
            this.labelWelcome.TabIndex = 8;
            this.labelWelcome.Text = "label1";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
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
            this.statusStripBottomStatus.Location = new System.Drawing.Point(0, 355);
            this.statusStripBottomStatus.Name = "statusStripBottomStatus";
            this.statusStripBottomStatus.Size = new System.Drawing.Size(1032, 25);
            this.statusStripBottomStatus.SizingGrip = false;
            this.statusStripBottomStatus.TabIndex = 9;
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(218, 20);
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(218, 20);
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
            // buttonCategoryManager
            // 
            this.buttonCategoryManager.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonCategoryManager.Location = new System.Drawing.Point(441, 162);
            this.buttonCategoryManager.Name = "buttonCategoryManager";
            this.buttonCategoryManager.Size = new System.Drawing.Size(150, 150);
            this.buttonCategoryManager.TabIndex = 3;
            this.buttonCategoryManager.Text = "分类管理";
            this.buttonCategoryManager.UseVisualStyleBackColor = true;
            this.buttonCategoryManager.Click += new System.EventHandler(this.buttonCategoryManager_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 380);
            this.Controls.Add(this.buttonCategoryManager);
            this.Controls.Add(this.statusStripBottomStatus);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBorrowManage);
            this.Controls.Add(this.btnBookManage);
            this.Controls.Add(this.btnUserManage);
            this.MaximizeBox = false;
            this.Name = "ManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerHome_FormClosed);
            this.Load += new System.EventHandler(this.ManageHome_Load);
            this.statusStripBottomStatus.ResumeLayout(false);
            this.statusStripBottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button btnBookManage;
        private System.Windows.Forms.Button btnBorrowManage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.StatusStrip statusStripBottomStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsername;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentTime;
        private System.Windows.Forms.Timer timerBottomStatusTimeFresher;
        private System.Windows.Forms.Button buttonCategoryManager;
    }
}

