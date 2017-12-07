using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace EasePasswordDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        private void decrypt()
        {
            string password;
            string decrypted = "";
            password = textBox1.Text;

            for (int i = 0; i < password.Length; i++)
            {
                decrypted = decrypted + Strings.Chr(Strings.Asc(password.Substring(i, 1)) - (i + 1));
            }

            txtDecrypted.Text = decrypted;
        }

        private void PopulateGrid()
        {
            string serverName;
            string userName;
            string password;

            serverName = txtServerName.Text;
            userName = txtUserName.Text;
            password = txtPassword.Text;

            string constring = @"Server="+serverName+"; Database=AML_PROD;User="+userName+";Password="+password+";";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select userid, username, passwordx From euser", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {


                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
