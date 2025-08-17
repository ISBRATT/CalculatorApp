using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string first = string.Empty;
        string second = string.Empty;
        char function;
        double result = 0.0;
        string userInput = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = "";
            if(userInput == string.Empty)
            {
                userInput = "0.";
            }
            else
            {
                userInput += ".";
            }
            ResultsBox.Text += userInput;
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

        private void Num_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null) 
            {
                SetNumberValue(button.Text);
            }
        }

        private void SetNumberValue(string number)
        {
            ResultsBox.Text = "";
            userInput += number;
            ResultsBox.Text += userInput;
        }
    }
}
