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
    public partial class ModifyISBN : ISBNForm
    {
        private Dictionary<string, string> categoryDict;
        BookDetail bookDetail;
        public ModifyISBN(BookDetail bookDetail, Dictionary<string, string> categoryDict) 
        {
            InitializeComponent();
            this.bookDetail = bookDetail;
            this.categoryDict = categoryDict;
        }

        private void ModifyISBN_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 修改ISBN信息";
            this.ISBN.Enabled = false;
            this.ISBN.Text = bookDetail.Isbn;
            this.bookName.Text = bookDetail.Name;
            this.bookName.Focus();
            this.Author.Text = bookDetail.Author;
            this.Press.Text = bookDetail.Press;
            this.Price.Text = bookDetail.Price.ToString();
            KeyValuePair<string, string>? selectedCategory = null;
            foreach (var category in categoryDict)
            {
                comboBoxCategory.Items.Add(category);
                if(category.Key == bookDetail.CategoryId)
                {
                    selectedCategory = category;
                }
            }
            if (selectedCategory != null)
            {
                comboBoxCategory.SelectedItem = selectedCategory;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (BookDetailController.updateBookDetailByISBN(bookDetail.Isbn, bookName.Text.Trim(), Author.Text.Trim(), Press.Text.Trim(), double.Parse(Price.Text.Trim()), ((KeyValuePair<string, string>)comboBoxCategory.SelectedItem).Key))
            {
                MessageBox.Show("修改ISBN信息成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改ISBN信息失败!");
            }
            this.bookName.Focus();
        }
    }
}
