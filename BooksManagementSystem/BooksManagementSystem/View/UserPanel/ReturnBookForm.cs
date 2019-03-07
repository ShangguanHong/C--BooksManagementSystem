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
    public partial class ReturnBookForm : Form
    {
        private string programName;
        private User user;
        private Form form;
        public ReturnBookForm(User user, Form form)
        {
            InitializeComponent();
            this.user = user;
            this.form = form;
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 归还书籍";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if(listViewBorrowInfo.SelectedItems.Count > 0)
            {
                int bookId = int.Parse(listViewBorrowInfo.SelectedItems[0].SubItems[0].Text);
                int borrowId = int.Parse(listViewBorrowInfo.SelectedItems[0].SubItems[7].Text);
                string isbn = listViewBorrowInfo.SelectedItems[0].SubItems[4].Text;
                bool returnSuccess = false;
                if(BookController.updateBookBorrowStatusByBookId(bookId, false))
                {
                    if(BorrowController.cancelBorrowByBorrowId(borrowId, DateTime.Now))
                    {
                        if(BookDetailController.increaseBookLeftNumByISBN(isbn))
                        {
                            returnSuccess = true;
                        }
                    }
                }
                if(returnSuccess)
                {
                    MessageBox.Show("归还成功！");
                    listViewBorrowInfo.Items.Clear();
                    fillBorrowListView();
                }
                else
                {
                    MessageBox.Show("归还失败！");
                }
            }
            else
            {
                MessageBox.Show("请先选择要归还的图书！");
            }
        }

        private void fillBorrowListView()
        {
            List<Borrow> borrowList = BorrowController.getBorrowListByUserId(user.Id);
            foreach (Borrow borrow in borrowList)
            {
                BookDetail bookDetail = BookController.getBookDetailByBookId(borrow.BookId);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = borrow.BookId.ToString();
                listViewItem.SubItems.Add(bookDetail.Name);
                listViewItem.SubItems.Add(bookDetail.Author);
                listViewItem.SubItems.Add(bookDetail.Press);
                listViewItem.SubItems.Add(bookDetail.Isbn);
                listViewItem.SubItems.Add(borrow.BorrowDate.ToString());
                listViewItem.SubItems.Add(borrow.LastReturnDate.ToString());
                listViewItem.SubItems.Add(borrow.Id.ToString());
                listViewBorrowInfo.Items.Add(listViewItem);
            }
        }

        private void ReturnBookForm_Shown(object sender, EventArgs e)
        {
            fillBorrowListView();
        }

        private void ReturnBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
