using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ResultsBox.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "8";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += "0";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Text += ".";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            function = '=';
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            function = 'c';
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void Num9_Click(object sender, EventArgs e)
        {

        }
    }
}
