using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using System.Configuration;

namespace BooksManagementSystem.View.UserPanel
{
    public partial class SearchBookForm : Form
    {
        private string programName;
        private User user;
        private Dictionary<string, string> categoryDict = new Dictionary<string, string>();
        private Form form;

        public SearchBookForm(User user, Form form)
        {
            InitializeComponent();
            this.user = user;
            this.form = form;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            listViewBookDetail.Items.Clear();
            string bookName = textBoxBookName.Text.Trim();
            List<BookDetail> bookDetailList = BookDetailController.searchBookDetailByBookName(bookName);
            if (bookDetailList.Count == 0)
            {
                MessageBox.Show("未找到与\"" + bookName + "\"相关的书籍！");
            }
            else
            {
                foreach (BookDetail bookDetail in bookDetailList)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = bookDetail.Name;
                    listViewItem.SubItems.Add(bookDetail.Author);
                    listViewItem.SubItems.Add(bookDetail.Press);
                    listViewItem.SubItems.Add(bookDetail.Isbn);
                    listViewItem.SubItems.Add(bookDetail.Price.ToString());
                    listViewItem.SubItems.Add(bookDetail.LeftNum.ToString());
                    listViewItem.SubItems.Add(bookDetail.TotalNum.ToString());
                    listViewItem.SubItems.Add(categoryDict[bookDetail.CategoryId]);
                    listViewBookDetail.Items.Add(listViewItem);
                }
            }
        }

        private void SearchBookForm_Load(object sender, EventArgs e)
        {
            programName = ConfigurationManager.AppSettings["programName"];
            this.Text = programName + " - 查询书籍";
        }

        private void listViewBookDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listViewBookDetail.SelectedItems.Count > 0)
            {
                string isbn = listViewBookDetail.SelectedItems[0].SubItems[3].Text;
                new BorrowBookForm(user, isbn).Show();
            }
        }

        private void fillCategoryDict()
        {
            List<Category> categoryList = CategoryController.getAllCategory();
            foreach(Category category in categoryList)
            {
                categoryDict.Add(category.Id, category.Name);
            }
        }

        private void SearchBookForm_Shown(object sender, EventArgs e)
        {
            fillCategoryDict();
        }

        private void SearchBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void SearchBookForm_Activated(object sender, EventArgs e)
        {
            buttonQuery.PerformClick();
        }
    }
}
