namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class ModifyISBN
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(378, 356);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(166, 356);
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = false;
            this.labelISBN.Size = new System.Drawing.Size(132, 27);
            this.labelISBN.Text = "ISBN:";
            // 
            // labelPress
            // 
            this.labelPress.Location = new System.Drawing.Point(74, 204);
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelCategory.Location = new System.Drawing.Point(17, 285);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(174, 23);
            this.labelCategory.TabIndex = 30;
            this.labelCategory.Text = "分类:";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(213, 285);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(367, 35);
            this.comboBoxCategory.TabIndex = 29;
            // 
            // ModifyISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(660, 448);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "ModifyISBN";
            this.Load += new System.EventHandler(this.ModifyISBN_Load);
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

        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}
