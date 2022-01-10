using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prak10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void frmCustomer_Click(object sender, EventArgs e)
        {
            FormCus fCus = new FormCus();
            fCus.Show();
        }

        private void frmMenu_Click(object sender, EventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
        }

        private void frmPengguna_Click(object sender, EventArgs e)
        {
            FormPengguna fPeng = new FormPengguna();
            fPeng.Show();
        }

        private void frmPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualan fPenj = new FormPenjualan();
            fPenj.Show();
        }

        private void frmKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan keluar?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
