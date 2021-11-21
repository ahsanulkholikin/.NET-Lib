using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int kali(int a, int b)
        {
            return a * b;
        }
        private void btnnilai_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtBil1.Text);
            b = int.Parse(txtBil2.Text);
            c = kali(a, b);
            txtNilai.Text = c.ToString();
        }

        void tambahLima(ref int a)
        {
            a += 5;
        }
        private void btnref_Click(object sender, EventArgs e)
        {
            int c;
            c = int.Parse(txtAngka.Text);
            tambahLima(ref c);
            txtRef.Text = c.ToString();
        }

        void bagidua(float a, out float b)
        {
            b = a / 2;
        }
        private void btnout_Click(object sender, EventArgs e)
        {
            float c;
            float hasil;

            c = float.Parse(txtAngkaOut.Text);
            bagidua(c, out hasil);
            txtOut.Text = hasil.ToString();
        }
    }
}
