using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BooksManagementSystem.Controller;
using BooksManagementSystem.Model;

namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    public partial class AddISBN : BooksManagementSystem.View.ManagerView.BookManagerView.ISBNForm
    {
        private Dictionary<string, string> categoryDict;

        public AddISBN(Dictionary<string, string> categoryDict)
        {
            InitializeComponent();
            this.categoryDict = categoryDict;
        }

        private void AddISBN_Load(object sender, EventArgs e)
        {
            this.ISBN.Focus();
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 增加ISBN";
            foreach(var category in categoryDict)
            {
                comboBoxCategory.Items.Add(category);
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                BookDetail bookDetail = BookDetailController.createBookDetail(ISBN.Text.Trim(), bookName.Text.Trim(), Author.Text.Trim(), Press.Text.Trim(), double.Parse(Price.Text.Trim()), 0, 0, ((KeyValuePair<string, string>)comboBoxCategory.SelectedItem).Key);
                if(bookDetail != null)
                {
                    MessageBox.Show("新增ISBN成功!");
                }
                else
                {
                    MessageBox.Show("新增ISBN失败!");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("新增ISBN失败!");
            }
            this.ISBN.Focus();
        }
    }
}
