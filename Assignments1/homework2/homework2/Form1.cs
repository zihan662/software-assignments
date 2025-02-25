using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToString();
            if (!string.IsNullOrEmpty(text))
            {
                x = double.Parse(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text.ToString();
            if (!string.IsNullOrEmpty(text))
            {
                y = double.Parse(textBox2.Text);
            }
        }
        private double Op(double x, double y, char op)
        {
            switch (op)
            {
                case '+':
                    return x + y;
                    break;
                case '-':
                    return x - y;
                    break;
                case '*':
                    return x * y;
                    break;
                case '/':
                    return x / y;
                    break;
                case '^':
                    return Math.Pow(x, y);
                    break;
                case '%':
                    return x % y;
                    break;
                default: return -1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double ans= Op(x, y, op);
            result = Math.Round(ans, 5);
            textBox3.Text = result.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { op = '+'; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { op = '-'; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) {  op = '*'; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) {  op = '/'; }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) { op = '^'; }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) { op = '%'; }
        }
    }
}
