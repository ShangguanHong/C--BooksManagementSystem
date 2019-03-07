using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksManagementSystem.Util;
using MySql.Data.MySqlClient;
using System.Configuration;
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using BooksManagementSystem.View.ManagerView;

namespace BooksManagementSystem.View
{
    public partial class LoginForm : Form
    {
        private string programName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 登录";
            labelProgramTitle.Text = programName;
        }

        private bool isFormComplete()
        {
            return textBoxUsername.Text.Length != 0 && textBoxPassword.Text.Length != 0;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(isFormComplete())
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                User user = UserController.login(username, password);
                if(user != null)
                {
                    if (user.Role == User.UserRole.commonUser)
                    {
                        new UserPanel.UserMainForm(user).Show();
                    } else
                    {
                        new ManagerHome(user).Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登录失败，请检查用户名与密码是否正确！");
                }
            }
            else
            {
                MessageBox.Show("请确保用户名与密码输入完整！");
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterForm(User.UserRole.commonUser, "请填写以下信息以完成注册");
            registerForm.ShowDialog();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
