using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string firstString = "";
        string secondString = "";
        char function;
        double result = 0.0;
        string UserInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "0";
            display.Text += UserInput;

        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "1";
            display.Text += UserInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "2";
            display.Text += UserInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "3";
            display.Text += UserInput;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "4";
            display.Text += UserInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "5";
            display.Text += UserInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "6";
            display.Text += UserInput;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "7";
            display.Text += UserInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "8";
            display.Text += UserInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += "9";
            display.Text += UserInput;
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
            UserInput += ".";
            display.Text += UserInput;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstString = "";
            secondString = "";
            result = 0.0;
            UserInput = "";
            display.Text = "0";
        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            firstString = UserInput;
            UserInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            firstString = UserInput;
            UserInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            firstString = UserInput;
            UserInput = "";
        }

        private void divideButton_click(object sender, EventArgs e)
        {
            function = '/';
            firstString = UserInput;
            UserInput = "";
        }
        private void equalsButton_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;

            if (firstString == "")
            {
                display.Text = UserInput;
                return;
            }
            firstNum = Convert.ToDouble(firstString);
            secondNum = Convert.ToDouble(UserInput);
            try
            {
                if (function == '+')
                {
                    result = firstNum + secondNum;
                    string final = Convert.ToString(result);
                    display.Text = final;
                }
                if (function == '-')
                {
                    result = firstNum - secondNum;
                    string final = Convert.ToString(result);
                    display.Text = final;
                }
                if (function == '*')
                {
                    result = firstNum * secondNum;
                    string final = Convert.ToString(result);
                    display.Text = final;
                }
                if (function == '/')
                {
                    result = firstNum / secondNum;
                    string final = Convert.ToString(result);
                    display.Text = final;
                }
                UserInput = display.Text;
            }
            catch
            {
                display.Text = "Err";

            }
        }

        
    }
}
