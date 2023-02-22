using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders28_Calculator
{
    public partial class Form1 : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operandPerformed)
                txtResult.Clear();

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOperand;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            operand = newOperand;

        }

        private void bCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            operandPerformed = true;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!operandPerformed && !txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            else if (operandPerformed)
            {
                txtResult.Text = "0";
            }

            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }

            operandPerformed = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

