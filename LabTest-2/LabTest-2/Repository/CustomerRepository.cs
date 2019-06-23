using LabTest_2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest_2.Repository
{
    public class CustomerRepository
    {

        string connectionString = @"Server=PC-301-22\SQLEXPRESS; Database=LabTest_2; Integrated Security=True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;

        public int EntryCustomer(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Customers (Name, Email, OpeningDate, AccountNumber) VALUES ('" + customer.Name + "', '" + customer.Email + "', '" + customer.OpeningDate + "', " + customer.AccountNumber + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable ShowInfo()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Customers";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;


            sqlConnection.Close();
            return dataTable;
        }

        public DataTable SearchCustomer(Customer customer)
        {
            commandString = @"SELECT * FROM Customers WHERE AccountNumber LIKE'%" + customer.AccountNumber + "%'";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //    displayDataGridView.DataSource = dataTable;


            sqlConnection.Close();
            return dataTable;
        }

        public int Deposit(Customer customer)
        {
            //commandString = @"SELECT Balance FROM Customers WHERE AccountNumber = " + customer.AccountNumber + "";
            //sqlCommand = new SqlCommand(commandString, sqlConnection);

            //sqlConnection.Open();

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);

            //customer.Balance =  

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"UPDATE Customers SET Balance = '" + customer.Balance + "' WHERE AccountNumber = " + customer.AccountNumber + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int Withdraw(Customer customer)
        {
            //commandString = @"SELECT Balance FROM Customers WHERE AccountNumber = " + customer.AccountNumber + "";
            //sqlCommand = new SqlCommand(commandString, sqlConnection);

            //sqlConnection.Open();

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);

            //customer.Balance = 

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"UPDATE Customers SET Balance = '" + customer.Balance + "' WHERE AccountNumber = " + customer.AccountNumber + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }
    }
}
