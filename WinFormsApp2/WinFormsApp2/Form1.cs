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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHG6T1S;Initial Catalog=kantinAmikom;Integrated Security=True");

        private void resetdata()
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtvoucer.Text = "";

        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";

            dgvcustomer.ReadOnly = true;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer where namaCustomer like '%"+txtcaridata.Text+"%'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";

            dgvcustomer.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" | txtnama.Text == ""| txtvoucer.Text=="")
            {
                MessageBox.Show("Semua data harus terisi!", "Peringatan");
                goto berhenti;
            }
            int num;
            // membuat variabel isNum kemudian isi dengan num itu sendiri
            bool isNum = int.TryParse(txtvoucer.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }


            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into customer values ('" +txtid.Text+ "','"+txtnama.Text
                +"','"+int.Parse(txtvoucer.Text)+"')";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            resetdata();




        berhenti:
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" | txtnama.Text == "" | txtvoucer.Text == "")
            {
                MessageBox.Show("Semua data harus terisi!", "Peringatan");
                goto berhenti;
            }
            int num;
            // membuat variabel isNum kemudian isi dengan num itu sendiri
            bool isNum = int.TryParse(txtvoucer.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update customer set namaCustomer ='" + txtnama.Text + "', nominalIsi ='" + int.Parse(txtvoucer.Text)
                + "' where idCustomer ='" + txtid.Text + "'";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            resetdata();




        berhenti:
            ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Isi id cutomer yang akan dihapus!", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from customer where idCustomer ='"+txtid.Text+"'";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            resetdata();

        berhenti:
            ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
