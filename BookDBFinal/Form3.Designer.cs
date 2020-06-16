namespace BookDBFinal
{
    partial class AddBookFrm
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
            this.cbBookTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbISBN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.btnDBAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBookTitle
            // 
            this.cbBookTitle.FormattingEnabled = true;
            this.cbBookTitle.Location = new System.Drawing.Point(330, 150);
            this.cbBookTitle.Name = "cbBookTitle";
            this.cbBookTitle.Size = new System.Drawing.Size(121, 21);
            this.cbBookTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISBN";
            // 
            // cbISBN
            // 
            this.cbISBN.FormattingEnabled = true;
            this.cbISBN.Location = new System.Drawing.Point(330, 204);
            this.cbISBN.Name = "cbISBN";
            this.cbISBN.Size = new System.Drawing.Size(121, 21);
            this.cbISBN.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price";
            // 
            // cbPrice
            // 
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(330, 252);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(121, 21);
            this.cbPrice.TabIndex = 16;
            // 
            // btnDBAddBook
            // 
            this.btnDBAddBook.Location = new System.Drawing.Point(330, 306);
            this.btnDBAddBook.Name = "btnDBAddBook";
            this.btnDBAddBook.Size = new System.Drawing.Size(121, 64);
            this.btnDBAddBook.TabIndex = 17;
            this.btnDBAddBook.Text = "Add Book To Database";
            this.btnDBAddBook.UseVisualStyleBackColor = true;
            this.btnDBAddBook.Click += new System.EventHandler(this.btnDBAddBook_Click);
            // 
            // AddBookFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDBAddBook);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBookTitle);
            this.Name = "AddBookFrm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.Button btnDBAddBook;
    }
}