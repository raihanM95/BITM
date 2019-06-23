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
    public partial class Transaction : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        private Customer customer;
        public Transaction()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            customer.AccountNumber = Convert.ToInt32(accountNumberTextBox.Text);
            customer.Balance = Convert.ToInt32(amountTextBox.Text);
            _customerManager.Deposit(customer);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            customer.AccountNumber = Convert.ToInt32(accountNumberTextBox.Text);
            customer.Balance = Convert.ToInt32(amountTextBox.Text);
            _customerManager.Withdraw(customer);
        }
    }
}
