using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TestAuthAPI.Controllers;
using TestAuthAPI.Models.Entities;
using TestAuthAPI.Outils;

namespace TestAuthAPI
{
    public partial class FDemandRegister : Form
    {
        MyUserController myUserController = new MyUserController();
        public FDemandRegister()
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

        private void BtnDemandRegister_Click(object sender, EventArgs e)
        {

            //for register
            MyOrganization organizationClient = myUserController.register(TxtNameOrg.Text.ToString().ToLower().ToLower(), TxtEmail.Text.ToString().ToLower().ToLower(), TxtContact.Text.ToString().ToLower().ToLower());
            if (organizationClient != null)
            {
                MessageBox.Show("Great Register " + organizationClient.ToString() + " Please wait until we validate your request");
                //new FDashboard(userLogged).Show();
                //InitDatagrid();
            }
            else
                MessageBox.Show("You did not register or you already registered");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
