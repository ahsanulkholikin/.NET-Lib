using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prak9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHG6T1S;Initial Catalog=kantinAmikom;Integrated Security=True");
        private string notrans
        {
            get{
                con.Open();
                string nomor = "TR-0001";
                SqlCommand cmd = new SqlCommand("SELECT MAX(RIGHT(idTransaksi,4)) from transaksi", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "TR-" + (int.Parse(rd[0].ToString()) + 1).ToString("0000");
                rd.Close();
                return nomor;

            }
        }

        private void isicombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select namaMenu from menu";

            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(ds1, "menu");
            cbomenu.DataSource = ds1.Tables["menu"];
            cbomenu.DisplayMember = "namaMenu";
        }

        private void resetdata()
        {
            con.Close();
            txtno.Text = notrans;
            txtidcus.Text = "";
            cbomenu.Text = "";
            txtharga.Text = "";
            txtidmenu.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtno.Text = notrans;
            isicombo();
            txttgl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtharga.Text == "")
            {
                MessageBox.Show("Harga harus diisi");
                goto berhenti;
            }


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into transaksi values('"+txtno.Text+"','"+txttgl.Text+"','"+txtidcus.Text+"','"+txtharga.Text+"')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "Insert into detailTransaksi values('" + txtno.Text + "','" + txtidmenu.Text + "')";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();


            resetdata();
            txtidcus.Focus();

        berhenti:;
        }

        private void cbomenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from menu where namaMenu='"+cbomenu.Text+"'",con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtidmenu.Text = rd[0].ToString();
                txtharga.Text = rd[2].ToString();
                rd.Close();
            }
        }
    }
}
