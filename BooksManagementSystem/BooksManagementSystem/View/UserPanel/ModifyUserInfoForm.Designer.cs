namespace BooksManagementSystem.View.UserPanel
{
    partial class ModifyUserInfoForm
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
            this.buttonModifyUserInfo = new System.Windows.Forms.Button();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.labelRePassword = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelTrueName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxTrueName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonModifyUserInfo
            // 
            this.buttonModifyUserInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonModifyUserInfo.Location = new System.Drawing.Point(147, 319);
            this.buttonModifyUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifyUserInfo.Name = "buttonModifyUserInfo";
            this.buttonModifyUserInfo.Size = new System.Drawing.Size(113, 44);
            this.buttonModifyUserInfo.TabIndex = 5;
            this.buttonModifyUserInfo.Text = "修改资料";
            this.buttonModifyUserInfo.UseVisualStyleBackColor = true;
            this.buttonModifyUserInfo.Click += new System.EventHandler(this.buttonModifyUserInfo_Click);
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxRePassword.Location = new System.Drawing.Point(137, 182);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.Size = new System.Drawing.Size(229, 25);
            this.textBoxRePassword.TabIndex = 12;
            // 
            // labelRePassword
            // 
            this.labelRePassword.AutoSize = true;
            this.labelRePassword.Location = new System.Drawing.Point(49, 185);
            this.labelRePassword.Name = "labelRePassword";
            this.labelRePassword.Size = new System.Drawing.Size(82, 15);
            this.labelRePassword.TabIndex = 19;
            this.labelRePassword.Text = "重复密码：";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(49, 262);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(82, 15);
            this.labelTel.TabIndex = 18;
            this.labelTel.Text = "联系方式：";
            // 
            // labelTrueName
            // 
            this.labelTrueName.AutoSize = true;
            this.labelTrueName.Location = new System.Drawing.Point(49, 223);
            this.labelTrueName.Name = "labelTrueName";
            this.labelTrueName.Size = new System.Drawing.Size(82, 15);
            this.labelTrueName.TabIndex = 17;
            this.labelTrueName.Text = "真实姓名：";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(47, 147);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 15);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "密    码：";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(48, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 15);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "用 户 名：";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(137, 259);
            this.textBoxTel.MaxLength = 11;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(229, 25);
            this.textBoxTel.TabIndex = 15;
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTel_KeyPress);
            // 
            // textBoxTrueName
            // 
            this.textBoxTrueName.Location = new System.Drawing.Point(137, 220);
            this.textBoxTrueName.Name = "textBoxTrueName";
            this.textBoxTrueName.Size = new System.Drawing.Size(229, 25);
            this.textBoxTrueName.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPassword.Location = new System.Drawing.Point(137, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(229, 25);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Enabled = false;
            this.textBoxUsername.Location = new System.Drawing.Point(137, 107);
            this.textBoxUsername.MaxLength = 50;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(229, 25);
            this.textBoxUsername.TabIndex = 10;
            // 
            // labelHint
            // 
            this.labelHint.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHint.Location = new System.Drawing.Point(12, 19);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(394, 64);
            this.labelHint.TabIndex = 20;
            this.labelHint.Text = "修改资料";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 404);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxRePassword);
            this.Controls.Add(this.labelRePassword);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelTrueName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxTrueName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonModifyUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyUserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyUserInfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyUserInfoForm_FormClosed);
            this.Load += new System.EventHandler(this.ModifyUserInfoForm_Load);
            this.Shown += new System.EventHandler(this.ModifyUserInfoForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyUserInfo;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.Label labelRePassword;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelTrueName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxTrueName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelHint;
    }
}