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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }
        protected void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
