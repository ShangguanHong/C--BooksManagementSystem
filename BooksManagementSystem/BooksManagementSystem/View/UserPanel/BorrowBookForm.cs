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

namespace BooksManagementSystem.View.UserPanel
{
    public partial class BorrowBookForm : Form
    {
        private string programName;
        private User user;
        private string isbn;

        public BorrowBookForm(User user, string isbn)
        {
            InitializeComponent();
            this.user = user;
            this.isbn = isbn;
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 借阅书籍";
        }
    
        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count > 0)
            {
                if(listViewBook.SelectedItems[0].SubItems[2].Text == "可供出借")
                {
                    int bookId = int.Parse(listViewBook.SelectedItems[0].SubItems[0].Text);
                    bool borrowSuccess = false;
                    if(BorrowController.createBorrow(user.Id, bookId, DateTime.Now, DateTime.Now.AddDays(30)))
                    {
                        if(BookController.updateBookBorrowStatusByBookId(bookId, true))
                        {
                            if(BookDetailController.decreaseBookLeftNumByISBN(BookController.getISBNByBookId(bookId)))
                            {
                                borrowSuccess = true;
                            }
                        }
                    }
                    if (borrowSuccess)
                    {
                        listViewBook.Items.Clear();
                        fillBookListView();
                        MessageBox.Show("借阅成功！\n最晚归还时间为：" + DateTime.Now.AddDays(30).ToShortDateString());
                    }
                    else
                    {
                        MessageBox.Show("借阅失败！");
                    }
                }
                else
                {
                    MessageBox.Show("借阅失败！请选择未被借阅的图书！");
                }
            }
            else
            {
                MessageBox.Show("请先选择您要借阅的图书！");
            }
        }

        private void BorrowBookForm_Shown(object sender, EventArgs e)
        {
            fillBookListView();
        }
        
        private void fillBookListView()
        {
            List<Book> bookList = BookController.getBookListByISBN(isbn);
            foreach (Book book in bookList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = book.Id.ToString();
                listViewItem.SubItems.Add(book.Location);
                listViewItem.SubItems.Add(book.IsBorrow ? "已出借" : "可供出借");
                listViewBook.Items.Add(listViewItem);
            }
        }
    }
}
