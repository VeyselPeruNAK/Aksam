using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders27_PassForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string deger1, int deger2)
        {
            InitializeComponent();
            textBox1.Text = deger1 + "-" + deger2.ToString();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
