using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // System.Data.SqlClient Nuget Yükle 4.6.1 versiyonunu


namespace UserPassword
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
            string sorgu = "SELECT * FROM tblUser where usr=@user AND pwd=@pass";
            //string sorgu = "SELECT * FROM tblUser";
            con = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["usr"], dr["name"]);
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblUser where usr=@user AND pwd=@pass";
            //con = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");

            con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=dbLogin;User Id=sa;Password=1234;");


            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz!");
            }




            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
