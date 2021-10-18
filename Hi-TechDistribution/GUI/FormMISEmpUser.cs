using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_TechDistribution.GUI
{
    public partial class FormMISEmpUser : Form
    {
        public FormMISEmpUser()
        {
            InitializeComponent();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsers myuser = new FormUsers();
            myuser.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployees mypage = new FormEmployees();
            mypage.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin mysign = new FormLogin();
            mysign.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword myPass = new FormChangePassword();
            myPass.Show();
        }
    }
}
