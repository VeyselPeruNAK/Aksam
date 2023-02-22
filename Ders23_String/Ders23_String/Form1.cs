using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders23_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string testString1 = textBox1.Text;
            string testString2 = textBox2.Text;
            int result = string.Compare(textBox1.Text, textBox2.Text, true);
            label1.Text = "";

            if (result == 0)
            {
                label1.Text += "Two strings are equal";
            }
            else if (result == 1)
            {
                label1.Text += "Test String1 is greater than Test String2";
            }
            else if (result == -1)
            {
                label1.Text += "Test String1 is less than Test String2";
            }
        }

        private void Karsilastir(object sender, EventArgs e)
        {
            string testString1 = textBox1.Text;
            string testString2 = textBox2.Text;
            int result = string.Compare(textBox1.Text, textBox2.Text, true);
            label1.Text = "";

            if (result == 0)
            {
                label1.Text += "Two strings are equal";
            }
            else if (result == 1)
            {
                label1.Text += "Test String1 is greater than Test String2";
            }
            else if (result == -1)
            {
                label1.Text += "Test String1 is less than Test String2";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
