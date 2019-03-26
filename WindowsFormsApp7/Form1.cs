using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resistor1 = double.Parse(textBox1.Text);
            double resistor2 = double.Parse(textBox2.Text);
            double resistor3 = double.Parse(textBox3.Text);
            double resistor4 = double.Parse(textBox4.Text);

            double totalresistance = resistor1 + resistor2 + resistor3 + resistor4;
            MessageBox.Show("total resistance =" + totalresistance.ToString("0.00") + "ohms");
        }
    }
}
