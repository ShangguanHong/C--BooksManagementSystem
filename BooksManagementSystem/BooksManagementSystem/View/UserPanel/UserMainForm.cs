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
using BooksManagementSystem.Util;

namespace BooksManagementSystem.View.UserPanel
{
    public partial class UserMainForm : Form
    {
        private string programName;
        private User user;


        public UserMainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 用户操作面板";
            toolStripStatusLabelUsername.Text = "当前登录用户：" + user.Username;
            freshDateTime();
            timerBottomStatusTimeFresher.Start();
            labelWelcome.Text = OtherUtil.getWelcomeString() + user.TrueName + ", 欢迎使用" + programName;
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            new ReturnBookForm(user, this).Show();
            this.Hide();
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            new SearchBookForm(user, this).Show();
            this.Hide();
        }

        private void buttonModifyUserInfo_Click(object sender, EventArgs e)
        {
            new ModifyUserInfoForm(user.Id, this).Show();
            this.Hide();
        }


        private void freshDateTime()
        {
            toolStripStatusLabelCurrentDate.Text = "今天是" + DateTime.Now.ToLongDateString();
            toolStripStatusLabelCurrentTime.Text = "当前时间：" + DateTime.Now.ToLongTimeString();
        }

        private void timerBottomStatusTimeFresher_Tick(object sender, EventArgs e)
        {
            freshDateTime();
        }

        private void UserMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
