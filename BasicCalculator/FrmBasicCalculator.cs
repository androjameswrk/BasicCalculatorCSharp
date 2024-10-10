using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BasicComputation basicComputation = new BasicComputation();

            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                textBox3.Text = basicComputation.GetSum(num1, num2).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox3.Text = basicComputation.GetDifference(num1, num2).ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox3.Text = basicComputation.GetProduct(num1, num2).ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox3.Text = basicComputation.GetQuotient(num1, num2).ToString();
            }
            else
            {
                MessageBox.Show("Invalid! Please try again!");
            }
        }
    }
}   
