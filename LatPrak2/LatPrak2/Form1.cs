using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatPrak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tun.ReadOnly = true;
            gj.Focus();
            janak.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tunjangan, x, y;
            tunjangan = 0;

            x = int.Parse(janak.Value.ToString());
            y = int.Parse(gj.Value.ToString());

            if (jk.SelectedIndex == 0)
            {
                // menikah
                if (mnk.Checked) { 
                    // jumlah anak
                    if(x < 3 & x > 0)
                    {
                        tunjangan = y * x * 20 / 100;
                    }
                    else
                    {
                        tunjangan = y * 3 * 20 / 100;
                    }
                }
                // tidak menikah
                else
                {
                    tunjangan = 0;
                }
            }
            // bukan laki-laki
            else
            {
                tunjangan = 0;
            }
            tun.Text = tunjangan.ToString();
        }
    }
}
