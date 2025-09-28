using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo9ii
{
    public partial class Form1 : Form
    {
        string input = string.Empty; 
        string operand1 = string.Empty; 
        string operand2 = string.Empty; 
        char operation; 
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(b.Text);
            input = string.Empty;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(b.Text);
            input = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            input = string.Empty; 
            operand1 = string.Empty; 
            operand2 = string.Empty; 
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = input; 
            double num1, num2; 
            double.TryParse(operand1, out num1); 
            double.TryParse(operand2, out num2); 
            switch (operation) 
            { 
                case '+': 
                    result = num1 + num2; 
                    break; 
                case '-': 
                    result = num1 - num2; 
                    break; 
                case '*': 
                    result = num1 * num2; 
                    break; 
                case '/': 
                    if (num2 == 0) 
                    {
                        MessageBox.Show("Cannot divide by zero!"); 
                        return; 
                    } 
                    result = num1 / num2;
                    break; 
            }
            txtDisplay.Text = result.ToString(); input = result.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;

        }

        private void btn_Click(object sender, EventArgs e) 
        { 
            Button b = (Button)sender; 
            input += b.Text; 
            txtDisplay.Text = input; 
        }
        private void operator_Click(object sender, EventArgs e)
        { 
            Button b = (Button)sender; 
            operand1 = input; 
            operation = Convert.ToChar(b.Text); 
            input = string.Empty; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            input += b.Text;
            txtDisplay.Text = input;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(b.Text);
            input = string.Empty;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(b.Text);
            input = string.Empty;
        }
    }
}
