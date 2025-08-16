using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index
{
    public partial class Calculator : Form
    {
        double a, b, c;
        string op, exp;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            exp += textBox1.Text;
            textBox1.Text = "";

            if (op == "+")
            {
                c = a + b;
            }
            else if (op == "-")
            {
                c = a - b;
            }
            else if (op == "*")
            {
                c = a * b;
            }
            else if (op == "/")
            {
                c = a / b;
            }
            else if (op == "%")
            {
                c = a % b;
            }
            textBox1.Text = exp;
            textBox2.Text = c.ToString();
            a = c;
            exp = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            exp += textBox1.Text;
            textBox1.Text = "";
            op = "+";
            exp += op;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            exp += textBox1.Text;
            textBox1.Text = "";
            op = "-";
            exp += op;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            exp += textBox1.Text;
            textBox1.Text = "";
            op = "/";
            exp += op;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            exp += textBox1.Text;
            textBox1.Text = "";
            op = "%";
            exp += op;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            exp += textBox1.Text;
            textBox1.Text = "";
            op = "*";
            exp += op;
        }
    }
}
