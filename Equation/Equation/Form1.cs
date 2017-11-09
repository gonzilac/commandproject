using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double[] result = Calculate(a, b, c);
            label4.Text = "X1= " + result[0].ToString() + " X2= " + result[1].ToString();
            
        }
        private double[] Calculate(double a,double b,double c)
        {
            double[] result = new double[2];
            double d = Math.Pow(b, 2.0) - 4.0 * a * c;
            result[0] = -1.0*b + Math.Sqrt(d) / (2.0 * a);
            result[1] = (-1.0*b - Math.Sqrt(d)) / (2.0 * a);
            return result;
        }
    }
}
