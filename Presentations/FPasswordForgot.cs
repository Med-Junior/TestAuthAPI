using TestAuthAPI.Outils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestAuthAPI
{
    public partial class FPasswordForgot : Form
    { 
        bool showInterfaceCode = false;
        string CodeToSendConfirmEmail = "";
        public FPasswordForgot()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FormChild_Close);
        }

        private void FormChild_Close(object sender, EventArgs e)
        {
            //Show the Login Form when closing
            if (MyHelpers.firstForm != null && Application.OpenForms.Count == 1)
                MyHelpers.firstForm.Show();
        }
        private bool emailExistInDatabase()
        {
            return true;
        }

        private void BtnConfirmSendCode_Click(object sender, EventArgs e)
        {
            if(BtnConfirmSendCode.Text.ToString().Equals("Send Code"))
            {
                //if the email exist
                if (emailExistInDatabase())
                {  
                    showInterfaceCode = true;
                    switchInterface();
                }
                else
                {
                    //echec valid email
                    MessageBox.Show("Mail invalid");
                    showInterfaceCode = false;
                    switchInterface();
                }
            }
            else
            {
                if (
                    TxtCode.Text.ToString().Trim().
                    Equals(CodeToSendConfirmEmail.Trim()))
                {
                    //valide code go to parmas new password
                    new FNewPassword().Show();
                    this.Close(); 
                }
                else
                {
                    //echec code
                    MessageBox.Show("Code invalid");
                }
            }
        }

        private void switchInterface()
        {
            if (showInterfaceCode)
            {
                LbCode.Enabled = true;
                LbCode.Visible = true;
                TxtCode.Enabled = true;
                TxtCode.Visible = true;
                btnInitEmail.Enabled = true;
                btnInitEmail.Visible = true;

                LbEmail.Enabled = false; 
                TxtEmail.Enabled = false;
                BtnConfirmSendCode.Text = "Confirm Code";
            }
            else
            {
                LbCode.Enabled = false;
                LbCode.Visible = false;
                TxtCode.Enabled = false;
                TxtCode.Visible = false;
                btnInitEmail.Enabled = false;
                btnInitEmail.Visible = false;

                LbEmail.Enabled = true;  
                TxtEmail.Enabled = true;
                BtnConfirmSendCode.Text = "Send Code";
            }
        }

        private void btnInitEmail_Click(object sender, EventArgs e)
        { 
            showInterfaceCode = false;
            switchInterface();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
