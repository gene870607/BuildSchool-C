using MathLibrary;
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
        public decimal a;
        public decimal b;
        public decimal c;
        public string z;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            z = "+";
            Sum();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            z = "-";
            Sum();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (z == "+")
            {
                Sum();
                textBox1.Text = c.ToString();

            }
            else if (z == "-")
            {
                Sum();
                textBox1.Text = c.ToString();

            }
            else if (z == "*")
            {
                Sum();
                textBox1.Text = c.ToString();

            }
            else if (z == "/")
            {
                Sum();
                textBox1.Text = c.ToString();

            }
        }
        private decimal Sum()
        {
            if (a == 0 )
            {
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
            }
            else if (a != 0 && z == "+")
            {
                b = int.Parse(textBox1.Text);
                c = a.Add(b);
            }
            else if(a != 0 && z == "-")
            {
                b = int.Parse(textBox1.Text);
                c = a.Minus(b);
            }
            else if (a != 0 && z == "*")
            {
                b = int.Parse(textBox1.Text);
                c = a.Multiple(b);
            }
            else if (a != 0 && z == "/")
            {
                b = int.Parse(textBox1.Text);
                c = a.GetQuotient(b);
            }
            return c;
        }

        private void Btn_multiply_Click(object sender, EventArgs e)
        {
            z = "*";
            Sum();
        }

        private void Btn_divided_Click(object sender, EventArgs e)
        {
            z = "/";
            Sum();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            z = string.Empty;
            a = 0;
            b = 0;
            c = 0;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = textBox1.Text;
            s += b.Text;
            textBox1.Text = s;
        }
    }
    
    
}
