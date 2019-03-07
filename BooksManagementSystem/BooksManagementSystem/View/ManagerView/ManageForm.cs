using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    public partial class ManageForm : Form
    {
        public string message;
        public ManageForm()
        {
            InitializeComponent();
        }
        protected void ListView_user_message_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && listView_message.SelectedItems.Count != 0)
            {
                message = "";
                ListViewItem item = listView_message.SelectedItems[0];
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    message = message + item.SubItems[i].Text.ToString() + " ";
                }
                message.Trim();
                strip.Show(listView_message, e.Location);//鼠标右键按下弹出菜单
            }
        }
        private void textboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
