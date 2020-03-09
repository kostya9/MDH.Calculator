using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDH.Calculator.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void num_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text;
            int num;
            bool success = Int32.TryParse(str, out num);

            if (success == false)
            {
                Console.WriteLine("Warning! Invalid number in ");
            }
            else if (num >= 0 && num <= 9)
            {
                textBox1.AppendText(str);
            }
        }
     
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            // TODO: math here
            textBox1.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void BtnOperator_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text;
            switch(str) 
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                case ".":
                    break;
                case "(":
                    textBox1.AppendText(str);
                    return;
                case ")":
                    if(textBox1.Text.Length != 0)
                        textBox1.AppendText(str);
                    return;
                default:
                    Console.WriteLine("Warning! Invalid operator in BtnOperator_Click()");
                    return;
            }

            string equation = textBox1.Text;
            int n = equation.Length;

            // Handle duplicate operators
            if(n != 0) 
            {
                if(equation[n-1] == '+' || equation[n - 1] == '-' || equation[n - 1] == '/' || equation[n - 1] == '*' || equation[n - 1] == '.') 
                {
                    textBox1.Text = equation.Remove(n - 1) + str;
                    return;
                }
            } 
            // Handle first operator
            else {
                if (str == "+" || str == "/" || str == "*" || str == ".") {
                    textBox1.Text = "0" + str;
                    return;
                }
            }
            textBox1.AppendText(str);
        }

        private void BtnRemove_Click(object sender, EventArgs e) {
            string equation = textBox1.Text;
            int n = equation.Length;

            if(n != 0) 
            {
                textBox1.Text = equation.Remove(n - 1);
            }
        }
    }
}
