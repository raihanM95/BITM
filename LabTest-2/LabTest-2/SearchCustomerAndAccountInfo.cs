using LabTest_2.BLL;
using LabTest_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest_2
{
    public partial class SearchCustomerAndAccountInfo : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        private Customer customer;

        public SearchCustomerAndAccountInfo()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                checkSearchLabel.Text = "Please enter a account number";
                return;
            }

            customer.AccountNumber = Convert.ToInt32(searchTextBox.Text);
            displayDataGridView.DataSource = _customerManager.SearchCustomer(customer);
        }

        private void SearchCustomerAndAccountInfo_Load(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _customerManager.ShowInfo();
        }
    }
}
