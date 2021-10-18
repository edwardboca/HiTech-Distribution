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
    public partial class FormSalesCustomer : Form
    {
        public FormSalesCustomer()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin mysign = new FormLogin();
            mysign.Show();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomers mypage = new FormCustomers();
            mypage.Show();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword myPass = new FormChangePassword();
            myPass.Show();
        }
    }
}
