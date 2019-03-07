namespace BooksManagementSystem.View.ManagerView.BorrowManagerView
{
    partial class BorrowManager
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
            this.columnHeaderBorrowId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTruename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBorrowDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIsRetrun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_message
            // 
            this.listView_message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBorrowId,
            this.columnHeaderUserId,
            this.columnHeaderTruename,
            this.columnHeaderBookId,
            this.columnHeaderBookName,
            this.columnHeaderBorrowDate,
            this.columnHeaderLastReturnDate,
            this.columnHeaderReturnDate,
            this.columnHeaderIsRetrun});
            this.listView_message.Location = new System.Drawing.Point(3, 105);
            this.listView_message.Size = new System.Drawing.Size(987, 402);
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(12, 44);
            this.labelSearch.Size = new System.Drawing.Size(234, 27);
            this.labelSearch.Text = "用户ID、书籍ID、书名：";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(252, 41);
            this.textBoxSearch.Size = new System.Drawing.Size(600, 34);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(879, 33);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // columnHeaderBorrowId
            // 
            this.columnHeaderBorrowId.Text = "借阅ID";
            this.columnHeaderBorrowId.Width = 85;
            // 
            // columnHeaderTruename
            // 
            this.columnHeaderTruename.Text = "用户姓名";
            this.columnHeaderTruename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTruename.Width = 102;
            // 
            // columnHeaderUserId
            // 
            this.columnHeaderUserId.Text = "用户ID";
            this.columnHeaderUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUserId.Width = 89;
            // 
            // columnHeaderBookId
            // 
            this.columnHeaderBookId.Text = "书籍ID";
            this.columnHeaderBookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookId.Width = 86;
            // 
            // columnHeaderBorrowDate
            // 
            this.columnHeaderBorrowDate.Text = "借阅日期";
            this.columnHeaderBorrowDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBorrowDate.Width = 152;
            // 
            // columnHeaderLastReturnDate
            // 
            this.columnHeaderLastReturnDate.Text = "应还日期";
            this.columnHeaderLastReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLastReturnDate.Width = 133;
            // 
            // columnHeaderReturnDate
            // 
            this.columnHeaderReturnDate.Text = "实际归还日期";
            this.columnHeaderReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderReturnDate.Width = 157;
            // 
            // columnHeaderIsRetrun
            // 
            this.columnHeaderIsRetrun.Text = "是否已还";
            this.columnHeaderIsRetrun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderIsRetrun.Width = 100;
            // 
            // columnHeaderBookName
            // 
            this.columnHeaderBookName.Text = "书名";
            // 
            // BorrowManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(995, 512);
            this.Name = "BorrowManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BorrowManager_FormClosed);
            this.Load += new System.EventHandler(this.BorrowManager_Load);
            this.Controls.SetChildIndex(this.listView_message, 0);
            this.Controls.SetChildIndex(this.labelSearch, 0);
            this.Controls.SetChildIndex(this.textBoxSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderBorrowId;
        private System.Windows.Forms.ColumnHeader columnHeaderUserId;
        private System.Windows.Forms.ColumnHeader columnHeaderTruename;
        private System.Windows.Forms.ColumnHeader columnHeaderBookId;
        private System.Windows.Forms.ColumnHeader columnHeaderBorrowDate;
        private System.Windows.Forms.ColumnHeader columnHeaderLastReturnDate;
        private System.Windows.Forms.ColumnHeader columnHeaderReturnDate;
        private System.Windows.Forms.ColumnHeader columnHeaderIsRetrun;
        private System.Windows.Forms.ColumnHeader columnHeaderBookName;
    }
}
