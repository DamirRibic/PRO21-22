using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Računanje
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

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re = double.Parse(txtRe1.Text);
            prvo.Im = double.Parse(txtIm1.Text);

            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(txtRe1.Text);
            drugo.Im = double.Parse(txtIm1.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
            label9.Text = (prvo + drugo).ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re = double.Parse(txtRe1.Text);
            prvo.Im = double.Parse(txtIm1.Text);

            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(txtRe1.Text);
            drugo.Im = double.Parse(txtIm1.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
            label9.Text = (prvo - drugo).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re = double.Parse(txtRe1.Text);
            prvo.Im = double.Parse(txtIm1.Text);

            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(txtRe1.Text);
            drugo.Im = double.Parse(txtIm1.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
            label9.Text = (prvo * drugo).ToString();
        }
    }
}
