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

namespace Rent_a_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=rentcar;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        private void ExibirDados()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM carros", con);
                adapt.Fill(dt);
                dgvAgenda.DataSource = dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void lblLista_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            txtCategoria.Text = "";
            txtDisponivel.Text = "";
            txtMatricula.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtAno.Text != "" && txtCategoria.Text != "" && txtDisponivel.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO carros(matricula,marca,modelo,ano,categoria, disponivel) VALUES(@matricula,@marca,@modelo,@ano,@categoria,@disponivel)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@modelo", txtModelo.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@ano", txtAno.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text.ToLower());
                    cmd.Parameters.AddWithValue("@disponivel", txtDisponivel.Text.ToLower());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                   
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

     

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" && txtMarca.Text != "" && txtModelo.Text != "" && txtAno.Text != "" && txtCategoria.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE carros SET matricula=@matricula, marca=@marca, modelo=@modelo,ano=@ano,categoria=@categoria,disponivel=@disponivel WHERE id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@modelo", txtModelo.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@ano", txtAno.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text.ToLower());
                    cmd.Parameters.AddWithValue("@disponivel", txtDisponivel.Text.ToUpper());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                   
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "carros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE carros WHERE id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        ExibirDados();
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMatricula.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMarca.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtModelo.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAno.Text = dgvAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCategoria.Text = dgvAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDisponivel.Text = dgvAgenda.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }
    }
    

}
