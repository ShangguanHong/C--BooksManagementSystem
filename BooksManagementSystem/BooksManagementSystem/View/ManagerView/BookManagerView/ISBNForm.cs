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
    public partial class ISBNForm : Form
    {
        public ISBNForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ISBNForm_Load(object sender, EventArgs e)
        {

        }
    }
}
