using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;

namespace BooksManagementSystem.View.ManagerView.CategoryManagerView
{
    public partial class CategoryManager : BooksManagementSystem.View.ManagerView.BookManagerView.ManageForm
    {
        private Form form;
        private List<Category> categoryList;
        public CategoryManager(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void CategoryManager_Load(object sender, EventArgs e)
        {
            this.strip.ItemClicked += new ToolStripItemClickedEventHandler(this.Strip_ItemClicked);
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 分类管理";
            categoryList = CategoryController.getAllCategory();
            updateListView();
        }

        private void updateListView()
        {
            this.listView_message.BeginUpdate();
            this.listView_message.Items.Clear();
            for(int i = 0; i < categoryList.Count; i++)
            {
                Category category = categoryList[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.Id;
                lvi.SubItems.Add(category.Name);
                this.listView_message.Items.Add(lvi);
            }
            this.listView_message.EndUpdate();
        }

        private void CategoryManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void CategoryManager_Activated(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        protected void Strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            strip.Close();
            Category category = CategoryController.getCategoryByCategoryId(listView_message.SelectedItems[0].Text);
            if (e.ClickedItem.Name == "DeleteToolStripMenuItem")
            {
                string[] messages = message.Split(' ');
                DialogResult dr = MessageBox.Show("确认删除吗?", "删除分类警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (CategoryController.deleteCategoryByCategoryId(messages[0]))
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
                new ModifyCategory(category).ShowDialog();
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            new AddCategory().ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text.Trim();
            categoryList = CategoryController.searchCategoryByKeyword(keyword);
            updateListView();

        }
    }
}
