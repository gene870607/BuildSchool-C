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
        public decimal First { get; set; }
        public decimal Second { get; set; }
        public decimal Total { get; set; }

        public object Judge { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            First = decimal.Parse(textBox1.Text);
            First = decimal.Parse(textBox1.Text);
            else if (textBox1.Text != string.Empty)
            {
                textBox1.Clear();
                Second = decimal.Parse(textBox1.Text);
                Total = First.Add(Second);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void Sum()
        {
            if()
            Total = First.Add(Second);
            textBox1.Text = Total.ToString();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            
        }
    }
    
    
}
