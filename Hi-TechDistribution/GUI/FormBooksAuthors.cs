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
    public partial class FormBooksAuthors : Form
    {
        public FormBooksAuthors()
        {
            InitializeComponent();
        }

        private void BooksAuthors_Load(object sender, EventArgs e)
        {
            
            Book book1 = new Book();

            List<Book> listBook = book1.GetBookList();
           
            
            foreach (var item in listBook)
            {
                cmbIsbn.Items.Add(item.Isbn);

            }

            Author aut = new Author();

            List<Author> listAuthor = aut.GetAuthorList();
            cmbAuthorId.Items.Add("--Select Author--");
            cmbAuthorId.SelectedIndex = 0;
            cmbAuthorId.SelectedIndex = 0;
            foreach (var item in listAuthor)
            {
                cmbAuthorId.Items.Add(item.AuthorId);

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BookAuthor book1 = new BookAuthor();
            book1.Isbn = Convert.ToInt32(cmbIsbn.SelectedItem);
            book1.AuthorId = Convert.ToInt32(cmbAuthorId.SelectedItem);
            book1.YearPublished = Convert.ToInt32(txtYearPub.Text);
           
            book1.SaveBook(book1);
            MessageBox.Show("Book record has been saved successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtYearPub.Clear();
        }

        private void BtnListOrderedItems_Click(object sender, EventArgs e)
        {
            BookAuthor book1 = new BookAuthor();
            dataGridViewBooks.DataSource = book1.GetBookAuthorList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            BookAuthor emp = new BookAuthor();
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
                    MessageBox.Show("Book data has been deleted successfully...", "Delete Information..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInput.Text = "";
                }
                else
                {
                    MessageBox.Show("You donot want to delete the data...", "No deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtInput.Clear();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            string input = "";
            BookAuthor book1 = new BookAuthor();
            input = txtInput.Text.Trim();

            book1.Isbn = Convert.ToInt32(txtInput.Text.Trim());
            book1.AuthorId = Convert.ToInt32(cmbAuthorId.SelectedItem);
            book1.YearPublished = Convert.ToInt32(txtYearPub.Text.Trim());
            
            book1.UpdateBookAuthor(book1);
            MessageBox.Show("Record has been updated successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtYearPub.Clear();
            cmbIsbn.SelectedIndex = 0;
            cmbAuthorId.SelectedIndex = 0;
            txtInput.Clear();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
           
                string input = "";
                BookAuthor book1 = new BookAuthor();
                input = txtInput.Text.Trim();
                if (!ValidatorBook.IsValidIsbn(input))
                {
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    book1 = book1.SearchBookAuthor(Convert.ToInt32(txtInput.Text.Trim()));
                    if (book1 != null)
                    {
                        cmbIsbn.Text = Convert.ToString(book1.Isbn);
                        cmbAuthorId.Text = Convert.ToString(book1.AuthorId);
                        txtYearPub.Text = Convert.ToString(book1.YearPublished);

                    }
                    else
                    {
                        MessageBox.Show("No data in the database", "No Book Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryController mysign = new FormInventoryController();
            mysign.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          ;
            BookAuthor book1 = new BookAuthor();
        

            
            book1.Isbn = Convert.ToInt32(txtInput.Text.Trim());
            book1.AuthorId = Convert.ToInt32(cmbAuthorId.SelectedItem);
            book1.YearPublished = Convert.ToInt32(txtYearPub.Text.Trim());

            book1.UpdateBookAuthor(book1);
            MessageBox.Show("Record has been updated successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtYearPub.Clear();
            cmbIsbn.SelectedIndex = 0;
            cmbAuthorId.SelectedIndex = 0;
            txtInput.Clear();
        }
    }
}
