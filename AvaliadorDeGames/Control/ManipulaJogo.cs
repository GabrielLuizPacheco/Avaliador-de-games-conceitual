using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AvaliadorDeGames.Control;
using AvaliadorDeGames.Model;
using System.Windows.Forms;

namespace AvaliadorDeGames.Control
{
    class ManipulaJogo
    {
        public void cadastrarJogo()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarJogo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeJogo", Jogo.NomeJogo);
                cmd.Parameters.AddWithValue("@desenvJogo", Jogo.DesenvJogo);
                cmd.Parameters.AddWithValue("@dataLanc", Jogo.DataLanc);
                cmd.Parameters.AddWithValue("@categoria", Jogo.Categoria);
                cmd.Parameters.AddWithValue("@sinopse", Jogo.Sinopse);
                cmd.Parameters.AddWithValue("@plataforma", Jogo.Plataforma);
                cmd.Parameters.AddWithValue("@capaJogo", Jogo.CapaJogo);

                SqlParameter nv = cmd.Parameters.AddWithValue("@idJogo", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");

            }
            catch (Exception)
            {

                throw;
            }


        }

        public void visuJogoAleatorio()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisuJogoAleatorio", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);
                cn.Open();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Jogo.NomeJogo = dr["nomeJogo"].ToString();
                    Jogo.DesenvJogo = dr["desenvJogo"].ToString();
                    
                    DateTime data = Convert.ToDateTime(dr["dataLanc"]);

                    Jogo.DataLancMostrar = data.ToString("dd/MM/yyyy"); 
                    Jogo.Categoria = dr["categoria"].ToString();
                    Jogo.CapaJogo = ((byte[])dr["capaJogo"]);
                    Jogo.Plataforma = dr["plataforma"].ToString();
                    Jogo.Sinopse = dr["sinopse"].ToString();


                }
                else
                {
                    MessageBox.Show("Dados não encontrados!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string contadorNotas1()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContarNotas1", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);

            cn.Open();

            return Convert.ToString(cmd.ExecuteScalar());
        }

        public static string contadorNotas2()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContarNotas2", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);

            cn.Open();

            return Convert.ToString(cmd.ExecuteScalar());
        }

        public static string contadorNotas3()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContarNotas3", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);

            cn.Open();

            return Convert.ToString(cmd.ExecuteScalar());
        }

        public static string contadorNotas4()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContarNotas4", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);

            cn.Open();

            return Convert.ToString(cmd.ExecuteScalar());
        }

        public static string contadorNotas5()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pContarNotas5", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);

            cn.Open();

            return Convert.ToString(cmd.ExecuteScalar());
        }

        public void votarJogo()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVotarJogo", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);
            cmd.Parameters.AddWithValue("@nota", Jogo.DarNotaJogo);

            SqlParameter nv = cmd.Parameters.AddWithValue("@idNota", SqlDbType.Int);
            nv.Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Obrigado por votar!");

        }

        public void visuJogo()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pVisuJogo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeJogo", Jogo.NomejogoBox);
                cn.Open();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Jogo.NomeJogo = dr["nomeJogo"].ToString();
                    Jogo.DesenvJogo = dr["desenvJogo"].ToString();

                    DateTime data = Convert.ToDateTime(dr["dataLanc"]);

                    Jogo.DataLancMostrar = data.ToString("dd/MM/yyyy");
                    Jogo.Categoria = dr["categoria"].ToString();
                    Jogo.CapaJogo = ((byte[])dr["capaJogo"]);
                    Jogo.Plataforma = dr["plataforma"].ToString();
                    Jogo.IdJogo = Convert.ToInt32(dr["idjogo"]);
                    Jogo.Sinopse = dr["sinopse"].ToString();
                    

                }
                else
                {
                    MessageBox.Show("Dados não encontrados!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void alterarJogo()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarJogo", cn);
            cmd.CommandType = CommandType.StoredProcedure;


           // cmd.Parameters.AddWithValue("@nomeJogo", Jogo.NomeJogo);
            cmd.Parameters.AddWithValue("@desenvJogo",Jogo.DesenvJogo);
            cmd.Parameters.AddWithValue("@dataLanc", Jogo.DataLanc);
            cmd.Parameters.AddWithValue("@categoria", Jogo.Categoria);
            cmd.Parameters.AddWithValue("@sinopse", Jogo.Sinopse);
            cmd.Parameters.AddWithValue("@plataforma", Jogo.Plataforma);
           //cmd.Parameters.AddWithValue("@capaJogo", Jogo.CapaJogo);
            cmd.Parameters.AddWithValue("@idJogo", Jogo.IdJogo);




            cn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Jogo alterado com sucesso");

        }

        


    }

}
