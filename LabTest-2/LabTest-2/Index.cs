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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void SaveCustomerAccountInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            CustomerAndAccountInfo customerAndAccountInfo = new CustomerAndAccountInfo();
            customerAndAccountInfo.Show();
        }

        private void TransactionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void SearchCustomerAccountInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            SearchCustomerAndAccountInfo searchCustomerAndAccountInfo = new SearchCustomerAndAccountInfo();
            searchCustomerAndAccountInfo.Show();
        }
    }
}
