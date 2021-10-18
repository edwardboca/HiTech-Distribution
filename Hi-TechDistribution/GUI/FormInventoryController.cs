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
    public partial class FormInventoryController : Form
    {
        public FormInventoryController()
        {
            InitializeComponent();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword myPass = new FormChangePassword();
            myPass.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin mysign = new FormLogin();
            mysign.Show();
        }

        

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooks mypage = new FormBooks();
            mypage.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooksAuthors mypage = new FormBooksAuthors();
            mypage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
