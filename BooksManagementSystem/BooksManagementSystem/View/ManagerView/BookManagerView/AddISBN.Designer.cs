namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class AddISBN
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(355, 343);
            this.cancel.Size = new System.Drawing.Size(91, 56);
            this.cancel.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(212, 343);
            this.confirm.Size = new System.Drawing.Size(97, 56);
            this.confirm.TabIndex = 6;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(212, 61);
            this.ISBN.Size = new System.Drawing.Size(409, 34);
            this.ISBN.TabIndex = 0;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = false;
            this.labelISBN.Location = new System.Drawing.Point(31, 60);
            this.labelISBN.Size = new System.Drawing.Size(175, 34);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(212, 221);
            this.Price.Size = new System.Drawing.Size(409, 34);
            this.Price.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(34, 220);
            this.labelPrice.Size = new System.Drawing.Size(171, 34);
            // 
            // Press
            // 
            this.Press.Location = new System.Drawing.Point(211, 181);
            this.Press.Size = new System.Drawing.Size(409, 34);
            this.Press.TabIndex = 3;
            // 
            // labelPress
            // 
            this.labelPress.Location = new System.Drawing.Point(30, 175);
            this.labelPress.Size = new System.Drawing.Size(176, 34);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(212, 141);
            this.Author.Size = new System.Drawing.Size(409, 34);
            this.Author.TabIndex = 2;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Location = new System.Drawing.Point(36, 141);
            this.labelAuthor.Size = new System.Drawing.Size(170, 34);
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(211, 101);
            this.bookName.Size = new System.Drawing.Size(409, 34);
            this.bookName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(29, 100);
            this.labelName.Size = new System.Drawing.Size(176, 34);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(212, 271);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(409, 35);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelCategory.Location = new System.Drawing.Point(31, 271);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(174, 23);
            this.labelCategory.TabIndex = 28;
            this.labelCategory.Text = "分类:";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(675, 432);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "AddISBN";
            this.Load += new System.EventHandler(this.AddISBN_Load);
            this.Controls.SetChildIndex(this.labelISBN, 0);
            this.Controls.SetChildIndex(this.ISBN, 0);
            this.Controls.SetChildIndex(this.confirm, 0);
            this.Controls.SetChildIndex(this.cancel, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.bookName, 0);
            this.Controls.SetChildIndex(this.labelAuthor, 0);
            this.Controls.SetChildIndex(this.Author, 0);
            this.Controls.SetChildIndex(this.labelPress, 0);
            this.Controls.SetChildIndex(this.Press, 0);
            this.Controls.SetChildIndex(this.labelPrice, 0);
            this.Controls.SetChildIndex(this.Price, 0);
            this.Controls.SetChildIndex(this.comboBoxCategory, 0);
            this.Controls.SetChildIndex(this.labelCategory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
    }
}
