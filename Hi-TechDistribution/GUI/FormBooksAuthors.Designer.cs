namespace Hi_TechDistribution.GUI
{
    partial class FormBooksAuthors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbIsbn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListOrderedItems = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbBookAuthor = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYearPub = new System.Windows.Forms.TextBox();
            this.cmbAuthorId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBookAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(668, 450);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 23);
            this.btnBack.TabIndex = 83;
            this.btnBack.Text = "&Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbIsbn
            // 
            this.cmbIsbn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsbn.FormattingEnabled = true;
            this.cmbIsbn.Location = new System.Drawing.Point(32, 61);
            this.cmbIsbn.Name = "cmbIsbn";
            this.cmbIsbn.Size = new System.Drawing.Size(121, 23);
            this.cmbIsbn.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // btnListOrderedItems
            // 
            this.btnListOrderedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOrderedItems.Location = new System.Drawing.Point(93, 498);
            this.btnListOrderedItems.Name = "btnListOrderedItems";
            this.btnListOrderedItems.Size = new System.Drawing.Size(467, 53);
            this.btnListOrderedItems.TabIndex = 75;
            this.btnListOrderedItems.Text = "&List Orders/Update Orders";
            this.btnListOrderedItems.UseVisualStyleBackColor = true;
            this.btnListOrderedItems.Click += new System.EventHandler(this.BtnListOrderedItems_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(613, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 52);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gbBookAuthor
            // 
            this.gbBookAuthor.BackColor = System.Drawing.Color.Transparent;
            this.gbBookAuthor.Controls.Add(this.label10);
            this.gbBookAuthor.Controls.Add(this.txtYearPub);
            this.gbBookAuthor.Controls.Add(this.cmbIsbn);
            this.gbBookAuthor.Controls.Add(this.cmbAuthorId);
            this.gbBookAuthor.Controls.Add(this.label4);
            this.gbBookAuthor.Controls.Add(this.label3);
            this.gbBookAuthor.Controls.Add(this.label2);
            this.gbBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookAuthor.Location = new System.Drawing.Point(22, 52);
            this.gbBookAuthor.Name = "gbBookAuthor";
            this.gbBookAuthor.Size = new System.Drawing.Size(524, 124);
            this.gbBookAuthor.TabIndex = 71;
            this.gbBookAuthor.TabStop = false;
            this.gbBookAuthor.Text = "Book Author Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 41;
            // 
            // txtYearPub
            // 
            this.txtYearPub.Location = new System.Drawing.Point(380, 63);
            this.txtYearPub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYearPub.Name = "txtYearPub";
            this.txtYearPub.Size = new System.Drawing.Size(105, 21);
            this.txtYearPub.TabIndex = 20;
            // 
            // cmbAuthorId
            // 
            this.cmbAuthorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthorId.FormattingEnabled = true;
            this.cmbAuthorId.Location = new System.Drawing.Point(211, 61);
            this.cmbAuthorId.Name = "cmbAuthorId";
            this.cmbAuthorId.Size = new System.Drawing.Size(121, 23);
            this.cmbAuthorId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Published";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(613, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 53);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "D&elete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeight = 20;
            this.dataGridViewBooks.GridColor = System.Drawing.Color.White;
            this.dataGridViewBooks.Location = new System.Drawing.Point(44, 300);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.Size = new System.Drawing.Size(557, 154);
            this.dataGridViewBooks.TabIndex = 84;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(654, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 51);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Search by ISBN";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(249, 228);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(202, 20);
            this.txtInput.TabIndex = 79;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(334, 204);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 80;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(481, 225);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 23);
            this.buttonSearch.TabIndex = 81;
            this.buttonSearch.Text = "S&earch";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Update only after search for ISBN";
            // 
            // FormBooksAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hi_TechDistribution.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnListOrderedItems);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbBookAuthor);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBooksAuthors";
            this.Text = "BooksAuthors";
            this.Load += new System.EventHandler(this.BooksAuthors_Load);
            this.gbBookAuthor.ResumeLayout(false);
            this.gbBookAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListOrderedItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbBookAuthor;
        private System.Windows.Forms.ComboBox cmbAuthorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtYearPub;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}