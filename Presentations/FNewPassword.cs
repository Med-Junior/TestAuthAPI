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
    public partial class FNewPassword : Form
    {
        public FNewPassword()
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
        private void BtnSavePwd_Click(object sender, EventArgs e)
        {
            //check if password is equal and then save
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
