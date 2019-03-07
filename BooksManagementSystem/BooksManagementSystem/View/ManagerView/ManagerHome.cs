using System;
using System.Windows.Forms;
using System.Configuration;
using BooksManagementSystem.Model;
using BooksManagementSystem.View.ManagerView.UserManagerView;
using BooksManagementSystem.View.ManagerView.BookManagerView;
using BooksManagementSystem.View.ManagerView.BorrowManagerView;
using BooksManagementSystem.View.ManagerView.CategoryManagerView;

namespace BooksManagementSystem.View.ManagerView
{
    public partial class ManagerHome : Form
    {
        User admin;
        public ManagerHome(User admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            new UserManager(admin, this).Show();
            this.Hide();
        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
            new BookManage(admin, this).Show();
            this.Hide();
        }

        private void ManageHome_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 管理员界面";
            if(admin.Role == User.UserRole.commonAdmin)
            {
                this.labelWelcome.Text = "欢迎管理员:" + admin.TrueName;
            } else
            {
                this.labelWelcome.Text = "欢迎超级管理员:" + admin.TrueName;
            }
            toolStripStatusLabelUsername.Text = "当前登录管理员：" + admin.Username;
            freshDateTime();
            timerBottomStatusTimeFresher.Start();
        }

        private void btnBorrowManage_Click(object sender, EventArgs e)
        {
            new BorrowManager(this).Show();
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

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void ManagerHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCategoryManager_Click(object sender, EventArgs e)
        {
            new CategoryManager(this).Show();
            this.Hide();
        }
    }
}
