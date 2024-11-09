using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class txtLogin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public txtLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpassword.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where username='" + txtname.Text + "' AND password='" + txtpassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login efetuado com sucesso!");
                Form carros = new Form();
                carros.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }
    }
}


        
