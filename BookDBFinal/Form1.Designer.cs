namespace BookDBFinal
{
    partial class Form1
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
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.cbBookDate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(214, 67);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(121, 21);
            this.cbBooks.TabIndex = 0;
            this.cbBooks.SelectedIndexChanged += new System.EventHandler(this.cbBooks_SelectedIndexChanged);
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(214, 129);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(121, 21);
            this.cbBook.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(400, 67);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(117, 63);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(400, 161);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(117, 58);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Location = new System.Drawing.Point(214, 244);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(138, 69);
            this.btnRegisterBook.TabIndex = 4;
            this.btnRegisterBook.Text = "Register Book";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            // 
            // cbBookDate
            // 
            this.cbBookDate.FormattingEnabled = true;
            this.cbBookDate.Location = new System.Drawing.Point(214, 198);
            this.cbBookDate.Name = "cbBookDate";
            this.cbBookDate.Size = new System.Drawing.Size(121, 21);
            this.cbBookDate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.cbBookDate);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.cbBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRegisterBook;
        private System.Windows.Forms.ComboBox cbBookDate;
    }
}

