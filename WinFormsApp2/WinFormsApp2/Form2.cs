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

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHG6T1S;Initial Catalog=kantinAmikom;Integrated Security=True");
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        private void Form2_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
            bindingData();
        }

        private void resetdata()
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtharga.Text = "";

        }

        private void bindingData()
        {
            dt.Clear();

            txtid.DataBindings.Clear();
            txtnama.DataBindings.Clear();
            txtharga.DataBindings.Clear();

            SqlDataAdapter da = new SqlDataAdapter("Select * from menu", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            da.Fill(dt);

            bs.DataSource = dt;
            dgvmenu.DataSource = bs;


            txtid.DataBindings.Add("Text",bs,"idMenu");
            txtnama.DataBindings.Add("Text", bs, "namaMenu");
            txtharga.DataBindings.Add("Text", bs, "harga");
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from menu";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "menu");
            dgvmenu.DataSource = ds;
            dgvmenu.DataMember = "menu";

            dgvmenu.ReadOnly = true;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            bs.Filter = "namaMenu like '%" + txtfilter.Text + "%'";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Isi id menu yang akan dihapus!", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from menu where idMenu ='" + txtid.Text + "'";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            resetdata();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" | txtnama.Text == "" | txtharga.Text == "")
            {
                MessageBox.Show("Semua data harus terisi!", "Peringatan");
                goto berhenti;
            }
            int num;
            // membuat variabel isNum kemudian isi dengan num itu sendiri
            bool isNum = int.TryParse(txtharga.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }


            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into menu values ('" + txtid.Text + "','" + txtnama.Text
                + "','" + int.Parse(txtharga.Text) + "')";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            resetdata();




        berhenti:
            ;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" | txtnama.Text == "" | txtharga.Text == "")
            {
                MessageBox.Show("Semua data harus terisi!", "Peringatan");
                goto berhenti;
            }
            int num;
            // membuat variabel isNum kemudian isi dengan num itu sendiri
            bool isNum = int.TryParse(txtharga.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update customer set namaMenu ='" + txtnama.Text + "', harga ='" + int.Parse(txtharga.Text)
                + "' where idMenu ='" + txtid.Text + "'";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            resetdata();




        berhenti:
            ;
        }
    }
}
