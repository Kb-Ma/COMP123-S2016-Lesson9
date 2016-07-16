﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson9
{
    public partial class Calculator : Form
    {
        public string ActiveOperator { get; set; }

        public string FirstOperand { get; set; }

        public string SecondOperand { get; set; }


        public Calculator()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            // create a reference to the sender object
            // and tell csharp that it is a button
            Button buttonClicked = (Button)sender;

            // check to see if ResultTextBox has a 0 in it
            if (String.Equals(ResultTextBox.Text, "0"))
            {
                ResultTextBox.Clear();
            }

            // read the string in the TextBox
            string currentResult = ResultTextBox.Text;

            // add the text of the button clicked to the currentResult
            currentResult += buttonClicked.Text;

            // update the ResultTextBox
            ResultTextBox.Text = currentResult;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            this.FirstOperand = null;
            this.SecondOperand = null;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button operatorClicked = (Button)sender;

            this.ActiveOperator = operatorClicked.Text;

            if (String.IsNullOrEmpty(this.FirstOperand))
            {
                this.FirstOperand = ResultTextBox.Text;
            }

            if (String.IsNullOrEmpty(this.SecondOperand))

            {
                this.SecondOperand = ResultTextBox.Text;
            }
            ResultTextBox.Clear();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            if (!String.IsNullOrEmpty(this.FirstOperand))
            {
                firstNumber = Convert.ToInt32(this.FirstOperand);
            }

            if (!String.IsNullOrEmpty(this.SecondOperand))
            {
                secondNumber = Convert.ToInt32(this.SecondOperand);
            }

            switch (ActiveOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            ResultTextBox.Text = result.ToString();
        }
    }
}
