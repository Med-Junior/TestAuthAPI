namespace TestAuthAPI
{
    partial class FNewPassword
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
            this.BtnSavePwd = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitle.Location = new System.Drawing.Point(232, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(384, 57);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Add New Password";
            // 
            // BtnSavePwd
            // 
            this.BtnSavePwd.Location = new System.Drawing.Point(306, 272);
            this.BtnSavePwd.Name = "BtnSavePwd";
            this.BtnSavePwd.Size = new System.Drawing.Size(259, 23);
            this.BtnSavePwd.TabIndex = 3;
            this.BtnSavePwd.Text = "Save Password";
            this.BtnSavePwd.UseVisualStyleBackColor = true;
            this.BtnSavePwd.Click += new System.EventHandler(this.BtnSavePwd_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(306, 363);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "BtnLogin";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(424, 363);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(306, 123);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(259, 23);
            this.TxtPassword.TabIndex = 1;
            // 
            // TxtPasswordConfirm
            // 
            this.TxtPasswordConfirm.Location = new System.Drawing.Point(306, 196);
            this.TxtPasswordConfirm.Name = "TxtPasswordConfirm";
            this.TxtPasswordConfirm.Size = new System.Drawing.Size(259, 23);
            this.TxtPasswordConfirm.TabIndex = 2;
            // 
            // FNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPasswordConfirm);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnSavePwd);
            this.Controls.Add(this.LbTitle);
            this.Name = "FNewPassword";
            this.Text = "FNewPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button BtnSavePwd;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtPasswordConfirm;
    }
}