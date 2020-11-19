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
        bool IsEmailValide = false;
        bool IsCodeValide = false;
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

        private void BtnConfirmSendCode_Click(object sender, EventArgs e)
        {

            IsEmailValide = true;
            if (IsEmailValide)
            {
                BtnConfirmSendCode.Text = "Confirm Code";
                //send Code
                IsCodeValide = true;

                if (IsCodeValide)
                {
                    //valide code go to parmas new password
                    FNewPassword newPassword = new FNewPassword();
                    newPassword.Show();
                    this.Close();
                }
                else
                {
                    //echec code
                    BtnConfirmSendCode.Text = "Confirm Code";
                }
            }
            else
            {
                //echec valid email
                BtnConfirmSendCode.Text = "Send Code";
            }


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
