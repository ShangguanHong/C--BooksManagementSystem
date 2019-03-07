using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    public partial class ISBNManage : ManageForm
    {
        Dictionary<string, string> categoryDict;
        List<BookDetail> BookDetails;
        public ISBNManage()
        {
            InitializeComponent();
        }

        private void ISBNManage_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - ISBN管理";
            this.strip.ItemClicked += new ToolStripItemClickedEventHandler(this.Strip_ItemClicked);
            BookDetails = BookDetailController.getAllBookDetailList();
            categoryDict = CategoryController.getAllCategoryToDict();
            Update_ListView_Message();
        }
        private void Update_ListView_Message()
        {
            this.listView_message.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            this.listView_message.Items.Clear();
            for (int i = 0; i < BookDetails.Count; i++)
            {
                BookDetail bookDetail = BookDetails[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = bookDetail.Isbn;
                lvi.SubItems.Add(bookDetail.Name);
                lvi.SubItems.Add(bookDetail.Author);
                lvi.SubItems.Add(bookDetail.Press);
                lvi.SubItems.Add(bookDetail.Price.ToString());
                lvi.SubItems.Add(bookDetail.TotalNum.ToString());
                lvi.SubItems.Add(bookDetail.LeftNum.ToString());
                lvi.SubItems.Add(categoryDict[bookDetail.CategoryId]);
                this.listView_message.Items.Add(lvi);
            }
            this.listView_message.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BookDetails = BookDetailController.searchBookDetailByKeyword(textBoxSearch.Text);
            Update_ListView_Message();
        }

        protected void Strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            strip.Close();
            BookDetail bookDetail = BookDetails[listView_message.Items[listView_message.SelectedIndices[0]].Index];
            if (e.ClickedItem.Name == "DeleteToolStripMenuItem")
            {
                string[] messages = message.Split(' ');
                DialogResult dr = MessageBox.Show("确认删除吗?", "删除ISBN条码警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (BookDetailController.deleteBookDetailByISBN(messages[0]))
                    {
                        MessageBox.Show("删除成功!");
                        btnSearch.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
            }
            else
            {
                new ModifyISBN(bookDetail, categoryDict).Show();
            }
        }

        private void btnAddISBN_Click(object sender, EventArgs e)
        {
            new AddISBN(categoryDict).ShowDialog();
        }

        private void ISBNManage_Activated(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }
    }
}
