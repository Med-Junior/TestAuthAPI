namespace TestAuthAPI
{
    partial class FDemandRegister
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
            this.BtnDemand = new System.Windows.Forms.Button();
            this.TxtNameOrg = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitle.Location = new System.Drawing.Point(191, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(508, 57);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Demand Register Account";
            // 
            // BtnDemand
            // 
            this.BtnDemand.Location = new System.Drawing.Point(314, 272);
            this.BtnDemand.Name = "BtnDemand";
            this.BtnDemand.Size = new System.Drawing.Size(132, 23);
            this.BtnDemand.TabIndex = 3;
            this.BtnDemand.Text = "Demand";
            this.BtnDemand.UseVisualStyleBackColor = true;
            this.BtnDemand.Click += new System.EventHandler(this.BtnDemandRegister_Click);
            // 
            // TxtNameOrg
            // 
            this.TxtNameOrg.Location = new System.Drawing.Point(259, 126);
            this.TxtNameOrg.Name = "TxtNameOrg";
            this.TxtNameOrg.Size = new System.Drawing.Size(224, 23);
            this.TxtNameOrg.TabIndex = 2;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(259, 176);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(224, 23);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtContact
            // 
            this.TxtContact.Location = new System.Drawing.Point(259, 221);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(224, 23);
            this.TxtContact.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(314, 340);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(132, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(167, 125);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 21);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(167, 174);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(48, 21);
            this.LbEmail.TabIndex = 4;
            this.LbEmail.Text = "Email";
            // 
            // LbPhone
            // 
            this.LbPhone.AutoSize = true;
            this.LbPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPhone.Location = new System.Drawing.Point(167, 223);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(80, 21);
            this.LbPhone.TabIndex = 4;
            this.LbPhone.Text = "Telephone";
            // 
            // FDemandRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.LbPhone);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNameOrg);
            this.Controls.Add(this.BtnDemand);
            this.Controls.Add(this.LbTitle);
            this.Name = "FDemandRegister";
            this.Text = "FDemandRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Button BtnDemand;
        private System.Windows.Forms.TextBox TxtNameOrg;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbPhone;
    }
}