using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using System.Configuration;

namespace BooksManagementSystem.View.ManagerView.UserManagerView
{
    public partial class UserManager : Form
    {
        private Form form;
        User admin;
        List<User> users;
        string message = "";
        public UserManager(User admin, Form form)
        {
            InitializeComponent();
            this.admin = admin;
            this.form = form;
        }
        private void UserManage_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 用户管理";
            this.username.Focus();
            users = UserController.getAllUser();
            Update_ListView_User_Message();
            if (admin.Role != User.UserRole.superAdmin)
            {
                btnAddCommonAdmin.Hide();
                btnAddCommonUser.Hide();
                btnAddSuperAdmin.Hide();
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            users = UserController.searchUserByKeyword(username.Text.Trim());
            Update_ListView_User_Message();
        }
        //超级管理员可用
        private void ListView_user_message_MouseClick(object sender, MouseEventArgs e)
        {
            if (admin.Role == User.UserRole.superAdmin)
            {
                if (e.Button == MouseButtons.Right && listView_user_message.SelectedItems.Count != 0)
                {
                    message = "";
                    ListViewItem item = listView_user_message.SelectedItems[0];
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        message = message + item.SubItems[i].Text.ToString() + " ";
                    }
                    message.Trim();
                    strip.Show(listView_user_message, e.Location);//鼠标右键按下弹出菜单
                }
            }         
        }
        //超级管理员可用
        //private void ListView_user_message_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    if (admin.Role == User.UserRole.superAdmin)
        //    {
        //        if (e.Button == MouseButtons.Left && listView_user_message.SelectedItems.Count != 0)
        //        {
        //            message = "";
        //            ListViewItem lvi = listView_user_message.GetItemAt(e.X, e.Y);
        //            for (int i = 0; i < lvi.SubItems.Count; i++)
        //            {
        //                message = message + lvi.SubItems[i].Text.ToString() + " ";
        //            }
        //            ListViewItem.ListViewSubItem lvsi = lvi.GetSubItemAt(e.X, e.Y);
        //            int colIndex = lvi.SubItems.IndexOf(lvsi);
        //            if (colIndex > 1 && colIndex != 5)
        //            {
        //                ModifyUserMessage modify = new ModifyUserMessage(message, colIndex);
        //                modify.Show();
        //            }
        //        }
        //    }
        //}
        //超级管理员可用
        private void Strip_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (admin.Role == User.UserRole.superAdmin)
            {
                strip.Close();
                if (e.ClickedItem.Name == "DeleteUserToolStripMenuItem")
                {
                    string[] messages = message.Split(' ');
                    DialogResult dr = MessageBox.Show("确认删除用户名为" + messages[1] + "的用户吗?", "删除用户警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (UserController.deleteUserByUsername(messages[1]))
                        {
                            btnSearch.PerformClick();
                            MessageBox.Show("删除此用户成功!");
                        }
                        else
                        {
                            MessageBox.Show("删除此用户失败!");
                        }
                    }
                }
                else
                {
                    new ModifyUserMessager(users[listView_user_message.Items[listView_user_message.SelectedIndices[0]].Index]).Show();
                }
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RegisterForm register;
            if (btn.Name == "btnAddCommonUser")
            {
                register = new RegisterForm(User.UserRole.commonUser, "您正在注册普通用户");
            } else if(btn.Name == "btnAddCommonAdmin")
            {
                register = new RegisterForm(User.UserRole.commonAdmin, "您正在注册普通管理员");
            } else
            {
                register = new RegisterForm(User.UserRole.superAdmin, "您正在注册超级管理员");
            }
            register.ShowDialog();
            if (register.DialogResult == DialogResult.OK)
            {
                btnSearch.PerformClick();
            }
        }
        private void Update_ListView_User_Message()
        {
            this.listView_user_message.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            this.listView_user_message.Items.Clear();
            for (int i = 0; i < users.Count; i++)   
            {
                User user = users[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = user.Id.ToString();
                lvi.SubItems.Add(user.Username);
                lvi.SubItems.Add(user.Password);
                lvi.SubItems.Add(user.TrueName);
                lvi.SubItems.Add(user.Tel);
                if (user.Role == User.UserRole.superAdmin)
                {
                    lvi.SubItems.Add("超级管理员");
                }
                else if (user.Role == User.UserRole.commonAdmin)
                {
                    lvi.SubItems.Add("普通管理员");
                }
                else
                {
                    lvi.SubItems.Add("普通用户");
                }
                this.listView_user_message.Items.Add(lvi);
            }
            this.listView_user_message.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void UserManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
