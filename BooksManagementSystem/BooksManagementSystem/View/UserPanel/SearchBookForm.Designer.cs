using System.Windows.Forms;

namespace BooksManagementSystem.View.UserPanel
{
    partial class SearchBookForm
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
            this.listViewBookDetail = new System.Windows.Forms.ListView();
            this.columnHeaderBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookPress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookLeftNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookTotalNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBookCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewBookDetail
            // 
            this.listViewBookDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookName,
            this.columnHeaderBookAuthor,
            this.columnHeaderBookPress,
            this.columnHeaderBookISBN,
            this.columnHeaderBookPrice,
            this.columnHeaderBookLeftNum,
            this.columnHeaderBookTotalNum,
            this.columnHeaderBookCategory});
            this.listViewBookDetail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewBookDetail.FullRowSelect = true;
            this.listViewBookDetail.GridLines = true;
            this.listViewBookDetail.Location = new System.Drawing.Point(13, 82);
            this.listViewBookDetail.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBookDetail.MultiSelect = false;
            this.listViewBookDetail.Name = "listViewBookDetail";
            this.listViewBookDetail.Size = new System.Drawing.Size(912, 256);
            this.listViewBookDetail.TabIndex = 12;
            this.listViewBookDetail.UseCompatibleStateImageBehavior = false;
            this.listViewBookDetail.View = System.Windows.Forms.View.Details;
            this.listViewBookDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewBookDetail_MouseDoubleClick);
            // 
            // columnHeaderBookName
            // 
            this.columnHeaderBookName.Text = "书名";
            this.columnHeaderBookName.Width = 198;
            // 
            // columnHeaderBookAuthor
            // 
            this.columnHeaderBookAuthor.Text = "作者";
            this.columnHeaderBookAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookAuthor.Width = 83;
            // 
            // columnHeaderBookPress
            // 
            this.columnHeaderBookPress.Text = "出版社";
            this.columnHeaderBookPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookPress.Width = 104;
            // 
            // columnHeaderBookISBN
            // 
            this.columnHeaderBookISBN.Text = "ISBN";
            this.columnHeaderBookISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookISBN.Width = 173;
            // 
            // columnHeaderBookPrice
            // 
            this.columnHeaderBookPrice.Text = "价格";
            this.columnHeaderBookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookPrice.Width = 68;
            // 
            // columnHeaderBookLeftNum
            // 
            this.columnHeaderBookLeftNum.Text = "剩余数量";
            this.columnHeaderBookLeftNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookLeftNum.Width = 111;
            // 
            // columnHeaderBookTotalNum
            // 
            this.columnHeaderBookTotalNum.Text = "总数量";
            this.columnHeaderBookTotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookTotalNum.Width = 81;
            // 
            // columnHeaderBookCategory
            // 
            this.columnHeaderBookCategory.Text = "分类";
            this.columnHeaderBookCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderBookCategory.Width = 83;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonQuery.Location = new System.Drawing.Point(820, 14);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(105, 48);
            this.buttonQuery.TabIndex = 1;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookName.Location = new System.Drawing.Point(171, 17);
            this.textBoxBookName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(627, 34);
            this.textBoxBookName.TabIndex = 0;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBookName.Location = new System.Drawing.Point(22, 25);
            this.labelBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(132, 27);
            this.labelBookName.TabIndex = 13;
            this.labelBookName.Text = "请输入书名：";
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 360);
            this.Controls.Add(this.listViewBookDetail);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelBookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBookForm";
            this.Activated += new System.EventHandler(this.SearchBookForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchBookForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchBookForm_Load);
            this.Shown += new System.EventHandler(this.SearchBookForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBookDetail;
        private System.Windows.Forms.ColumnHeader columnHeaderBookName;
        private System.Windows.Forms.ColumnHeader columnHeaderBookAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderBookPress;
        private System.Windows.Forms.ColumnHeader columnHeaderBookISBN;
        private System.Windows.Forms.ColumnHeader columnHeaderBookPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderBookLeftNum;
        private System.Windows.Forms.ColumnHeader columnHeaderBookTotalNum;
        private System.Windows.Forms.ColumnHeader columnHeaderBookCategory;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
    }
}