namespace BooksManagementSystem.View.ManagerView.CategoryManagerView
{
    partial class ModifyCategory
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModifyCategory = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryId = new System.Windows.Forms.TextBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelCategoryId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(210, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 46);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonModifyCategory
            // 
            this.buttonModifyCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonModifyCategory.Location = new System.Drawing.Point(77, 138);
            this.buttonModifyCategory.Name = "buttonModifyCategory";
            this.buttonModifyCategory.Size = new System.Drawing.Size(85, 46);
            this.buttonModifyCategory.TabIndex = 10;
            this.buttonModifyCategory.Text = "修改";
            this.buttonModifyCategory.UseVisualStyleBackColor = true;
            this.buttonModifyCategory.Click += new System.EventHandler(this.buttonModifyCategory_Click);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxCategoryName.Location = new System.Drawing.Point(130, 65);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(202, 34);
            this.textBoxCategoryName.TabIndex = 9;
            // 
            // textBoxCategoryId
            // 
            this.textBoxCategoryId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxCategoryId.Location = new System.Drawing.Point(130, 28);
            this.textBoxCategoryId.Name = "textBoxCategoryId";
            this.textBoxCategoryId.Size = new System.Drawing.Size(202, 34);
            this.textBoxCategoryId.TabIndex = 8;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelCategoryName.Location = new System.Drawing.Point(22, 65);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(112, 27);
            this.labelCategoryName.TabIndex = 7;
            this.labelCategoryName.Text = "分类名称：";
            // 
            // labelCategoryId
            // 
            this.labelCategoryId.AutoSize = true;
            this.labelCategoryId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelCategoryId.Location = new System.Drawing.Point(41, 33);
            this.labelCategoryId.Name = "labelCategoryId";
            this.labelCategoryId.Size = new System.Drawing.Size(93, 27);
            this.labelCategoryId.TabIndex = 6;
            this.labelCategoryId.Text = "分类ID：";
            // 
            // ModifyCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 218);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModifyCategory);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.textBoxCategoryId);
            this.Controls.Add(this.labelCategoryName);
            this.Controls.Add(this.labelCategoryId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyCategory";
            this.Load += new System.EventHandler(this.ModifyCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonModifyCategory;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryId;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelCategoryId;
    }
}