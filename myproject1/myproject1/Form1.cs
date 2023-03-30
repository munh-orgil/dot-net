using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject1
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            errorLabel.Text = "";
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        double a, b, c, d;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                label8.Text = "A = ";
                label9.Text = "B = ";
                label10.Text = "";
                return;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label8.Text = "R = ";
                label9.Text = "";
                label10.Text = "";
                return;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label8.Text = "A = ";
                label9.Text = "B = ";
                label10.Text = "C = ";
                return;
            }
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double s = a * b;
                textBox4.Text = s.ToString();
                return;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                double r = double.Parse(textBox1.Text);
                double s = r * r * (3.1415);
                textBox4.Text = s.ToString();
                return;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                textBox4.Text = s.ToString();
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBoxA.Text);
            b = double.Parse(textBoxB.Text);
            c = double.Parse(textBoxC.Text);

            double mx = Math.Max(a, Math.Max(b, c));

            if((a + b + c - mx) < mx)
            {
                errorLabel2.Text = "Гурвалжин биш байна.";
            }
            d = (b * b - 4 * a * c);
            if(d < 0) {
                errorLabel.Text = "D < 0 байна.";
                return;
            }
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);

            textBoxX1.Text = x1.ToString();
            textBoxX2.Text = x2.ToString();
            errorLabel.Text = "Амжилттай.";
        }
    }
}
