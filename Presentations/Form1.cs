using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAuthAPI.Controllers;
using TestAuthAPI.Models.DALs;
using TestAuthAPI.Models.Entities;
using TestAuthAPI.Outils;

namespace TestAuthAPI
{
    public partial class Form1 : Form
    {
        DataTable CurrentDataTable = new DataTable();
        MyUserController myUserController = new MyUserController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDatagrid();
            MyHelpers.firstForm = this;
        }

        private void InitDatagrid()
        {
            /*
             * the next step is to use the API to R
             * function Update and Delete
             * You have use this.close in generateDALFILE()
             * 
             */
            /*
            DataColumn ColumnLigneFacture = new DataColumn();
            
            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.Int64");
            ColumnLigneFacture.ColumnName = "Id";
            ColumnLigneFacture.ReadOnly = false;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTable.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "ELlk";
            ColumnLigneFacture.ReadOnly = false;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTable.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Password";
            ColumnLigneFacture.ReadOnly = false;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTable.Columns.Add(ColumnLigneFacture);

            */
            dataGridView1.DataSource = DAL_MyUser.GetAllMyUser(out string txt);


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //for logging
            MyUser userLogged =  myUserController.Login(txtEmail.Text.ToString().ToLower().ToLower(), txtPwd.Text.ToString().Trim());
            if (userLogged != null)
            {
                MessageBox.Show("Great Logged " + userLogged.ToString());
                new FDashboard(userLogged).Show();
                this.Hide();
                //InitDatagrid();
            }
            else
                MessageBox.Show("Great You did not logged");
        }

        private void BtnDemandRegister_Click(object sender, EventArgs e)
        {
            openNewForms(new FDemandRegister());
        }

        private void BtnForgotPwd_Click(object sender, EventArgs e)
        {
            openNewForms(new FPasswordForgot());
        }

        private void openNewForms(Form FormToOpen)
        {
            FormToOpen.Show();
            this.Hide();
        }

    }
}
