using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSeznama
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtvnos.Text);
            txtkonzola.Text = "Dodan k seznamu nov element " + txtvnos.Text;
            txtvnos.Text = "";
            txtvnos.Focus();
        }

        private void btnizpis_Click(object sender, EventArgs e)
        {
            //txtkonzola.Text = "Elementi seznama:"+Environment.NewLine;
            //for(int k = 0; k < a.Count; k++)
            //{
            //    txtkonzola.Text += a[k] + Environment.NewLine;
            //}
            txtkonzola.Text = "Elementi seznama:" + Environment.NewLine;
            foreach (string x in a)
            {
                txtkonzola.Text += x + Environment.NewLine;
            }
        }
    }
}
