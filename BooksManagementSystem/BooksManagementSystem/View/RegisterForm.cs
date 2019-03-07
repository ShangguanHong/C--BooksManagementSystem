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
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;

namespace BooksManagementSystem.View
{
    public partial class RegisterForm : Form
    {
        private string programName;
        private string message;
        private User.UserRole registerUserRole;

        public RegisterForm(User.UserRole registerUserRole, string message)
        {
            InitializeComponent();
            this.registerUserRole = registerUserRole;
            this.message = message;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 注册";
            this.labelHint.Text = message;
        }

        private bool isFormComplete()
        {
            return textBoxUsername.Text.Length != 0 && textBoxPassword.Text.Length != 0 && textBoxRePassword.Text.Length != 0 && textBoxTrueName.Text.Length != 0 && textBoxTel.Text.Length != 0;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(isFormComplete())
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text;
                string rePassword = textBoxRePassword.Text;
                string trueName = textBoxTrueName.Text.Trim();
                string tel = textBoxTel.Text.Trim();
                if(password == rePassword)
                {
                    User user = UserController.createUser(username, password, trueName, tel, registerUserRole);
                    if(user != null)
                    {
                        MessageBox.Show("注册成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！");
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致，请检查后重新输入！");
                }
            }
            else
            {
                MessageBox.Show("请确保注册信息的每一项都输入完整！");
            }
        }

        private void RegisterForm_Shown(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonRegister.PerformClick();
            }else if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}
