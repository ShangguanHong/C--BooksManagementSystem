namespace BooksManagementSystem.View.UserPanel
{
    partial class ReturnBookForm
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
            this.listViewBorrowInfo = new System.Windows.Forms.ListView();
            this.columnHeaderBookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBorrowDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBorrowId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewBorrowInfo
            // 
            this.listViewBorrowInfo.BackColor = System.Drawing.SystemColors.Window;
            this.listViewBorrowInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookId,
            this.columnHeaderBookName,
            this.columnHeaderAuthor,
            this.columnHeaderPress,
            this.columnHeaderISBN,
            this.columnHeaderBorrowDate,
            this.columnHeaderLastReturnDate,
            this.columnHeaderBorrowId});
            this.listViewBorrowInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewBorrowInfo.FullRowSelect = true;
            this.listViewBorrowInfo.GridLines = true;
            this.listViewBorrowInfo.Location = new System.Drawing.Point(13, 13);
            this.listViewBorrowInfo.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBorrowInfo.MultiSelect = false;
            this.listViewBorrowInfo.Name = "listViewBorrowInfo";
            this.listViewBorrowInfo.Size = new System.Drawing.Size(946, 256);
            this.listViewBorrowInfo.TabIndex = 6;
            this.listViewBorrowInfo.UseCompatibleStateImageBehavior = false;
            this.listViewBorrowInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBookId
            // 
            this.columnHeaderBookId.Text = "图书ID";
            this.columnHeaderBookId.Width = 89;
            // 
            // columnHeaderBookName
            // 
            this.columnHeaderBookName.Text = "书名";
            this.columnHeaderBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookName.Width = 238;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "作者";
            this.columnHeaderAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAuthor.Width = 89;
            // 
            // columnHeaderPress
            // 
            this.columnHeaderPress.Text = "出版社";
            this.columnHeaderPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPress.Width = 116;
            // 
            // columnHeaderISBN
            // 
            this.columnHeaderISBN.Text = "ISBN";
            this.columnHeaderISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderISBN.Width = 149;
            // 
            // columnHeaderBorrowDate
            // 
            this.columnHeaderBorrowDate.Text = "借阅日期";
            this.columnHeaderBorrowDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBorrowDate.Width = 108;
            // 
            // columnHeaderLastReturnDate
            // 
            this.columnHeaderLastReturnDate.Text = "最晚归还日期";
            this.columnHeaderLastReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLastReturnDate.Width = 140;
            // 
            // columnHeaderBorrowId
            // 
            this.columnHeaderBorrowId.Text = "借阅ID";
            this.columnHeaderBorrowId.Width = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.Location = new System.Drawing.Point(437, 343);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(105, 48);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "归还";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHint.Location = new System.Drawing.Point(297, 291);
            this.labelHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(372, 27);
            this.labelHint.TabIndex = 7;
            this.labelHint.Text = "选择你想归还的书籍，然后点击归还按钮";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 409);
            this.Controls.Add(this.listViewBorrowInfo);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnBookForm_FormClosed);
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.Shown += new System.EventHandler(this.ReturnBookForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBorrowInfo;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.ColumnHeader columnHeaderBookId;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderPress;
        private System.Windows.Forms.ColumnHeader columnHeaderISBN;
        private System.Windows.Forms.ColumnHeader columnHeaderBorrowDate;
        private System.Windows.Forms.ColumnHeader columnHeaderLastReturnDate;
        private System.Windows.Forms.ColumnHeader columnHeaderBorrowId;
        private System.Windows.Forms.ColumnHeader columnHeaderBookName;
    }
}