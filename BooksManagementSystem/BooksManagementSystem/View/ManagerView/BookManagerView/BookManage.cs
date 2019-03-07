using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using BooksManagementSystem.View.ManagerView.UserManagerView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    public partial class BookManage : Form
    {
        private Form form;
        User admin;
        List<Book> books;
        string message;
        public BookManage(User admin, Form form)
        {
            InitializeComponent();
            this.admin = admin;
            this.form = form;
        }
        private void textboxBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            books = BookController.searchBookByKeyword(textBoxBookName.Text.Trim());
            Update_ListView_Book_Message();
        }

        private void BookManage_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 书籍管理";
            books = BookController.getAllBookList();
            Update_ListView_Book_Message();
            if(admin.Role != User.UserRole.superAdmin)
            {
                this.btnISBN.Hide();
            }
        }
        private void ListView_user_message_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listView_book_message.SelectedItems.Count != 0)
            {
                message = "";
                ListViewItem item = listView_book_message.SelectedItems[0];
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    message = message + item.SubItems[i].Text.ToString() + " ";
                }
                message.Trim();
                this.strip.Show(listView_book_message, e.Location);//鼠标右键按下弹出菜单
            }
        }

        private void Update_ListView_Book_Message()
        {
            this.listView_book_message.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            this.listView_book_message.Items.Clear();
            for (int i = 0; i < books.Count; i++)   
            {
                Book book = books[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = book.Id.ToString();
                lvi.SubItems.Add(book.Isbn);
                BookDetail bookDetail = BookDetailController.getBookDetailByISBN(book.Isbn);
                lvi.SubItems.Add(bookDetail.Name);
                lvi.SubItems.Add(bookDetail.Author);
                lvi.SubItems.Add(book.Location);
                if(!book.IsBorrow)
                {
                    lvi.SubItems.Add("未借出");
                } else
                {
                    lvi.SubItems.Add("已经借出");
                }
                this.listView_book_message.Items.Add(lvi);
            }
            this.listView_book_message.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }
        private void Strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            strip.Close();
            Book book = books[listView_book_message.Items[listView_book_message.SelectedIndices[0]].Index];
            if (e.ClickedItem.Name == "DeleteToolStripMenuItem")
            {
                string[] messages = message.Split(' ');
                DialogResult dr = MessageBox.Show("确认删除书目条码为" + messages[0] + "的书籍吗?", "删除书籍警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (BookController.deleteBookById(book.Id))
                    {
                        MessageBox.Show("删除书籍成功!");
                        btnSearch.PerformClick();
                    } else
                    {
                        MessageBox.Show("删除书籍失败!");
                    }
                }
            }
            else
            {
                ModifyBook modify = new ModifyBook(book);
                modify.ShowDialog();           
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.ShowDialog();
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            new ISBNManage().ShowDialog();
        }

        private void BookManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void labelBookName_Click(object sender, EventArgs e)
        {

        }
    }
}
