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

        private bool valideText(string texte)
        {
            return texte.ToLower().Trim().Length != 0;
        }
        private void BtnDemandRegister_Click(object sender, EventArgs e)
        {
            if (
                valideText(TxtNameOrg.Text.ToString()) &&
                valideText(TxtEmail.Text.ToString())
                )
            {
                string messageError = null;
                //for Demand ofnew organization
                MyOrganization organizationClient = myUserController.register(
                    new MyOrganization(
                        TxtNameOrg.Text.ToString().Trim().ToLower(),
                        TxtEmail.Text.ToString().Trim().ToLower(),
                        TxtContact.Text.ToString().Trim().ToLower(),
                         DateTime.Now.ToShortDateString(), "",""
                        ), out messageError);
                if (organizationClient != null)
                {
                    MessageBox.Show("Great Demand " + organizationClient.ToString() + " Please wait until we validate your request");
                    //new FDashboard(userLogged).Show();
                    //InitDatagrid();
                }
                else
                    MessageBox.Show("You did not register or you already registered \n" + messageError);

            }
            else
                MessageBox.Show("Please fill the champ");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
