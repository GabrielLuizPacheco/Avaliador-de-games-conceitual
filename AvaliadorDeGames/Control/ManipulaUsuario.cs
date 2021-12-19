using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AvaliadorDeGames.Model;
using AvaliadorDeGames.View;
using System.Windows.Forms;

namespace AvaliadorDeGames.Control
{
    class ManipulaUsuario
    {
        public void cadastrarUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeUsuario", Usuario.Nome);
                cmd.Parameters.AddWithValue("@emailUsuario", Usuario.Email);
                cmd.Parameters.AddWithValue("@senhaUsuario", Usuario.Senha);
                cmd.Parameters.AddWithValue("@usuario", Usuario.Nickname);

                SqlParameter nv = cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void loginUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pLoginUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario", Usuario.Nickname);
            cmd.Parameters.AddWithValue("@senha", Usuario.Senha);
            cn.Open();

            int i = (int)cmd.ExecuteScalar();
            if (i > 0)
            {
                telaMenuPrincipal telaMenuPrincipal = new telaMenuPrincipal();
                telaMenuPrincipal.ShowDialog();


            }
            else
            {
                MessageBox.Show("Acesso Negado!");
            }


        }

        public void alterarDadosUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nome", Usuario.Nome);
            cmd.Parameters.AddWithValue("@Usuario", Usuario.Nickname);
            cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);
            cmd.Parameters.AddWithValue("@Email", Usuario.Email);
            cmd.Parameters.AddWithValue("@idUsuario", Usuario.IdUsuario);

            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Dados alterados com sucesso!!!");
        }

        public void dadosUsuario()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDadosUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@senha", Usuario.Senha);
            cmd.Parameters.AddWithValue("@usuario", Usuario.Nickname);
            cn.Open();

            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Usuario.Nome = dr["nome"].ToString();
                Usuario.Nickname = dr["usuario"].ToString();
                Usuario.Senha = dr["senha"].ToString();
                Usuario.Email = dr["email"].ToString();
                Usuario.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
            }


        }
    }
}
