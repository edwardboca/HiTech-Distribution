using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechDistribution.Business;
using Hi_TechDistribution.Validation;
using Hi_TechDistribution.DataAccess;

namespace Hi_TechDistribution.GUI

{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            
            if (!ValidatorUser.IsValidPassword(txtPassword.Text.Trim()))
            {
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                user.UserId = Convert.ToInt32(textUserId.Text.Trim());
                user.Password = txtPassword.Text.Trim();
                user.SaveUser(user);
                MessageBox.Show("UserId and Password have been added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                txtPassword.Clear();
            }
           
        }

        private void BtnListStudents_Click(object sender, EventArgs e)
        {
            User user = new User();
            dataGridViewUser.DataSource = user.GetUserList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            string input = "";
            input = Convert.ToString(textUserId.Text.Trim());
            if (!ValidatorEmployee.IsValidId(input))
            {
                textUserId.Clear();
                textUserId.Focus();
            }
            else
            {
                DialogResult ans = MessageBox.Show("Are you sure you want to delete?", "Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ans == DialogResult.Yes)
                {

                    user.DeleteUser(Convert.ToInt32(textUserId.Text));
                    MessageBox.Show("User deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textUserId.Text = "";
                }

                
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string input = "";
            User user = new User();
            input = txtInput.Text.Trim();

            if (!ValidatorUser.IsValidId(input))
            {
                txtInput.Clear();
                txtInput.Focus();

            }

            else
            {
                if (user != null)
                {
                    user = user.SearchUser(Convert.ToInt32(txtInput.Text.Trim()));
                    textUserId.Text = Convert.ToString(user.UserId);
                    txtPassword.Text = user.Password;
                    dataGridViewUser.DataSource = null;
                    MessageBox.Show("User Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }
                else
                {
                    MessageBox.Show("The user was not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

     

        private void Users_Load(object sender, EventArgs e)
        {
           
            
            Employee user = new Employee();
            List<Employee> listEmp = user.GetEmployeeList();

           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string input = "";
            User user = new User();
            input = textUserId.Text.Trim();
            if (!ValidatorUser.IsValidPassword(txtPassword.Text.Trim()))
            {
                txtPassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                user.UserId = Convert.ToInt32(textUserId.Text.Trim());

                user.Password = txtPassword.Text.Trim();
                user.UpdateUser(user);
                MessageBox.Show("The Userid and Password have been updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPassword.Clear();
                textUserId.Clear();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMISEmpUser back = new FormMISEmpUser();
            back.Show();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            dataGridViewUser.DataSource = user.GetUserList();
        }
    }
}
