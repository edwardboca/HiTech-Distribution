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

namespace Hi_TechDistribution.GUI
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            User user = new User();
          
            if (!ValidatorUser.IsValidId(txtUserId.Text.Trim()))
            {
                txtUserId.Clear();                
                return;

            }

            if(!ValidatorUser.IsValidPassword(txtPassword.Text.Trim()))
            {
                txtPassword.Clear();                
                return;
            }
            if (!ValidatorUser.IsValidPassword(txtConfirmPassword.Text.Trim()))
            {
                txtConfirmPassword.Clear();
                return;
            }
            user.UserId = Convert.ToInt32(txtUserId.Text.Trim());
            user.Password = txtPassword.Text.Trim();
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                user.UpdateUser(user);
                MessageBox.Show("Password Has Been Changed", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
            {
                MessageBox.Show("The Two Passwords Do Not Match! Please Enter Again!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            txtUserId.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin back = new FormLogin();
            back.Show();
        }
    }
}
