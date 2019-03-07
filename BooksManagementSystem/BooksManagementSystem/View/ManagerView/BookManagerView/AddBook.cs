using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BooksManagementSystem.Controller;

namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    public partial class AddBook : BookForm
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (BookController.createBook(ISBN.Text.Trim(), this.locaiton.Text.Trim()) && BookDetailController.increaseBookLeftNumByISBN(ISBN.Text.Trim()) && BookDetailController.increaseBookTotalNumByISBN(ISBN.Text.Trim()))
            {
                MessageBox.Show("添加书籍成功!");
            }
            else
            {
                MessageBox.Show("添加书籍失败！请确认输入的ISBN是否正确！");
            }
            ISBN.Focus();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 新增图书";
        }
    }
}
