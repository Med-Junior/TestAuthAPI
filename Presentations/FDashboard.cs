using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TestAuthAPI.Models.Entities;
using TestAuthAPI.Outils;

namespace TestAuthAPI
{
    public partial class FDashboard : Form
    {
        private MyUser userLogged = null;
        public FDashboard()
        {
            InitializeComponent();
        }
        public FDashboard(MyUser user)
        {
            userLogged = new MyUser(user);
            InitializeComponent();
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            if(userLogged != null)
                LbTitle.Text += userLogged.Email;
            this.FormClosed += new FormClosedEventHandler(FormChild_Close);
        }

        private void FormChild_Close(object sender, EventArgs e)
        {
            //Show the Login Form when closing
            if (MyHelpers.firstForm != null && Application.OpenForms.Count == 1)
                MyHelpers.firstForm.Show();
        }
    }
}
