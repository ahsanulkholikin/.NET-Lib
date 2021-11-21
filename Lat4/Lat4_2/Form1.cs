using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat4_2
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
            Mahasiswa mhs = new Mahasiswa();
            mhs.nim = txtnim.Text;
            mhs.nama = txtnama.Text;
            mhs.nilaiInggris = int.Parse(txtinggris.Text);
            mhs.nilaiManajemen = int.Parse(txtmanajemen.Text);
            mhs.nilaiBahasa = int.Parse(txtbahasa.Text);

            mhs.hitungTotalNilai();
            mhs.hitungRatarata();

            MessageBox.Show("Mahasiswa dengan NIM : " + mhs.nim +
                "\n dan Nama : " + mhs.nama +
                "\n Mendapat Total Nilai : " + mhs.totalNilai.ToString() +
                "\n dan Nilai Rata - rata : " + mhs.rataRata.ToString());
        }
    }
}
