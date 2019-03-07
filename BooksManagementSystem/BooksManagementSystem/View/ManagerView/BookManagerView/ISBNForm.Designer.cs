namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class ISBNForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.Press = new System.Windows.Forms.TextBox();
            this.labelPress = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cancel.Location = new System.Drawing.Point(385, 333);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(106, 57);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "退出";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.confirm.Location = new System.Drawing.Point(173, 333);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(106, 57);
            this.confirm.TabIndex = 14;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // ISBN
            // 
            this.ISBN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ISBN.Location = new System.Drawing.Point(213, 85);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(365, 34);
            this.ISBN.TabIndex = 13;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelISBN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelISBN.Location = new System.Drawing.Point(59, 88);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(144, 27);
            this.labelISBN.TabIndex = 12;
            this.labelISBN.Text = "输入新增ISBN:";
            this.labelISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Price.Location = new System.Drawing.Point(213, 245);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(366, 34);
            this.Price.TabIndex = 27;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPrice.Location = new System.Drawing.Point(69, 245);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(122, 34);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "单价:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Press
            // 
            this.Press.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Press.Location = new System.Drawing.Point(214, 205);
            this.Press.Name = "Press";
            this.Press.Size = new System.Drawing.Size(366, 34);
            this.Press.TabIndex = 25;
            // 
            // labelPress
            // 
            this.labelPress.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelPress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPress.Location = new System.Drawing.Point(69, 205);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(117, 34);
            this.labelPress.TabIndex = 24;
            this.labelPress.Text = "出版社:";
            this.labelPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Author.Location = new System.Drawing.Point(214, 165);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(366, 34);
            this.Author.TabIndex = 23;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAuthor.Location = new System.Drawing.Point(64, 165);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(127, 34);
            this.labelAuthor.TabIndex = 22;
            this.labelAuthor.Text = "作者:";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookName
            // 
            this.bookName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookName.Location = new System.Drawing.Point(213, 125);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(366, 34);
            this.bookName.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelName.Location = new System.Drawing.Point(64, 125);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(127, 34);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "书名:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ISBNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 433);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.Press);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.labelISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ISBNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISBNForm";
            this.Load += new System.EventHandler(this.ISBNForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button cancel;
        protected System.Windows.Forms.Button confirm;
        protected System.Windows.Forms.TextBox ISBN;
        protected System.Windows.Forms.Label labelISBN;
        protected System.Windows.Forms.TextBox Price;
        protected System.Windows.Forms.Label labelPrice;
        protected System.Windows.Forms.TextBox Press;
        protected System.Windows.Forms.Label labelPress;
        protected System.Windows.Forms.TextBox Author;
        protected System.Windows.Forms.Label labelAuthor;
        protected System.Windows.Forms.TextBox bookName;
        protected System.Windows.Forms.Label labelName;
    }
}