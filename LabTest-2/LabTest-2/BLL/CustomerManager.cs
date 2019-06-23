using LabTest_2.Models;
using LabTest_2.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest_2.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public int EntryCustomer(Customer customer)
        {
            return _customerRepository.EntryCustomer(customer);
        }

        public DataTable ShowInfo()
        {
            return _customerRepository.ShowInfo();
        }

        public DataTable SearchCustomer(Customer customer)
        {
            return _customerRepository.SearchCustomer(customer);
        }

        public int Deposit(Customer customer)
        {
            return _customerRepository.Deposit(customer);
        }

        public int Withdraw(Customer customer)
        {
            return _customerRepository.Withdraw(customer);
        }
    }
}
