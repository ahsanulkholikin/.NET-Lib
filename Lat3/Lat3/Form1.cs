using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string luaspersegi()
        {
            int p, l, luas;
            p = int.Parse(txtPanjang.Text);
            l = int.Parse(txtLebar.Text);
            luas = p * l;
            return luas.ToString();
        }
        private void hitungLuas()
        {
            int p, l, luas;
            p = int.Parse(txtPanjang.Text);
            l = int.Parse(txtLebar.Text);
            luas = p * l;
            txtVoid.Text = luas.ToString();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            hitungLuas();
        }

        private void btnFungsi_Click(object sender, EventArgs e)
        {
            txtFungsi.Text = luaspersegi();
        }
    }
}
