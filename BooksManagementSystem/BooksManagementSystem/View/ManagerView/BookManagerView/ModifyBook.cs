using BooksManagementSystem.Model;
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
    public partial class ModifyBook : BookForm
    {
        Book book;
        public ModifyBook(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void ModifyBook_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 修改图书信息";
            this.lab_ISBN.Text = "修改该书的ISBN:";
            this.labelLaction.Text = "修改该书的存放地:";
            this.labelID.Text += book.Id.ToString();
            this.ISBN.Text = book.Isbn;
            this.locaiton.Text = book.Location;
            this.ISBN.Focus();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (BookController.updateBookByBookId(book.Id, ISBN.Text.Trim(), this.locaiton.Text.Trim()))
            {
                MessageBox.Show("修改书籍信息成功!");
            }
            else
            {
                MessageBox.Show("修改书籍信息失败!");
            }
            this.ISBN.Focus();
        }

        private void lab_ISBN_Click(object sender, EventArgs e)
        {

        }
    }
}
