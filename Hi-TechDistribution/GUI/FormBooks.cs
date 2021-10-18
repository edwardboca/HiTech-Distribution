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
using Hi_TechDistribution.Business;
using Hi_TechDistribution.Validation;

namespace Hi_TechDistribution.GUI
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }
        private void CmbBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = cmbBookCategory.SelectedItem.ToString();
            cat = cat.Trim();
            string[] category = cat.Split(',');
            string catId = category[0];
            cmbBookCategory.ValueMember = catId;

        }

        private void CmbPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pub = cmbPublisher.SelectedItem.ToString();
            pub = pub.Trim();
            string[] publisher = pub.Split(',');
            string pubId = publisher[0];
            cmbPublisher.ValueMember = pubId;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            Book book1 = new Book();
            book1.Isbn = Convert.ToInt32(txtISBN.Text.Trim());
            book1.Title = txtTitle.Text.Trim();
            book1.UnitPrice = Convert.ToInt32(txtUnitPrice.Text.Trim());
            book1.QuantityOnHand = Convert.ToInt32(txtQuantity.Text.Trim());           
            book1.CategoryId = Convert.ToInt32(cmbBookCategory.ValueMember);
            book1.PublisherId = Convert.ToInt32(cmbPublisher.ValueMember);
            book1.SaveBook(book1);
            MessageBox.Show("Book record has been saved successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtISBN.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();

        }

        private void BtnListFromDB_Click(object sender, EventArgs e)
        {
            Book book1 = new Book();
            dataGridViewBooks.DataSource = book1.GetBookList();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            comboBoxOption.SelectedIndex = 0;
            Category cat = new Category();
            List<Category> listCat = cat.GetCategoriesList();
            cmbBookCategory.Items.Add("---Select Book Category---");
            cmbBookCategory.SelectedIndex = 0;
            foreach (var item in listCat)
            {

                cmbBookCategory.Items.Add(item.CategoryId + "," + item.CategoryName);
            }

            Publisher pub = new Publisher();
            List<Publisher> listPub = pub.GetPublishersList();
            cmbPublisher.Items.Add("---Select Publisher---");
            cmbPublisher.SelectedIndex = 0;
            foreach (var item in listPub)
            {
                cmbPublisher.Items.Add(item.PublisherId + "," + item.PublisherName);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Book emp = new Book();
            string input = "";
            input = Convert.ToString(txtInput.Text.Trim());
            if (!ValidatorBook.IsValidIsbn(input))
            {
                txtInput.Clear();
                txtInput.Focus();
            }

            else
            {
                DialogResult ans = MessageBox.Show("Do you really want to delete the data??", "Ask for delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ans == DialogResult.Yes)
                {
                    MessageBox.Show("You want to delete the data...", "Want to Delete..", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    emp.DeleteBook(Convert.ToInt32(txtInput.Text));
                    MessageBox.Show("Employee data has been deleted successfully...", "Delete Information..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInput.Text = "";
                }
                else
                {
                    MessageBox.Show("You donot want to delete the data...", "No deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtInput.Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string input = "";
            Book book1 = new Book();
            input = txtInput.Text.Trim();

            book1.Isbn = Convert.ToInt32(txtInput.Text.Trim());
            book1.Title = txtTitle.Text.Trim();
            book1.UnitPrice = Convert.ToInt32(txtUnitPrice.Text.Trim());
            book1.QuantityOnHand = Convert.ToInt32(txtQuantity.Text.Trim());
            book1.CategoryId = Convert.ToInt32(cmbBookCategory.ValueMember);
            book1.PublisherId = Convert.ToInt32(cmbPublisher.ValueMember);
            book1.UpdateBook(book1);
            MessageBox.Show("Book record has been updated successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtISBN.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtInput.Clear();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxOption.SelectedIndex == 1 && txtInput.Text != "")
            {
                string input = "";
                Book book1 = new Book();
                input = txtInput.Text.Trim();
                if (!ValidatorBook.IsValidIsbn(input))
                {
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    book1 = book1.SearchBook(Convert.ToInt32(txtInput.Text.Trim()));
                    if (book1 != null)
                    {
                        txtISBN.Text = Convert.ToString(book1.Isbn);
                        txtTitle.Text = book1.Title;
                        txtUnitPrice.Text = Convert.ToString(book1.UnitPrice);
                        txtQuantity.Text = Convert.ToString(book1.QuantityOnHand);
                        cmbBookCategory.Text = Convert.ToString(book1.CategoryId);
                        cmbPublisher.Text = Convert.ToString(book1.PublisherId);
                    }
                    else
                    {
                        MessageBox.Show("No Book data in the database", "No Book Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }

            else
            {
                int catId;
                catId = Convert.ToInt32(txtInput.Text.Trim());
                Book book1 = new Book();
                List<Book> listBook = book1.SearchBookByCat(catId);

                if (listBook != null)
                {
                    foreach (Book bookItem in listBook.ToList())
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(bookItem.Isbn));
                        item.SubItems.Add(bookItem.Title);
                        item.SubItems.Add(Convert.ToString(bookItem.UnitPrice));
                        item.SubItems.Add(Convert.ToString(bookItem.QuantityOnHand));
                        item.SubItems.Add(Convert.ToString(bookItem.CategoryId));
                        item.SubItems.Add(Convert.ToString(bookItem.PublisherId));
                        listBook.Add(bookItem);
                    }
                    dataGridViewBooks.DataSource = listBook;

                }
                else
                {
                    MessageBox.Show("No Book data in the database", "No Book Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void GbEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryController mysign = new FormInventoryController();
            mysign.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
                    }
    }
}
