namespace BooksManagementSystem.View.ManagerView.UserManagerView
{
    partial class ModifyUserMessager
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
            this.btnModify = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelTrueName = new System.Windows.Forms.Label();
            this.textBoxTrueName = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnModify.Location = new System.Drawing.Point(106, 273);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(83, 47);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnExit.Location = new System.Drawing.Point(294, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelUserId
            // 
            this.labelUserId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelUserId.Location = new System.Drawing.Point(35, 32);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(428, 25);
            this.labelUserId.TabIndex = 7;
            this.labelUserId.Text = "用户ID:";
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelUserName.Location = new System.Drawing.Point(35, 72);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(428, 25);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "用户名:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(150, 109);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(313, 34);
            this.textBoxPassword.TabIndex = 0;
            // 
            // labelTrueName
            // 
            this.labelTrueName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelTrueName.Location = new System.Drawing.Point(35, 152);
            this.labelTrueName.Name = "labelTrueName";
            this.labelTrueName.Size = new System.Drawing.Size(100, 25);
            this.labelTrueName.TabIndex = 4;
            this.labelTrueName.Text = "真实姓名:";
            // 
            // textBoxTrueName
            // 
            this.textBoxTrueName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxTrueName.Location = new System.Drawing.Point(150, 149);
            this.textBoxTrueName.Name = "textBoxTrueName";
            this.textBoxTrueName.Size = new System.Drawing.Size(313, 34);
            this.textBoxTrueName.TabIndex = 1;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxTel.Location = new System.Drawing.Point(150, 186);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(313, 34);
            this.textBoxTel.TabIndex = 2;
            // 
            // labelTel
            // 
            this.labelTel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelTel.Location = new System.Drawing.Point(35, 192);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(100, 25);
            this.labelTel.TabIndex = 3;
            this.labelTel.Text = "联系方式:";
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelPassword.Location = new System.Drawing.Point(35, 112);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 25);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "密  码:";
            // 
            // ModifyUserMessager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 356);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.textBoxTrueName);
            this.Controls.Add(this.labelTrueName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyUserMessager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyUserMessage";
            this.Load += new System.EventHandler(this.ModifyUserMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTrueName;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTrueName;
        private System.Windows.Forms.TextBox textBoxTel;

    }
}