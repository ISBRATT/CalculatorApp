using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "1";
            ResultsBox.Text += userInput;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "2";
            ResultsBox.Text += userInput;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "3";
            ResultsBox.Text += userInput;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "4";
            ResultsBox.Text += userInput;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "5";
            ResultsBox.Text += userInput;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "6";
            ResultsBox.Text += userInput;
        }
        private void Num7_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "7";
            ResultsBox.Text += userInput;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "8";
            ResultsBox.Text += userInput;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "0";
            ResultsBox.Text += userInput;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += ".";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //Plus
            if(function == '+')
            {
                result = firstNum + secondNum;
                ResultsBox.Text = result.ToString();
            }
            //Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                ResultsBox.Text = result.ToString();
            }
            //Divide
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    ResultsBox.Text = "cannot divide by zero";
                }
                else
                {
                    result = firstNum / secondNum;
                    ResultsBox.Text = result.ToString();
                    return;
                }
                
            }
            //Muliply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                ResultsBox.Text = result.ToString();
            }


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            ResultsBox.Text = "0";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            userInput += "9";
            ResultsBox.Text += userInput;
        }
    }
}
