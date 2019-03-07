using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;
using System.Configuration;

namespace BooksManagementSystem.View.ManagerView.BorrowManagerView
{
    public partial class BorrowManager : BooksManagementSystem.View.ManagerView.BookManagerView.ManageForm
    {
        private List<Borrow> borrowList;
        private Form form;
        public BorrowManager(Form form)
        {
            InitializeComponent();
            this.form = form;
        }


        private void BorrowManager_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 借阅查询";
            listView_message.MouseClick -= ListView_user_message_MouseClick;
            borrowList = BorrowController.getAllBorrowList();
            Update_ListView_Message();
        }

        private void Update_ListView_Message()
        {
            this.listView_message.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            this.listView_message.Items.Clear();
            for (int i = 0; i < borrowList.Count; i++)
            {
                Borrow borrow = borrowList[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = borrow.Id.ToString();
                lvi.SubItems.Add(borrow.UserId.ToString());
                lvi.SubItems.Add(UserController.getTruenameByUserId(borrow.UserId));
                lvi.SubItems.Add(borrow.BookId.ToString());
                lvi.SubItems.Add(BookController.getBookNameByBookId(borrow.BookId));
                lvi.SubItems.Add(borrow.BorrowDate.ToString());
                lvi.SubItems.Add(borrow.LastReturnDate.ToString());
                lvi.SubItems.Add(borrow.ReturnDate.ToString());
                lvi.SubItems.Add(borrow.IsReturn ? "是" : "否");
                this.listView_message.Items.Add(lvi);
            }
            this.listView_message.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            borrowList = BorrowController.getBorrowListByKeyword(textBoxSearch.Text.Trim());
            Update_ListView_Message();
            btnSearch.Enabled = true;
        }

        private void BorrowManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
