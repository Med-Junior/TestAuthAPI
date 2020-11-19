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
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitle.Location = new System.Drawing.Point(140, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(508, 57);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Demand Register Account";
            // 
            // BtnDemand
            // 
            this.BtnDemand.Location = new System.Drawing.Point(314, 283);
            this.BtnDemand.Name = "BtnDemand";
            this.BtnDemand.Size = new System.Drawing.Size(132, 23);
            this.BtnDemand.TabIndex = 3;
            this.BtnDemand.Text = "DemandRegister";
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
            this.BtnLogin.Location = new System.Drawing.Point(471, 322);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(132, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FDemandRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
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
    }
}