using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksManagementSystem.View.ManagerView;
using BooksManagementSystem.Model;
using BooksManagementSystem.View;
using BooksManagementSystem.View.ManagerView.BookManagerView;
using BooksManagementSystem.Controller;
namespace BooksManagementSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ManagerHome(UserController.getUserByUserId(6)));
            //Application.Run(new LoginForm());
            new LoginForm().Show();
            Application.Run();
        }
    }
}
