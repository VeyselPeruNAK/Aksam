using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders27_PassForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string deger)
        {
            InitializeComponent();
            textBox1.Text = deger;
            label1.Text = deger;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
