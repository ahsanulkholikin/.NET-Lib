using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lagu lagu = new Lagu();

            if (comboBoxLagu.SelectedItem == null)
            {
                MessageBox.Show("Silahkan pilih terlebih dahulu", "Error");
                return;
            }
            if (comboBoxLagu.SelectedIndex == 0)
            {
                lagu.satu();
            }
            if (comboBoxLagu.SelectedIndex == 1)
            {
                lagu.dua();
            }
            if (comboBoxLagu.SelectedIndex == 2)
            {
                lagu.tiga();
            }
            if (comboBoxLagu.SelectedIndex == 3)
            {
                lagu.empat();
            }
            if (comboBoxLagu.SelectedIndex == 4)
            {
                lagu.lima();
            }

            richTextBox1.Text = lagu.lirik;
            Clipboard.SetText(lagu.lirik);
        }
    }
}
