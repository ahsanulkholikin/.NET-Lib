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

namespace Prak8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlConnection con = new sqlConnection(@"Data Source=DESKTOP-KHG6T1S;Initial Catalog=kantinAmikom;Integrated Security=True");

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
