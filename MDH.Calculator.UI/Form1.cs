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

        }
    }
}
