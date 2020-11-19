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
            this.TxtEmailAndCode = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitle.Location = new System.Drawing.Point(221, 124);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(337, 57);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Password Forgot";
            // 
            // BtnConfirmSendCode
            // 
            this.BtnConfirmSendCode.Location = new System.Drawing.Point(269, 255);
            this.BtnConfirmSendCode.Name = "BtnConfirmSendCode";
            this.BtnConfirmSendCode.Size = new System.Drawing.Size(165, 23);
            this.BtnConfirmSendCode.TabIndex = 1;
            this.BtnConfirmSendCode.Text = "Send Code";
            this.BtnConfirmSendCode.UseVisualStyleBackColor = true;
            this.BtnConfirmSendCode.Click += new System.EventHandler(this.BtnConfirmSendCode_Click);
            // 
            // TxtEmailAndCode
            // 
            this.TxtEmailAndCode.Location = new System.Drawing.Point(245, 201);
            this.TxtEmailAndCode.Name = "TxtEmailAndCode";
            this.TxtEmailAndCode.Size = new System.Drawing.Size(218, 23);
            this.TxtEmailAndCode.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(344, 342);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCanel
            // 
            this.BtnCanel.Location = new System.Drawing.Point(245, 342);
            this.BtnCanel.Name = "BtnCanel";
            this.BtnCanel.Size = new System.Drawing.Size(75, 23);
            this.BtnCanel.TabIndex = 3;
            this.BtnCanel.Text = "BtnCancel";
            this.BtnCanel.UseVisualStyleBackColor = true;
            this.BtnCanel.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FPasswordForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCanel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtEmailAndCode);
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
        private System.Windows.Forms.TextBox TxtEmailAndCode;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCanel;
    }
}