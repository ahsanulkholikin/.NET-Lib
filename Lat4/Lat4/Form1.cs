using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lat4
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
            // Kendaraan mobilPertamaku;
            // mobilPertamaku = new Kendaraan();

            // Produksi yearProduct = new Produksi();
            // yearProduct.tahunProduksi = 2005;

            // mobilPertamaku.Platnomor = "R 41 SA";
            // mobilPertamaku.Model = "Totoya Fortuner";
            // mobilPertamaku.SpeedMax = 200;
            // mobilPertamaku.Manufaktur = "Totoya";
            // mobilPertamaku.keteranganMobil = yearProduct;

            // txtplat.Text = mobilPertamaku.Platnomor;
            // txtmodel.Text = mobilPertamaku.Model;
            // txtspeedmax.Text = mobilPertamaku.SpeedMax.ToString();
            // txtmanufaktur.Text = mobilPertamaku.Manufaktur;
            // txttahun.Text = mobilPertamaku.keteranganMobil.tahunProduksi.ToString();

            Kendaraan mobilPertamaku = new Kendaraan();
            Produksi YearProduct = new Produksi();

            mobilPertamaku.keteranganMobil = YearProduct;

            mobilPertamaku.Platnomor = txtplat.Text;
            mobilPertamaku.Model = txtmodel.Text;
            mobilPertamaku.Manufaktur = txtmanufaktur.Text;
            mobilPertamaku.SpeedMax = int.Parse(txtspeedmax.Text);
            mobilPertamaku.keteranganMobil.tahunProduksi = int.Parse(txttahun.Text);

            MessageBox.Show("Mobilku : " + mobilPertamaku.Model +
                            "\nBuatan : " + mobilPertamaku.Manufaktur +
                            "\nDiproduksi Tahun : " + mobilPertamaku.keteranganMobil.tahunProduksi.ToString() +
                            "\nMemiliki Kecepatan Maksimal : " + mobilPertamaku.SpeedMax.ToString() +
                            "\ndan Memiliki Plat Nomor : " + mobilPertamaku.Platnomor);
        }
    }
}
