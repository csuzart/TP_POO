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

namespace Rent_a_Car
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = rentcar; Integrated Security = True; ");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpassword.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where username='" +  txtname.Text + "' AND password='"  + txtpassword.Text  + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login efetuado com sucesso!");
                Form1 carros = new Form1();
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


        

    

