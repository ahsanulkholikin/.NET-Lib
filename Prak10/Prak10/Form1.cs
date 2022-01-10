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

namespace Prak10
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
            txtuser.Text = "";
            txtpwd.Text = "";
        }
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from admin";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "admin");
            dgvuser.DataSource = ds;
            dgvuser.DataMember = "admin";
            dgvuser.ReadOnly = true;

        }

        private string CaesarCipher(string value,int shift)
        {
            string[] joincipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');

            try
            {
                for(int x = 0; x < wordArray.Length; x++)
                {
                    //konversi string ke char dalam array
                    char[] buffer = wordArray[x].ToCharArray();

                    for(int i = 0; i < buffer.Length; i++)
                    {
                        //Pengambulan char berdasarkan index array
                        // kemudian dikonversi ke bentuk char
                        char letter = buffer[1];
                        // penjumahan nilai dengan shift
                        letter = (char)(letter + shift);

                        // subs 26 on overflow
                        //add 26 on underflow
                        if(letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }
                        //store
                        buffer[i] = letter;
                    }

                    string HasilKonversi = new string(buffer);
                    joincipher[x] = HasilKonversi;
                }
                joinText = string.Join(" ", joincipher);
                return joinText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "" | txtpwd.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            string tekscipher = null;
            tekscipher = CaesarCipher(txtpwd.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into admin values ('"+txtuser.Text+"','"+ tekscipher + "')";

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();


        berhenti:
            ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }


        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Isi user id yang akan dihapus!");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from admin where userid='"+txtuser.Text+"'";

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" | txtpwd.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            string tekscipher = null;
            tekscipher = CaesarCipher(txtpwd.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update admin set password = '"+tekscipher+"' where userid='"+ txtuser.Text +"'";

            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();


        berhenti:
            ;
        }
    }
}
