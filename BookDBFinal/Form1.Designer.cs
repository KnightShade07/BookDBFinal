namespace BookDBFinal
{
    partial class BookDBFrm
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
            this.cbCustomerDetails = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbISBN = new System.Windows.Forms.ComboBox();
            this.dtPickerBookDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshRegList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCustomerDetails
            // 
            this.cbCustomerDetails.FormattingEnabled = true;
            this.cbCustomerDetails.Location = new System.Drawing.Point(200, 154);
            this.cbCustomerDetails.Name = "cbCustomerDetails";
            this.cbCustomerDetails.Size = new System.Drawing.Size(121, 21);
            this.cbCustomerDetails.TabIndex = 0;
            this.cbCustomerDetails.SelectedIndexChanged += new System.EventHandler(this.cbBooks_SelectedIndexChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(420, 142);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(117, 63);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(420, 254);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(117, 58);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Location = new System.Drawing.Point(214, 329);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(138, 69);
            this.btnRegisterBook.TabIndex = 4;
            this.btnRegisterBook.Text = "Register Book";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            this.btnRegisterBook.Click += new System.EventHandler(this.btnRegisterBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Details:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ISBN";
            // 
            // cbISBN
            // 
            this.cbISBN.FormattingEnabled = true;
            this.cbISBN.Location = new System.Drawing.Point(200, 207);
            this.cbISBN.Name = "cbISBN";
            this.cbISBN.Size = new System.Drawing.Size(121, 21);
            this.cbISBN.TabIndex = 15;
            // 
            // dtPickerBookDate
            // 
            this.dtPickerBookDate.Location = new System.Drawing.Point(185, 271);
            this.dtPickerBookDate.Name = "dtPickerBookDate";
            this.dtPickerBookDate.Size = new System.Drawing.Size(200, 20);
            this.dtPickerBookDate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Checkout Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "This is where you register a customer to the database!\r\nIf you want to navigate t" +
    "o the other pages, click the \"Add Customer\"\r\n or \"Add Book\" Buttons!";
            // 
            // btnRefreshRegList
            // 
            this.btnRefreshRegList.Location = new System.Drawing.Point(402, 329);
            this.btnRefreshRegList.Name = "btnRefreshRegList";
            this.btnRefreshRegList.Size = new System.Drawing.Size(135, 69);
            this.btnRefreshRegList.TabIndex = 22;
            this.btnRefreshRegList.Text = "Refreshes the Registration List";
            this.btnRefreshRegList.UseVisualStyleBackColor = true;
            this.btnRefreshRegList.Click += new System.EventHandler(this.btnRefreshRegList_Click);
            // 
            // BookDBFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.btnRefreshRegList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerBookDate);
            this.Controls.Add(this.cbISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cbCustomerDetails);
            this.Name = "BookDBFrm";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomerDetails;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRegisterBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbISBN;
        private System.Windows.Forms.DateTimePicker dtPickerBookDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefreshRegList;
    }
}

