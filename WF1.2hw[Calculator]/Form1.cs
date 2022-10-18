using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1._2hw_Calculator_
{
    public partial class Form1 : Form
    {
        private decimal d1;
        private char operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void One_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "1";
            else
                Result.Text += "1";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "2";
            else
                Result.Text += "2";
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "3";
            else
                Result.Text += "3";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "4";
            else
                Result.Text += "4";
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "5";
            else
                Result.Text += "5";
        }
        private void Six_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "6";
            else
                Result.Text += "6";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "7";
            else
                Result.Text += "7";
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "8";
            else
                Result.Text += "8";
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" && Result.Text != null)
                Result.Text = "9";
            else
                Result.Text += "9";
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            Result.Text += '0';
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            Result.Text += '.';
        }
        private void BackSpace_Click(object sender, EventArgs e)
        {
            if(Result.Text != string.Empty)
                Result.Text = Result.Text.Remove(Result.Text.Length - 1);
            else
                Result.Text = string.Empty;
        }
        private void C_Click(object sender, EventArgs e)
        {
            Result.Text = String.Empty;
        }
        private void Percent_Click(object sender, EventArgs e)
        {
            d1 = decimal.Parse(Result.Text);
            Result.Text = "0";
            operation = '%';
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            d1 = decimal.Parse(Result.Text);
            Result.Text = "0";
            operation = '+';
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            d1 = decimal.Parse(Result.Text);
            Result.Text = "0";
            operation = '-';
        }
        private void Mult_Click(object sender, EventArgs e)
        {
            d1 = decimal.Parse(Result.Text);
            Result.Text = "0";
            operation = '*';
        }
        private void Div_Click(object sender, EventArgs e)
        {
            d1 = decimal.Parse(Result.Text);
            Result.Text = "0";
            operation = '/';
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            decimal d2, result;
            d2 = decimal.Parse(Result.Text);
            switch(operation)
            {
                case '%':
                    result = d1 % d2;
                    Result.Text = Convert.ToString(result);
                    d1 = result;
                    break;
                case '+':
                    result = d1 + d2;
                    Result.Text = Convert.ToString(result);
                    d1 = result;
                    break;
                case '-':
                    result = d1 - d2;
                    Result.Text = Convert.ToString(result);
                    d1 = result;
                    break;
                case '*':
                    result = d1 * d2;
                    Result.Text = Convert.ToString(result);
                    d1 = result;
                    break;
                case '/':
                    if (d2 == 0)
                        Result.Text = "Cannot divide by zero. . .";
                    else
                    {
                        result = d1 % d2;
                        Result.Text = Convert.ToString(result);
                        d1 = result;
                    }
                    break;
            }
        }
    }
}
