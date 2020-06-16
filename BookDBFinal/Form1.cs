﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDBFinal
{
    //TODO: Transfer Add Customer, Add Book and Add Regististrations
    //To seperate forms.
    public partial class BookDBFrm : Form
    {
        private List<Customer> allCustomers;
        
        public BookDBFrm()
        {
            InitializeComponent();
        }

        private void cbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            Registration regBook = new Registration();
            //implementation of string splitting.
            String[] custInput = cbCustomerDetails.Text.Split(' ');
            regBook.CustomerID = Convert.ToInt16(custInput[0]);
            regBook.ISBN = cbISBN.Text;
            regBook.RegDate = dtPickerBookDate.Value;
            BookRegistrationDB.AddReg(regBook);
            ClearFrm();
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtPickerBookDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookFrm bookFrm = new AddBookFrm();
            bookFrm.ShowDialog();

            
            

            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerFrm customer = new AddCustomerFrm();
            customer.ShowDialog();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

            //Load all customers

            allCustomers = CustomerDB.GetAllCustomers();

            PopulateCustomerList(allCustomers);

            //Load all Registrations

            List<Registration> allRegistrations = BookRegistrationDB.RegisterBook();

            PopulateRegList(allRegistrations);
        }

        private void PopulateCustomerList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                //cbFirstName.Items.Add(customer.FirstName);
                //cbLastName.Items.Add(customer.LastName);

                cbCustomerDetails.Items.Add(Convert.ToString(customer.CustomerId) + " " + customer.FirstName + " " + customer.LastName);
            }
        }

        private void PopulateRegList(List<Registration> registrations)
        {
            foreach (Registration registration in registrations)
            {
                cbISBN.Items.Add(registration.ISBN);

            }
        }
        public void ClearFrm()
        {
            cbCustomerDetails.Text = "";
        }

        private void btnViewCustomerList_Click(object sender, EventArgs e)
        {
            
        }
    }
}