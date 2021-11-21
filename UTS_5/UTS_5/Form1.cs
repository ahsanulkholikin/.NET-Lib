using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hsl.ReadOnly = true;
        }
        int perhitungan(int presensi, int tugas, int uts, int uas)
        {
            return (presensi + tugas + uts + uas) * 25 / 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int npresensi, ntugas, nuas, nuts, hasil;

            npresensi = int.Parse(np.Text);
            ntugas = int.Parse(nt.Text);
            nuts = int.Parse(nut.Text);
            nuas = int.Parse(nua.Text);

            hasil = perhitungan(npresensi, ntugas, nuts, nuas);

            hsl.Text = hasil.ToString();
        }
    }
}
