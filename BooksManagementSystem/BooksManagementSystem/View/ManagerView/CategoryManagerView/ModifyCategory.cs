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

namespace BooksManagementSystem.View.ManagerView.CategoryManagerView
{
    public partial class ModifyCategory : Form
    {
        private Category category;

        public ModifyCategory(Category category)
        {
            InitializeComponent();
            this.category = category;
        }

        private void ModifyCategory_Load(object sender, EventArgs e)
        {
            textBoxCategoryId.Enabled = false;
            textBoxCategoryId.Text = category.Id;
            textBoxCategoryName.Text = category.Name;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModifyCategory_Click(object sender, EventArgs e)
        {
            if(textBoxCategoryName.Text.Length != 0)
            {
                if(CategoryController.updateNameByCategoryId(category.Id, textBoxCategoryName.Text.Trim()))
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else
            {
                MessageBox.Show("请确保所有信息填写完整！");
            }
        }
    }
}
