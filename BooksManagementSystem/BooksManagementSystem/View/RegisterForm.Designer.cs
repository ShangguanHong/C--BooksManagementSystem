namespace BooksManagementSystem.View
{
    partial class RegisterForm
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTrueName = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTrueName = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelRePassword = new System.Windows.Forms.Label();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(140, 114);
            this.textBoxUsername.MaxLength = 50;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(229, 25);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxPassword.Location = new System.Drawing.Point(140, 151);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(229, 25);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxTrueName
            // 
            this.textBoxTrueName.Location = new System.Drawing.Point(140, 227);
            this.textBoxTrueName.Name = "textBoxTrueName";
            this.textBoxTrueName.Size = new System.Drawing.Size(229, 25);
            this.textBoxTrueName.TabIndex = 3;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(140, 266);
            this.textBoxTel.MaxLength = 11;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(229, 25);
            this.textBoxTel.TabIndex = 4;
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTel_KeyPress);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(51, 117);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 15);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "用 户 名：";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(50, 154);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 15);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "密    码：";
            // 
            // labelTrueName
            // 
            this.labelTrueName.AutoSize = true;
            this.labelTrueName.Location = new System.Drawing.Point(52, 230);
            this.labelTrueName.Name = "labelTrueName";
            this.labelTrueName.Size = new System.Drawing.Size(82, 15);
            this.labelTrueName.TabIndex = 6;
            this.labelTrueName.Text = "真实姓名：";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(52, 269);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(82, 15);
            this.labelTel.TabIndex = 7;
            this.labelTel.Text = "联系方式：";
            // 
            // labelRePassword
            // 
            this.labelRePassword.AutoSize = true;
            this.labelRePassword.Location = new System.Drawing.Point(52, 192);
            this.labelRePassword.Name = "labelRePassword";
            this.labelRePassword.Size = new System.Drawing.Size(82, 15);
            this.labelRePassword.TabIndex = 9;
            this.labelRePassword.Text = "重复密码：";
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxRePassword.Location = new System.Drawing.Point(140, 189);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.Size = new System.Drawing.Size(229, 25);
            this.textBoxRePassword.TabIndex = 2;
            // 
            // buttonRegister
            // 
            this.buttonRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRegister.Location = new System.Drawing.Point(179, 317);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(67, 36);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "注册";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelHint
            // 
            this.labelHint.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHint.Location = new System.Drawing.Point(12, 21);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(394, 64);
            this.labelHint.TabIndex = 12;
            this.labelHint.Text = "请填写以下信息以完成注册";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 386);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonRegister);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Shown += new System.EventHandler(this.RegisterForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTrueName;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTrueName;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelRePassword;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelHint;
    }
}