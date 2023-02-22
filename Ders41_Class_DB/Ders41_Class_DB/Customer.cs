using System;
using System.Collections.Generic;
using System.Text;

namespace Ders41_Class_DB
{
    internal class Customer
    {
        string customerId;
        string companyName;
        string contactName;
        string contactTitle;
        string address;
        string city;
        string region;
        string postalCode;
        string country;
        string phone;
        string fax;

        public string CustomerId { get => customerId; set => customerId = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactTitle { get => contactTitle; set => contactTitle = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Region { get => region; set => region = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }
    }
}
