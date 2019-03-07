namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class ISBNManage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.press = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leftNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddISBN = new System.Windows.Forms.Button();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_message
            // 
            this.listView_message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.name,
            this.author,
            this.press,
            this.price,
            this.totalNum,
            this.leftNum,
            this.category});
            this.listView_message.Size = new System.Drawing.Size(735, 358);
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(25, 33);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(203, 30);
            this.textBoxSearch.Size = new System.Drawing.Size(260, 34);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 88);
            this.btnSearch.Size = new System.Drawing.Size(76, 43);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 99;
            // 
            // name
            // 
            this.name.Text = "书名";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 99;
            // 
            // author
            // 
            this.author.Text = "作者";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 99;
            // 
            // press
            // 
            this.press.Text = "出版社";
            this.press.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.press.Width = 101;
            // 
            // price
            // 
            this.price.Text = "单价";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalNum
            // 
            this.totalNum.Text = "总数量";
            this.totalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalNum.Width = 91;
            // 
            // leftNum
            // 
            this.leftNum.Text = "可借数量";
            this.leftNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftNum.Width = 95;
            // 
            // btnAddISBN
            // 
            this.btnAddISBN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddISBN.Location = new System.Drawing.Point(564, 58);
            this.btnAddISBN.Name = "btnAddISBN";
            this.btnAddISBN.Size = new System.Drawing.Size(126, 43);
            this.btnAddISBN.TabIndex = 3;
            this.btnAddISBN.Text = "增加ISBN";
            this.btnAddISBN.UseVisualStyleBackColor = true;
            this.btnAddISBN.Click += new System.EventHandler(this.btnAddISBN_Click);
            // 
            // category
            // 
            this.category.Text = "分类";
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.category.Width = 81;
            // 
            // ISBNManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(750, 512);
            this.Controls.Add(this.btnAddISBN);
            this.Name = "ISBNManage";
            this.Activated += new System.EventHandler(this.ISBNManage_Activated);
            this.Load += new System.EventHandler(this.ISBNManage_Load);
            this.Controls.SetChildIndex(this.listView_message, 0);
            this.Controls.SetChildIndex(this.labelSearch, 0);
            this.Controls.SetChildIndex(this.textBoxSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnAddISBN, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader press;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader totalNum;
        private System.Windows.Forms.ColumnHeader leftNum;
        private System.Windows.Forms.Button btnAddISBN;
        private System.Windows.Forms.ColumnHeader category;
    }
}
