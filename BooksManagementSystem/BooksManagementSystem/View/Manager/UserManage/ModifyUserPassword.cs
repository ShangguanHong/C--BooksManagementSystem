using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem.View
{
    public partial class ModifyUserPassword : Form
    {
        public ModifyUserPassword()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(true)
            {
                MessageBox.Show("修改密码成功!");
                user_name.Clear();
                password.Clear(); 
            } else
            {
                MessageBox.Show("修改密码失败!");
            }
            user_name.Focus();
        }
    }
}
