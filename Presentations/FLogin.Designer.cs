namespace TestAuthAPI
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoggin = new System.Windows.Forms.Button();
            this.BtnDemandRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.BtnForgotPwd = new System.Windows.Forms.Button();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoggin
            // 
            this.BtnLoggin.Location = new System.Drawing.Point(179, 228);
            this.BtnLoggin.Name = "BtnLoggin";
            this.BtnLoggin.Size = new System.Drawing.Size(94, 33);
            this.BtnLoggin.TabIndex = 0;
            this.BtnLoggin.Text = "LOG IN";
            this.BtnLoggin.UseVisualStyleBackColor = true;
            this.BtnLoggin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnDemandRegister
            // 
            this.BtnDemandRegister.Location = new System.Drawing.Point(207, 296);
            this.BtnDemandRegister.Name = "BtnDemandRegister";
            this.BtnDemandRegister.Size = new System.Drawing.Size(156, 23);
            this.BtnDemandRegister.TabIndex = 0;
            this.BtnDemandRegister.Text = "DEMAND REGISTER";
            this.BtnDemandRegister.UseVisualStyleBackColor = true;
            this.BtnDemandRegister.Click += new System.EventHandler(this.BtnDemandRegister_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(170, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(170, 176);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(224, 23);
            this.txtPwd.TabIndex = 2;
            // 
            // BtnForgotPwd
            // 
            this.BtnForgotPwd.Location = new System.Drawing.Point(279, 228);
            this.BtnForgotPwd.Name = "BtnForgotPwd";
            this.BtnForgotPwd.Size = new System.Drawing.Size(100, 33);
            this.BtnForgotPwd.TabIndex = 3;
            this.BtnForgotPwd.Text = "ForgetPassword";
            this.BtnForgotPwd.UseVisualStyleBackColor = true;
            this.BtnForgotPwd.Click += new System.EventHandler(this.BtnForgotPwd_Click);
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(82, 127);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(48, 21);
            this.LbEmail.TabIndex = 4;
            this.LbEmail.Text = "Email";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPassword.Location = new System.Drawing.Point(82, 178);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(76, 21);
            this.LbPassword.TabIndex = 4;
            this.LbPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.BtnForgotPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDemandRegister);
            this.Controls.Add(this.BtnLoggin);
            this.Name = "FLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoggin;
        private System.Windows.Forms.Button BtnDemandRegister;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button BtnForgotPwd;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label label1;
    }
}

