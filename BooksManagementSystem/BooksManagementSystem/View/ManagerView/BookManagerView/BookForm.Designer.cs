namespace BooksManagementSystem.View.ManagerView.BookManagerView
{
    partial class BookForm
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
            this.lab_ISBN = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.locaiton = new System.Windows.Forms.TextBox();
            this.labelLaction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_ISBN
            // 
            this.lab_ISBN.AutoSize = true;
            this.lab_ISBN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lab_ISBN.Location = new System.Drawing.Point(42, 83);
            this.lab_ISBN.Name = "lab_ISBN";
            this.lab_ISBN.Size = new System.Drawing.Size(199, 27);
            this.lab_ISBN.TabIndex = 2;
            this.lab_ISBN.Text = "输入新增图书ISBN：";
            // 
            // ISBN
            // 
            this.ISBN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ISBN.Location = new System.Drawing.Point(262, 80);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(244, 34);
            this.ISBN.TabIndex = 6;
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.confirm.Location = new System.Drawing.Point(139, 248);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(91, 52);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cancel.Location = new System.Drawing.Point(344, 248);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 52);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "退出";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // locaiton
            // 
            this.locaiton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.locaiton.Location = new System.Drawing.Point(262, 158);
            this.locaiton.Name = "locaiton";
            this.locaiton.Size = new System.Drawing.Size(244, 34);
            this.locaiton.TabIndex = 11;
            // 
            // labelLaction
            // 
            this.labelLaction.AutoSize = true;
            this.labelLaction.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelLaction.Location = new System.Drawing.Point(109, 161);
            this.labelLaction.Name = "labelLaction";
            this.labelLaction.Size = new System.Drawing.Size(132, 27);
            this.labelLaction.TabIndex = 10;
            this.labelLaction.Text = "图书存放地：";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 355);
            this.Controls.Add(this.locaiton);
            this.Controls.Add(this.labelLaction);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.lab_ISBN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lab_ISBN;
        protected System.Windows.Forms.TextBox ISBN;
        protected System.Windows.Forms.Button confirm;
        protected System.Windows.Forms.Button cancel;
        protected System.Windows.Forms.TextBox locaiton;
        protected System.Windows.Forms.Label labelLaction;
    }
}