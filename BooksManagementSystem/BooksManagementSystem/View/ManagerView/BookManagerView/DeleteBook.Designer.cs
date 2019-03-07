namespace BooksManagementSystem.View
{ 
    partial class DeleteBook
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
            this.ID = new System.Windows.Forms.TextBox();
            this.lab_ISBN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(176, 117);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(33, 117);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(106, 23);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "确认删除";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(187, 59);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 25);
            this.ID.TabIndex = 13;
            // 
            // lab_ISBN
            // 
            this.lab_ISBN.AutoSize = true;
            this.lab_ISBN.Location = new System.Drawing.Point(30, 62);
            this.lab_ISBN.Name = "lab_ISBN";
            this.lab_ISBN.Size = new System.Drawing.Size(151, 15);
            this.lab_ISBN.TabIndex = 12;
            this.lab_ISBN.Text = "输入删除图书的ID号:";
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 218);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lab_ISBN);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Name = "DeleteBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button cancel;
    private System.Windows.Forms.Button confirm;
    private System.Windows.Forms.TextBox ID;
    private System.Windows.Forms.Label lab_ISBN;
}
}