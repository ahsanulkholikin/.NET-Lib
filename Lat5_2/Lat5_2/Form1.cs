using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persegi square = new Persegi(int.Parse(textBox1.Text));
            Kubus cube = new Kubus(int.Parse(textBox1.Text));

            MessageBox.Show("Luas Persegi = " + square.luas() +
                "\nLuas Permukaan Kubus = " + cube.luas(), "HASIL");
        }
    }
}
