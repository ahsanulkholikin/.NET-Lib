using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prak10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KHG6T1S;Initial Catalog=kantinAmikom;Integrated Security=True");
        private string CaesarCipher(string value, int shift)
        {
            string[] joincipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');

            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    //konversi string ke char dalam array
                    char[] buffer = wordArray[x].ToCharArray();

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        //Pengambulan char berdasarkan index array
                        // kemudian dikonversi ke bentuk char
                        char letter = buffer[1];
                        // penjumahan nilai dengan shift
                        letter = (char)(letter + shift);

                        // subs 26 on overflow
                        //add 26 on underflow
                        if (letter > 'z')
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
            if (txtuser.Text == "" | txtpwd.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }
            string tekscipher = null;
            tekscipher = CaesarCipher(txtpwd.Text, 17);

            con.Close();
            SqlCommand cmd = new SqlCommand("select * from admin where userid ='"+txtuser.Text+"' and password = '"+tekscipher+"'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Form7 frm_menu = new Form7();
                frm_menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User atau Password tidak valid", "Peringatan");
                txtuser.Text = "";
                txtpwd.Text = "";
                txtuser.Focus();
                rd.Close();
            }


            

        berhenti:;

        }

        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }
    }
}
