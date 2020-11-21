namespace TestAuthAPI
{
    partial class FPasswordForgot
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.BtnConfirmSendCode = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCanel = new System.Windows.Forms.Button();
            this.LbCode = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.btnInitEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitle.Location = new System.Drawing.Point(230, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(337, 57);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Password Forgot";
            // 
            // BtnConfirmSendCode
            // 
            this.BtnConfirmSendCode.Location = new System.Drawing.Point(335, 225);
            this.BtnConfirmSendCode.Name = "BtnConfirmSendCode";
            this.BtnConfirmSendCode.Size = new System.Drawing.Size(165, 23);
            this.BtnConfirmSendCode.TabIndex = 1;
            this.BtnConfirmSendCode.Text = "Send Code";
            this.BtnConfirmSendCode.UseVisualStyleBackColor = true;
            this.BtnConfirmSendCode.Click += new System.EventHandler(this.BtnConfirmSendCode_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.Enabled = false;
            this.TxtCode.Location = new System.Drawing.Point(320, 159);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(218, 23);
            this.TxtCode.TabIndex = 2;
            this.TxtCode.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(392, 331);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCanel
            // 
            this.BtnCanel.Location = new System.Drawing.Point(289, 331);
            this.BtnCanel.Name = "BtnCanel";
            this.BtnCanel.Size = new System.Drawing.Size(75, 23);
            this.BtnCanel.TabIndex = 3;
            this.BtnCanel.Text = "BtnCancel";
            this.BtnCanel.UseVisualStyleBackColor = true;
            this.BtnCanel.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LbCode
            // 
            this.LbCode.AutoSize = true;
            this.LbCode.Enabled = false;
            this.LbCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCode.Location = new System.Drawing.Point(255, 157);
            this.LbCode.Name = "LbCode";
            this.LbCode.Size = new System.Drawing.Size(46, 21);
            this.LbCode.TabIndex = 4;
            this.LbCode.Text = "Code";
            this.LbCode.Visible = false;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(255, 118);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(48, 21);
            this.LbEmail.TabIndex = 4;
            this.LbEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(320, 120);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(218, 23);
            this.TxtEmail.TabIndex = 2;
            // 
            // btnInitEmail
            // 
            this.btnInitEmail.Location = new System.Drawing.Point(335, 268);
            this.btnInitEmail.Name = "btnInitEmail";
            this.btnInitEmail.Size = new System.Drawing.Size(165, 23);
            this.btnInitEmail.TabIndex = 5;
            this.btnInitEmail.Text = "change email";
            this.btnInitEmail.UseVisualStyleBackColor = true;
            this.btnInitEmail.Visible = false;
            this.btnInitEmail.Click += new System.EventHandler(this.btnInitEmail_Click);
            // 
            // FPasswordForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInitEmail);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbCode);
            this.Controls.Add(this.BtnCanel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnConfirmSendCode);
            this.Controls.Add(this.LbTitle);
            this.Name = "FPasswordForgot";
            this.Text = "FPasswordForgot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button BtnConfirmSendCode;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCanel;
        private System.Windows.Forms.Label LbCode;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button btnInitEmail;
    }
}