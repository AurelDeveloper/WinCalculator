using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMarlon
{
    public partial class calculatorView : Form
    {
        public calculatorView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string input = txtDisplay.Text;
            char[] operators = { '+', '-', '*', '/' };
            string[] values = input.Split(operators, StringSplitOptions.RemoveEmptyEntries);
            char[] ops = input.Where(c => operators.Contains(c)).ToArray();

            if (values.Length == 2 && ops.Length == 1)
            {
                double num1 = Convert.ToDouble(values[0]);
                double num2 = Convert.ToDouble(values[1]);
                char op = ops[0];
                double result = 0;

                switch (op)
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
                        result = num1 / num2;
                        break;
                    default:
                        txtDisplay.Text = "Error";
                        break;
                }

                if (result != 0)
                {
                    txtDisplay.Text = result.ToString();
                }
            }

            else
            {
                txtDisplay.Text = "Error";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private string GetButtonText(object sender)
        {
            Button button = (Button)sender;

            string text = button.Text;

            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void test_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnLeftClamp_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnRightClamp_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
        }

        private void btnSquares_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);

            if (txtDisplay.Text.Contains("<"))
            {
                txtDisplay.Text = txtDisplay.Text.Replace("<", "");
                double zahl = int.Parse(txtDisplay.Text);
                double squares = zahl * zahl;

                txtDisplay.Text = $"{squares}";
            }
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + GetButtonText(sender);
            if (txtDisplay.Text.Contains("√"))
            {
                txtDisplay.Text = txtDisplay.Text.Replace("√", "");
                if (double.TryParse(txtDisplay.Text, out double zahl))
                {
                    double squareRoot = Math.Sqrt(zahl);
                    txtDisplay.Text = $"{squareRoot:F2}";
                }
            }
        }
    }
}

