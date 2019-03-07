namespace BooksManagementSystem.View.UserPanel
{
    partial class BorrowBookForm
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
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeaderBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewBook
            // 
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookId,
            this.columnHeaderBookLocation,
            this.columnHeaderBookStatus});
            this.listViewBook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewBook.FullRowSelect = true;
            this.listViewBook.GridLines = true;
            this.listViewBook.Location = new System.Drawing.Point(13, 13);
            this.listViewBook.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBook.MultiSelect = false;
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(777, 256);
            this.listViewBook.TabIndex = 7;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBookId
            // 
            this.columnHeaderBookId.Text = "书籍ID";
            this.columnHeaderBookId.Width = 123;
            // 
            // columnHeaderBookLocation
            // 
            this.columnHeaderBookLocation.Text = "馆藏位置";
            this.columnHeaderBookLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookLocation.Width = 507;
            // 
            // columnHeaderBookStatus
            // 
            this.columnHeaderBookStatus.Text = "状态";
            this.columnHeaderBookStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookStatus.Width = 132;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBorrow.Location = new System.Drawing.Point(342, 297);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(105, 48);
            this.buttonBorrow.TabIndex = 9;
            this.buttonBorrow.Text = "借阅";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 370);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.buttonBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BorrowBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBookForm";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            this.Shown += new System.EventHandler(this.BorrowBookForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.ColumnHeader columnHeaderBookId;
        private System.Windows.Forms.ColumnHeader columnHeaderBookLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderBookStatus;
    }
}