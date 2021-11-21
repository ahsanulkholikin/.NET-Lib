using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat4_3
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
            string buku, pensil, pulpen;
            int bukux, pensilx, pulpenx;

            Barang Barang = new Barang();

            buku = inputbuku.Text;
            pensil = inputpensil.Text;
            pulpen = inputpulpen.Text;

            if (int.TryParse(buku, out bukux) && int.TryParse(pensil, out pensilx) && int.TryParse(pulpen, out pulpenx))
            {
                MessageBox.Show("HASIL :\n" + Barang.Hitung(bukux, pensilx, pulpenx), "HASIL");
            }
            else
            {
                MessageBox.Show("HASIL :\n" + Barang.Hitung(buku, pensil, pulpen), "HASIL");
            }
        }
    }
}
