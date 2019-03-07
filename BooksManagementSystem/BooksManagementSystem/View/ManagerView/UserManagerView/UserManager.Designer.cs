namespace BooksManagementSystem.View.ManagerView.UserManagerView
{
    partial class UserManager
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
            this.lab_username = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView_user_message = new System.Windows.Forms.ListView();
            this.userMessageId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userMessageUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userMessagePassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trueName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCommonUser = new System.Windows.Forms.Button();
            this.strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCommonAdmin = new System.Windows.Forms.Button();
            this.btnAddSuperAdmin = new System.Windows.Forms.Button();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_username
            // 
            this.lab_username.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lab_username.Location = new System.Drawing.Point(75, 43);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(105, 44);
            this.lab_username.TabIndex = 5;
            this.lab_username.Text = "关键字：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.username.Location = new System.Drawing.Point(169, 40);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(361, 34);
            this.username.TabIndex = 0;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSearch.Location = new System.Drawing.Point(257, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 47);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listView_user_message
            // 
            this.listView_user_message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userMessageId,
            this.userMessageUserName,
            this.userMessagePassword,
            this.trueName,
            this.tel,
            this.userRole});
            this.listView_user_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_user_message.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.listView_user_message.FullRowSelect = true;
            this.listView_user_message.GridLines = true;
            this.listView_user_message.Location = new System.Drawing.Point(0, 187);
            this.listView_user_message.Name = "listView_user_message";
            this.listView_user_message.Size = new System.Drawing.Size(831, 469);
            this.listView_user_message.TabIndex = 4;
            this.listView_user_message.UseCompatibleStateImageBehavior = false;
            this.listView_user_message.View = System.Windows.Forms.View.Details;
            this.listView_user_message.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_user_message_MouseClick);
            // 
            // userMessageId
            // 
            this.userMessageId.Text = "用户ID";
            this.userMessageId.Width = 104;
            // 
            // userMessageUserName
            // 
            this.userMessageUserName.Text = "用户名";
            this.userMessageUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userMessageUserName.Width = 115;
            // 
            // userMessagePassword
            // 
            this.userMessagePassword.Text = "用户密码(MD5加密)";
            this.userMessagePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userMessagePassword.Width = 213;
            // 
            // trueName
            // 
            this.trueName.Text = "用户姓名";
            this.trueName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trueName.Width = 112;
            // 
            // tel
            // 
            this.tel.Text = "联系方式";
            this.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tel.Width = 169;
            // 
            // userRole
            // 
            this.userRole.Text = "用户角色";
            this.userRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userRole.Width = 107;
            // 
            // btnAddCommonUser
            // 
            this.btnAddCommonUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddCommonUser.Location = new System.Drawing.Point(625, 23);
            this.btnAddCommonUser.Name = "btnAddCommonUser";
            this.btnAddCommonUser.Size = new System.Drawing.Size(168, 43);
            this.btnAddCommonUser.TabIndex = 3;
            this.btnAddCommonUser.Text = "增加普通用户";
            this.btnAddCommonUser.UseVisualStyleBackColor = true;
            this.btnAddCommonUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // strip
            // 
            this.strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteUserToolStripMenuItem,
            this.ModifyUserToolStripMenuItem});
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(145, 56);
            this.strip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Strip_ItemClicked);
            // 
            // DeleteUserToolStripMenuItem
            // 
            this.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem";
            this.DeleteUserToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.DeleteUserToolStripMenuItem.Text = "删除用户";
            // 
            // ModifyUserToolStripMenuItem
            // 
            this.ModifyUserToolStripMenuItem.Name = "ModifyUserToolStripMenuItem";
            this.ModifyUserToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.ModifyUserToolStripMenuItem.Text = "修改信息";
            // 
            // btnAddCommonAdmin
            // 
            this.btnAddCommonAdmin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddCommonAdmin.Location = new System.Drawing.Point(625, 72);
            this.btnAddCommonAdmin.Name = "btnAddCommonAdmin";
            this.btnAddCommonAdmin.Size = new System.Drawing.Size(168, 43);
            this.btnAddCommonAdmin.TabIndex = 2;
            this.btnAddCommonAdmin.Text = "增加普通管理员";
            this.btnAddCommonAdmin.UseVisualStyleBackColor = true;
            this.btnAddCommonAdmin.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddSuperAdmin
            // 
            this.btnAddSuperAdmin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddSuperAdmin.Location = new System.Drawing.Point(625, 121);
            this.btnAddSuperAdmin.Name = "btnAddSuperAdmin";
            this.btnAddSuperAdmin.Size = new System.Drawing.Size(168, 43);
            this.btnAddSuperAdmin.TabIndex = 1;
            this.btnAddSuperAdmin.Text = "增加超级管理员";
            this.btnAddSuperAdmin.UseVisualStyleBackColor = true;
            this.btnAddSuperAdmin.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 656);
            this.Controls.Add(this.btnAddSuperAdmin);
            this.Controls.Add(this.btnAddCommonAdmin);
            this.Controls.Add(this.btnAddCommonUser);
            this.Controls.Add(this.listView_user_message);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lab_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManager_FormClosed);
            this.Load += new System.EventHandler(this.UserManage_Load);
            this.strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView_user_message;
        private System.Windows.Forms.ColumnHeader userMessageId;
        private System.Windows.Forms.ColumnHeader userMessageUserName;
        private System.Windows.Forms.ColumnHeader userRole;
        private System.Windows.Forms.ColumnHeader trueName;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.Button btnAddCommonUser;
        private System.Windows.Forms.ContextMenuStrip strip;
        private System.Windows.Forms.ToolStripMenuItem DeleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyUserToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCommonAdmin;
        private System.Windows.Forms.ColumnHeader userMessagePassword;
        private System.Windows.Forms.Button btnAddSuperAdmin;
    }
}