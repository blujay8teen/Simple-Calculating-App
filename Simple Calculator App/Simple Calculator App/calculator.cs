using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_App
{
    public partial class Calculator : Form
    {
        private decimal firstValue = 0.0m;
        private decimal secondValue = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public Calculator()
        {
            InitializeComponent();
            txtBox.ReadOnly = true;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "0";
            }

            else
            {
                txtBox.Text += "0";
            }
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0") 
            {
                txtBox.Text = "1";
            }
            else 
            {
                txtBox.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text += "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text += "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text += "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text += "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text += "6";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text += "9";
            }
        }

        private void plusminusBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Contains("-"))
            {
                txtBox.Text = txtBox.Text.Trim('-');
            }
            else
            {
                txtBox.Text = "-" + txtBox.Text;
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "-";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "+";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = "*";
        }

        private void moduleBtn_Click(object sender, EventArgs e)
        {
            decimal tempValue = decimal.Parse(txtBox.Text);

            if (operators == "+" || operators == "-")
            {
                // For addition and subtraction, calculate percentage of the first value
                tempValue = firstValue * tempValue / 100;
            }
            else if (operators == "*" || operators == "/")
            {
                // For multiplication and division, convert percentage to decimal
                tempValue = tempValue / 100;
            }
            else
            {
                // If no operator is selected, simply convert to percentage
                tempValue = tempValue / 100;
            }

            txtBox.Text = tempValue.ToString();
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            secondValue = decimal.Parse(txtBox.Text);
            switch (operators)
            {
                case "-":
                    result = firstValue - secondValue;
                    txtBox.Text = result.ToString();
                    break;
                case "+":
                    result = firstValue + secondValue;
                    txtBox.Text = result.ToString();
                    break;
                case "/":
                    if (secondValue == 0.0m)
                    {
                        txtBox.Text = "ERROR";
                    }
                    else
                    {
                        result = firstValue / secondValue;
                        txtBox.Text = result.ToString();
                    }
                    break;
                case "*":
                    result = firstValue * secondValue;
                    txtBox.Text = result.ToString();
                    break;
                case "%":
                    result = firstValue * secondValue / 100;
                    txtBox.Text = result.ToString();
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstValue = 0.0m;
            secondValue = 0.0m;
            txtBox.Text = "0";
        }
    }
}
