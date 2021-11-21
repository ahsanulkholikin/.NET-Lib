using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void add(int a, out int sum)
        {
            sum = 10 + a;
        }
        void add1(int a, out int sum)
        {
            sum = 20 + a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c;
            int s = 0;

            c = int.Parse(txtBil.Text);

            Form1 k = new Form1();
            k.add1(c, out s);
            //add1(c, out s);

            txtNonStat.Text = s.ToString();

            add(c, out s);
            txtStat.Text = s.ToString();
        }
    }
}
