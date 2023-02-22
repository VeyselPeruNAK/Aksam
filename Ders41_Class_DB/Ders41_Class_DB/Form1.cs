using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ders41_Class_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerProvider provider = new CustomerProvider();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = provider.customers;
            cmbCountry.DataSource = provider.FillCombobox();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = provider.FilterCustomer(cmbCountry.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            cmbCountry.SelectedIndex = -1;
            dgvCustomers.DataSource = provider.customers;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = provider.customers;
            cmbCountry.DataSource = provider.FillCombobox();
        }
    }
}
