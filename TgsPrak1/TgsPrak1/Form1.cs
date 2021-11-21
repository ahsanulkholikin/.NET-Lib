using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TgsPrak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            suhu.Focus();
            cbpar1.Items.Clear();
            cbpar1.Items.Add("Celcius");
            cbpar1.Items.Add("Fahreinheit");
            cbpar1.Items.Add("Reamur");
            tot.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            float x;


            // #Celcius

            // Celcius ->  reamur
            if ((cbpar1.Text == "Celcius") && (rbr.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x * 0.8;
            }
            // Celcius ->  celcius
            else if ((cbpar1.Text == "Celcius") && (rbc.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x;
            }
            // Celcius ->  Fahreinheit
            else if ((cbpar1.Text == "Celcius") && (rbf.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x * 1.8 + 32;
            }


            // Reamur

            // Reamur ->  celcius
            else if ((cbpar1.Text == "Reamur") && (rbc.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x * 5 / 4;
            }
            // Reamur ->  reamur
            else if ((cbpar1.Text == "Reamur") && (rbr.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x;
            }
            // Reamur ->  fahrenheit
            else if ((cbpar1.Text == "Reamur") && (rbf.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x * 9 / 4 + 32;
            }


            // Fahrenheit

            // Fahrenheit ->  reamur
            else if ((cbpar1.Text == "Fahreinheit") && (rbc.Checked == true)){
                x = float.Parse(suhu.Text);
                total = (x - 32) * 5 / 9;
            }
            // Fahrenheit ->  fahrenheit
            else if ((cbpar1.Text == "Fahreinheit") && (rbf.Checked == true)){
                x = float.Parse(suhu.Text);
                total = x;
            }
            // Fahrenheit ->  celcius
            else
            {
                x = float.Parse(suhu.Text);
                total = (x - 32) * 4 / 9;
            }

            tot.Text = total.ToString();
        }
    }
}
