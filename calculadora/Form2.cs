using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertidor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(conversiones));
        }

        double respuesta = 0, temp = 0;
        int idConversor = 0;

        enum conversiones
        {
            Kelvin_Celsius,
            Celsius_Kelvin,
            Fahrenheit_Celsius,
            Fahrenheit_Kelvin,
            Kelvin_Fahrenheit,
            Celsius_Fahrenheit,
        };


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                temp = double.Parse(textBox1.Text);
                idConversor = Convert.ToInt32(comboBox1.SelectedIndex);

                switch (idConversor)
                {
                    case 0:
                        respuesta = (temp * 9.0 / 5.0) + 32;
                        break;
                    case 1:
                        respuesta = temp + 273;
                        break;
                    case 2:
                        respuesta = (temp - 32) * (5.0 / 9.0);
                        break;
                    case 3:
                        respuesta = (temp + 459.67) * 5.0 / 9.0;
                        break;
                    case 4:
                        respuesta = temp - 273;
                        break;
                    case 5:
                        respuesta = (9.0 / 5.0 * temp) - 459.67;
                        break;
                }
                label4.Visible = false;

                textBox2.Text = respuesta.ToString();
            }
            else
                label4.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
        
      
