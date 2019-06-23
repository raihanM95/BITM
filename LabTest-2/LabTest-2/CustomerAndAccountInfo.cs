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
    public partial class CustomerAndAccountInfo : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        private Customer customer;
        public CustomerAndAccountInfo()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (accountNumberTextBox.TextLength != 8)
            {
                checkLabel.Text = "Enter account No. 8 numeric digits only!";
                return;
            }

            customer.Name = customerNameTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.AccountNumber = Convert.ToInt32(accountNumberTextBox.Text);
            customer.OpeningDate = openingDateTextBox.Text;

            int isExecuted;
            isExecuted = _customerManager.EntryCustomer(customer);

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }
    }
}
