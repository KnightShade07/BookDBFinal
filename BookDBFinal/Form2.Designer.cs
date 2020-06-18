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
            this.cbPersonTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFirstName = new System.Windows.Forms.ComboBox();
            this.cbLastName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // cbPersonTitle
            // 
            this.cbPersonTitle.FormattingEnabled = true;
            this.cbPersonTitle.Location = new System.Drawing.Point(332, 215);
            this.cbPersonTitle.Name = "cbPersonTitle";
            this.cbPersonTitle.Size = new System.Drawing.Size(121, 21);
            this.cbPersonTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "First Name";
            // 
            // cbFirstName
            // 
            this.cbFirstName.FormattingEnabled = true;
            this.cbFirstName.Location = new System.Drawing.Point(332, 114);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(121, 21);
            this.cbFirstName.TabIndex = 20;
            // 
            // cbLastName
            // 
            this.cbLastName.FormattingEnabled = true;
            this.cbLastName.Location = new System.Drawing.Point(332, 173);
            this.cbLastName.Name = "cbLastName";
            this.cbLastName.Size = new System.Drawing.Size(121, 21);
            this.cbLastName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "NOTE: Title does not mean book title!\r\nIt means (Ms., or Mr, for example!)\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "This is where you can register a customer to the database!\r\n";
            // 
            // AddCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLastName);
            this.Controls.Add(this.cbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPersonTitle);
            this.Controls.Add(this.btnDBAddCustomer);
            this.Name = "AddCustomerFrm";
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDBAddCustomer;
        private System.Windows.Forms.ComboBox cbPersonTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFirstName;
        private System.Windows.Forms.ComboBox cbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}