namespace BookDBFinal
{
    partial class AddCustomerFrm
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
            this.btnDBAddCustomer = new System.Windows.Forms.Button();
            this.cbCustomerDetails = new System.Windows.Forms.ComboBox();
            this.cbBookTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDBAddCustomer
            // 
            this.btnDBAddCustomer.Location = new System.Drawing.Point(340, 326);
            this.btnDBAddCustomer.Name = "btnDBAddCustomer";
            this.btnDBAddCustomer.Size = new System.Drawing.Size(113, 71);
            this.btnDBAddCustomer.TabIndex = 0;
            this.btnDBAddCustomer.Text = "Add Customer To The Database";
            this.btnDBAddCustomer.UseVisualStyleBackColor = true;
            this.btnDBAddCustomer.Click += new System.EventHandler(this.btnDBAddCustomer_Click);
            // 
            // cbCustomerDetails
            // 
            this.cbCustomerDetails.FormattingEnabled = true;
            this.cbCustomerDetails.Location = new System.Drawing.Point(332, 148);
            this.cbCustomerDetails.Name = "cbCustomerDetails";
            this.cbCustomerDetails.Size = new System.Drawing.Size(121, 21);
            this.cbCustomerDetails.TabIndex = 1;
            // 
            // cbBookTitle
            // 
            this.cbBookTitle.FormattingEnabled = true;
            this.cbBookTitle.Location = new System.Drawing.Point(332, 215);
            this.cbBookTitle.Name = "cbBookTitle";
            this.cbBookTitle.Size = new System.Drawing.Size(121, 21);
            this.cbBookTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(298, 275);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date of Birth";
            // 
            // AddCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBookTitle);
            this.Controls.Add(this.cbCustomerDetails);
            this.Controls.Add(this.btnDBAddCustomer);
            this.Name = "AddCustomerFrm";
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDBAddCustomer;
        private System.Windows.Forms.ComboBox cbCustomerDetails;
        private System.Windows.Forms.ComboBox cbBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
    }
}