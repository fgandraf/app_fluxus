using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{


    public class ProfissionaisDAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();


        public DataTable ListarProfissionaisDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_profissionais ORDER BY codigo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable ListarCodNomeProDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT codigo, nome FROM tb_profissionais WHERE rt = '1' ORDER BY codigo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void BuscarProfissionalDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT nome FROM tb_profissionais WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows == false)
                    dado.Nome = null;
                else
                {
                    while (dr.Read())
                    {
                        dado.Nome = Convert.ToString(dr["nome"]);
                    }
                }

                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void InsertProfissionalDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_profissionais(codigo, nome, cpf, nascimento, profissao, carteira, entidade, telefone1, telefone2, email, rt) VALUES (@codigo, @nome, @cpf, @nascimento, @profissao, @carteira, @entidade, @telefone1, @telefone2, @email, @rt)", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
                sql.Parameters.AddWithValue("@profissao", dado.Profissao);
                sql.Parameters.AddWithValue("@carteira", dado.Carteira);
                sql.Parameters.AddWithValue("@entidade", dado.Entidade);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@rt", dado.Rt);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateProfissionalDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_profissionais SET nome = @nome, cpf = @cpf, nascimento = @nascimento, profissao = @profissao, carteira = @carteira, entidade = @entidade, telefone1 = @telefone1, telefone2 = @telefone2, email = @email, rt = @rt WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
                sql.Parameters.AddWithValue("@profissao", dado.Profissao);
                sql.Parameters.AddWithValue("@carteira", dado.Carteira);
                sql.Parameters.AddWithValue("@entidade", dado.Entidade);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@rt", dado.Rt);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void DeleteProfissionalDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM tb_profissionais WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


    }


}
