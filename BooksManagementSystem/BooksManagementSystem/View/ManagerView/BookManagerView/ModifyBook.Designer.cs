namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class ModifyBook
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
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_ISBN
            // 
            this.lab_ISBN.Location = new System.Drawing.Point(31, 93);
            this.lab_ISBN.Click += new System.EventHandler(this.lab_ISBN_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(234, 90);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(121, 222);
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(326, 222);
            // 
            // locaiton
            // 
            this.locaiton.Location = new System.Drawing.Point(234, 143);
            // 
            // labelLaction
            // 
            this.labelLaction.Location = new System.Drawing.Point(31, 143);
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelID.Location = new System.Drawing.Point(31, 45);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(508, 42);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "书ID号:";
            // 
            // ModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(551, 319);
            this.Controls.Add(this.labelID);
            this.Name = "ModifyBook";
            this.Load += new System.EventHandler(this.ModifyBook_Load);
            this.Controls.SetChildIndex(this.lab_ISBN, 0);
            this.Controls.SetChildIndex(this.ISBN, 0);
            this.Controls.SetChildIndex(this.confirm, 0);
            this.Controls.SetChildIndex(this.cancel, 0);
            this.Controls.SetChildIndex(this.labelLaction, 0);
            this.Controls.SetChildIndex(this.locaiton, 0);
            this.Controls.SetChildIndex(this.labelID, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
    }
}
