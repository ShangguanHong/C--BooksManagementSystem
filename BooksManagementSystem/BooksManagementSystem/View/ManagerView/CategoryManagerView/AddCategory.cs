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

namespace BooksManagementSystem.View.ManagerView.CategoryManagerView
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["programName"] + " - 增加分类";

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if(isFormComplete())
            {
                Category category = CategoryController.createCategory(textBoxCategoryId.Text.Trim(), textBoxCategoryName.Text.Trim());
                if (category != null)
                {
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else
            {
                MessageBox.Show("请确保分类信息输入完整！");
            }
        }

        private bool isFormComplete()
        {
            return textBoxCategoryId.Text.Length != 0 && textBoxCategoryName.Text.Length != 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
