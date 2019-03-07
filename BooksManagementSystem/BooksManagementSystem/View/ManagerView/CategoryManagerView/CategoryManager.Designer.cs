namespace BooksManagementSystem.View.ManagerView.CategoryManagerView
{
    partial class CategoryManager
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
            this.columnHeaderCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_message
            // 
            this.listView_message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCategoryId,
            this.columnHeaderCategoryName});
            this.listView_message.Location = new System.Drawing.Point(2, 161);
            this.listView_message.Size = new System.Drawing.Size(593, 349);
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(12, 30);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(190, 30);
            this.textBoxSearch.Size = new System.Drawing.Size(226, 34);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 91);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // columnHeaderCategoryId
            // 
            this.columnHeaderCategoryId.Text = "分类ID";
            this.columnHeaderCategoryId.Width = 175;
            // 
            // columnHeaderCategoryName
            // 
            this.columnHeaderCategoryName.Text = "分类名称";
            this.columnHeaderCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCategoryName.Width = 407;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonAddCategory.Location = new System.Drawing.Point(463, 60);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(113, 48);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.Text = "增加分类";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // CategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(597, 512);
            this.Controls.Add(this.buttonAddCategory);
            this.Name = "CategoryManager";
            this.Activated += new System.EventHandler(this.CategoryManager_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategoryManager_FormClosed);
            this.Load += new System.EventHandler(this.CategoryManager_Load);
            this.Controls.SetChildIndex(this.listView_message, 0);
            this.Controls.SetChildIndex(this.labelSearch, 0);
            this.Controls.SetChildIndex(this.textBoxSearch, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.buttonAddCategory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderCategoryId;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoryName;
        private System.Windows.Forms.Button buttonAddCategory;
    }
}
