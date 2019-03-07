namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class BookManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView_book_message = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelBookName = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnISBN = new System.Windows.Forms.Button();
            this.strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_book_message
            // 
            this.listView_book_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_book_message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ISBN,
            this.bookName,
            this.author,
            this.location,
            this.status});
            this.listView_book_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_book_message.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.listView_book_message.FullRowSelect = true;
            this.listView_book_message.GridLines = true;
            this.listView_book_message.Location = new System.Drawing.Point(0, 175);
            this.listView_book_message.Name = "listView_book_message";
            this.listView_book_message.Size = new System.Drawing.Size(820, 415);
            this.listView_book_message.TabIndex = 2;
            this.listView_book_message.UseCompatibleStateImageBehavior = false;
            this.listView_book_message.View = System.Windows.Forms.View.Details;
            this.listView_book_message.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_user_message_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "书目条码";
            this.ID.Width = 135;
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISBN.Width = 140;
            // 
            // bookName
            // 
            this.bookName.Text = "书名";
            this.bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookName.Width = 152;
            // 
            // author
            // 
            this.author.Text = "作者";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 119;
            // 
            // location
            // 
            this.location.Text = "存放位置";
            this.location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.location.Width = 135;
            // 
            // status
            // 
            this.status.Text = "当前状态";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 131;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelBookName.Location = new System.Drawing.Point(12, 46);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(164, 27);
            this.labelBookName.TabIndex = 1;
            this.labelBookName.Text = "书目条码或ISBN:";
            this.labelBookName.Click += new System.EventHandler(this.labelBookName_Click);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxBookName.Location = new System.Drawing.Point(182, 43);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(380, 34);
            this.textBoxBookName.TabIndex = 0;
            this.textBoxBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxBookName_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSearch.Location = new System.Drawing.Point(222, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAddBook.Location = new System.Drawing.Point(621, 30);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(170, 55);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "增加图书";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnISBN
            // 
            this.btnISBN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnISBN.Location = new System.Drawing.Point(621, 98);
            this.btnISBN.Name = "btnISBN";
            this.btnISBN.Size = new System.Drawing.Size(170, 55);
            this.btnISBN.TabIndex = 5;
            this.btnISBN.Text = "查看ISBN信息";
            this.btnISBN.UseVisualStyleBackColor = true;
            this.btnISBN.Click += new System.EventHandler(this.btnISBN_Click);
            // 
            // strip
            // 
            this.strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.ModifyToolStripMenuItem});
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(139, 52);
            this.strip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Strip_ItemClicked);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.DeleteToolStripMenuItem.Text = "删除书籍";
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.ModifyToolStripMenuItem.Text = "修改信息";
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 590);
            this.Controls.Add(this.btnISBN);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.listView_book_message);
            this.MaximizeBox = false;
            this.Name = "BookManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookManage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookManage_FormClosed);
            this.Load += new System.EventHandler(this.BookManage_Load);
            this.strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_book_message;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnISBN;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader status;
        protected System.Windows.Forms.ContextMenuStrip strip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader bookName;
        private System.Windows.Forms.ColumnHeader author;
    }
}