using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ders41_Class_DB
{
    class CustomerProvider
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1QCDA4D\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        public List<Customer> customers { get; set; }

        public CustomerProvider()
        {
            customers = new List<Customer>();
            GetCustomers();
        }

        private void GetCustomers()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = dr[0].ToString();
                customer.CompanyName = dr[1].ToString();
                customer.ContactName = dr[2].ToString();
                customer.ContactTitle = dr[3].ToString();
                customer.Address = dr[4].ToString();
                customer.City = dr[5].ToString();
                customer.Region = dr[6].ToString();
                customer.PostalCode = dr[7].ToString();
                customer.Country = dr[8].ToString();
                customer.Phone = dr[9].ToString();
                customer.Fax = dr[10].ToString();

                customers.Add(customer);
            }
            dr.Close();
            con.Close();

        }

        public List<string> FillCombobox()
        {
            return customers.Select(x => x.Country).Distinct().ToList();
        }

        public List<Customer> FilterCustomer(string country)
        {
            return customers.Where(x => x.Country == country).ToList();
        }

    }
}
