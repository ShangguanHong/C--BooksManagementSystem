using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem.View.ManagerView.UserManagerView
{
    public partial class ModifyUserMessager : Form
    {
        private User user;
        public ModifyUserMessager(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void ModifyUserMessage_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 用户信息修改";
            this.labelUserId.Text += user.Id.ToString();
            this.labelUserName.Text += user.Username;
            this.textBoxTrueName.Text = user.TrueName;
            this.textBoxTel.Text = user.Tel;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            user = UserController.updateUserByUserId(user.Id, user.Username, textBoxPassword.Text, textBoxTrueName.Text.Trim(), textBoxTel.Text.Trim(), user.Role);
            if(user != null)
            {
                DialogResult dr = MessageBox.Show("修改成功!是否退出此窗口", "修改信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    btnExit.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
