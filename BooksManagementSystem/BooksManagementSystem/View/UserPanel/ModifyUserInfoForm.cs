using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BooksManagementSystem.Model;
using BooksManagementSystem.Controller;

namespace BooksManagementSystem.View.UserPanel
{
    public partial class ModifyUserInfoForm : Form
    {
        private string programName;
        private User user;
        private Form form;
        public ModifyUserInfoForm(int userId, Form form)
        {
            InitializeComponent();
            this.user = UserController.getUserByUserId(userId);
            this.form = form;
        }

        private void ModifyUserInfoForm_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 修改资料";
        }

        private void ModifyUserInfoForm_Shown(object sender, EventArgs e)
        {
            textBoxTel.Text = user.Tel;
            textBoxTrueName.Text = user.TrueName;
            textBoxUsername.Text = user.Username;
        }

        private void buttonModifyUserInfo_Click(object sender, EventArgs e)
        {
            if(isFormComplete())
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text;
                string rePassword = textBoxRePassword.Text;
                string trueName = textBoxTrueName.Text;
                string tel = textBoxTel.Text;
                if (password == rePassword)
                {
                    user = UserController.updateUserByUserId(user.Id, username, password, trueName, tel, User.UserRole.commonUser);
                    if(user != null)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致！");
                }
            }
            else
            {
                MessageBox.Show("请填写除了密码之外的其他项！");
            }
        }

        private bool isFormComplete()
        {
            return textBoxUsername.Text.Length != 0 && textBoxTrueName.Text.Length != 0 && textBoxTel.Text.Length != 0;
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonModifyUserInfo.PerformClick();
            }
            else if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModifyUserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
