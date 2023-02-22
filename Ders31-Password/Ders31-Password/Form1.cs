using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Dependencies/Packages altından SqlClient yazıp System.Data.SqlClient nuget yükle Veysel.
//Dependencies/Packages altından SqlClient yazıp System.Data.SqlClient nuget yükle Veysel.

namespace Ders31_Password
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * From tblUser";  //   where usr=@user AND pwd=@pass";
            con = new SqlConnection(@"server=DESKTOP-1QCDA4D\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            //con = new SqlConnection(@"Data Source=405-00;Initial Catalog=dbLogin;User ID=sa;Password=1234");
            //BU: con = new SqlConnection(@"Data Source=DESKTOP-1QCDA4D\SQLEXPRESS;Initial Catalog=dbLogin;User ID=sa;Password=1234");
            //con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbLogin;User ID=sa;Password=1234");
            cmd = new SqlCommand(sorgu, con);
            //cmd.Parameters.AddWithValue("@user", txtUser.Text);
            //cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr["usr"], dr["name"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From tblUser  where usr=@user AND pwd=@pass";
            con = new SqlConnection(@"server=DESKTOP-1QCDA4D\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            //BU: con = new SqlConnection(@"Data Source=DESKTOP-1QCDA4D\SQLEXPRESS;Initial Catalog=dbLogin;User ID=sa;Password=1234");
            //con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbLogin;User ID=sa;Password=1234");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
                MessageBox.Show("Tebrikler, başarılı bir şekilde giriş yaptınız.");
            else
                MessageBox.Show("Kullanıcı adı ve şifrenizi kontrol ediniz.");
        }
    }
}
