using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double x, y;
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x + y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x - y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x * y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x / y); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            double resultado = Math.Sqrt(x);
            txtresultado.Text = string.Format("{0:f2}", resultado);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            double resultado = Math.Pow(x, y);
            txtresultado.Text = string.Format("{0:f2}", resultado);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresultado.Text = "";
        }
    }
}
