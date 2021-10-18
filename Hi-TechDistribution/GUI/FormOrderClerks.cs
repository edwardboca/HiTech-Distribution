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
    public partial class FormOrderClerks : Form
    {
        public FormOrderClerks()
        {
            InitializeComponent();
        }
 

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin mysign = new FormLogin();
            mysign.Show();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrders myorder = new FormOrders();
            myorder.Show();
        }

       

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword myPass = new FormChangePassword();
            myPass.Show();
        }
    }
}
