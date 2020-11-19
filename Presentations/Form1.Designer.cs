namespace TestAuthAPI
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoggin
            // 
            this.BtnLoggin.Location = new System.Drawing.Point(79, 231);
            this.BtnLoggin.Name = "BtnLoggin";
            this.BtnLoggin.Size = new System.Drawing.Size(75, 23);
            this.BtnLoggin.TabIndex = 0;
            this.BtnLoggin.Text = "LOG IN";
            this.BtnLoggin.UseVisualStyleBackColor = true;
            this.BtnLoggin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnDemandRegister
            // 
            this.BtnDemandRegister.Location = new System.Drawing.Point(386, 372);
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
            this.dataGridView1.Location = new System.Drawing.Point(386, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(46, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(46, 170);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(224, 23);
            this.txtPwd.TabIndex = 2;
            // 
            // BtnForgotPwd
            // 
            this.BtnForgotPwd.Location = new System.Drawing.Point(170, 231);
            this.BtnForgotPwd.Name = "BtnForgotPwd";
            this.BtnForgotPwd.Size = new System.Drawing.Size(100, 23);
            this.BtnForgotPwd.TabIndex = 3;
            this.BtnForgotPwd.Text = "ForgetPassword";
            this.BtnForgotPwd.UseVisualStyleBackColor = true;
            this.BtnForgotPwd.Click += new System.EventHandler(this.BtnForgotPwd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.BtnForgotPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDemandRegister);
            this.Controls.Add(this.BtnLoggin);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

