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

namespace Prak9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHG6T1S;Initial Catalog=kantinAmikom;Integrated Security=True");

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from menu";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "menu");
            dgvmenu.DataSource = ds;
            dgvmenu.DataMember = "menu";
            dgvmenu.ReadOnly = true;
        }

        private void resetdata()
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtharga.Text = "";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ADDMENU";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idMenu = new SqlParameter("@id",SqlDbType.VarChar);
            SqlParameter namaMenu = new SqlParameter("@nama",SqlDbType.VarChar);
            SqlParameter harga = new SqlParameter("@harga",SqlDbType.VarChar);


            idMenu.Value = txtid.Text;
            namaMenu.Value = txtnama.Text;
            harga.Value = txtharga.Text;


            cmd.Parameters.Add(idMenu);
            cmd.Parameters.Add(namaMenu);
            cmd.Parameters.Add(harga);

            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELMENU";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idMenu = new SqlParameter("@id", SqlDbType.VarChar);


            idMenu.Value = txtid.Text;


            cmd.Parameters.Add(idMenu);

            cmd.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();
        }
    }
}
