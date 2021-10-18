using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechDistribution.DataAccess;
using System.Data.SqlClient;
using Hi_TechDistribution.Business;
using Hi_TechDistribution.Validation;


namespace Hi_TechDistribution.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidatorUser.IsValidId(txtUserId.Text))
            {
                txtUserId.Clear();
                return;
            }
            if (!ValidatorUser.IsValidPassword(txtPassword.Text))
            {
                txtPassword.Clear();
                return;
            }

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand("select * from Users where UserId='" + txtUserId.Text + "' AND Password = '" + txtPassword.Text + "'", connDB);

            SqlDataReader dr = cmd.ExecuteReader();
            if ((dr.Read() == true))
            { 
                    if ( txtUserId.Text == "12131")
            {
                MessageBox.Show("Welcome Henry Brown! Press OK To Continue");
                FormMISEmpUser Brown = new FormMISEmpUser();
                Brown.Show();
                this.Hide();
            }

            else if ( txtUserId.Text == "12132")
            {
                MessageBox.Show("Welcome Thomas Moore! Press OK To Continue");

                FormCustomers Moore = new FormCustomers();
                Moore.Show();
                this.Hide();

            }

            else if ( txtUserId.Text == "12133")
                {
                    MessageBox.Show("Welcome Peter Wang! Press OK To Continue");
                    FormInventoryController Wang = new FormInventoryController();
                    Wang.Show();
                    this.Hide();
                }
                else if (txtUserId.Text == "12134")
                {
                    MessageBox.Show("Welcome Mary Brown! Press OK To Continue");
                    FormOrderClerks Brown = new FormOrderClerks();
                    Brown.Show();
                    this.Hide();
                }
                else if ( txtUserId.Text == "12135")
                {
                    MessageBox.Show("Welcome Jennifer Bouchard! Press OK To Continue");
                    FormOrderClerks Bouchard = new FormOrderClerks();
                    Bouchard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username or Password you’ve entered doesn’t match any account", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The Username or Password you’ve entered doesn’t match any account", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormChangePassword password = new FormChangePassword();
            password.Show();
        }
    }
}
