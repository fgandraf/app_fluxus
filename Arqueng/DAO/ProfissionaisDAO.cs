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


        public DataTable SelectAllDAO()
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


        public void InsertDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_profissionais(codigo, nome, nomeid, cpf, nascimento, profissao, carteira, entidade, telefone1, telefone2, email, rt, rl, usr_ativo, usr_nome, usr_senha) VALUES (@codigo, @nome, @nomeid, @cpf, @nascimento, @profissao, @carteira, @entidade, @telefone1, @telefone2, @email, @rt, @rl, @usr_ativo, @usr_nome, @usr_senha)", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@nomeid", dado.Nomeid);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
                sql.Parameters.AddWithValue("@profissao", dado.Profissao);
                sql.Parameters.AddWithValue("@carteira", dado.Carteira);
                sql.Parameters.AddWithValue("@entidade", dado.Entidade);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@rt", dado.Rt);
                sql.Parameters.AddWithValue("@rl", dado.Rl);
                sql.Parameters.AddWithValue("@usr_ativo", dado.Usr_ativo);
                sql.Parameters.AddWithValue("@usr_nome", dado.Usr_nome);
                sql.Parameters.AddWithValue("@usr_senha", dado.Usr_senha);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_profissionais SET nome = @nome, nomeid = @nomeid, cpf = @cpf, nascimento = @nascimento, profissao = @profissao, carteira = @carteira, entidade = @entidade, telefone1 = @telefone1, telefone2 = @telefone2, email = @email, rt = @rt, rl = @rl, usr_ativo = @usr_ativo, usr_nome = @usr_nome, usr_senha = @usr_senha WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@nomeid", dado.Nomeid);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@nascimento", dado.Nascimento);
                sql.Parameters.AddWithValue("@profissao", dado.Profissao);
                sql.Parameters.AddWithValue("@carteira", dado.Carteira);
                sql.Parameters.AddWithValue("@entidade", dado.Entidade);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@rt", dado.Rt);
                sql.Parameters.AddWithValue("@rl", dado.Rl);
                sql.Parameters.AddWithValue("@usr_ativo", dado.Usr_ativo);
                sql.Parameters.AddWithValue("@usr_nome", dado.Usr_nome);
                sql.Parameters.AddWithValue("@usr_senha", dado.Usr_senha);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void DeleteDAO(ProfissionaisENT dado)
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


        public void BuscarUsuarioDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT codigo, rt, rl, usr_nome, usr_ativo, usr_senha FROM tb_profissionais WHERE usr_nome = @usr_nome", con.con);
                sql.Parameters.AddWithValue("@usr_nome", dado.Usr_nome);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows == false)
                    Globais.Usr_nome = null;
                else
                {
                    while (dr.Read())
                    {
                        Globais.Codpro = Convert.ToString(dr["codigo"]);
                        Globais.Rt = Convert.ToBoolean(dr["rt"]);
                        Globais.Rl = Convert.ToBoolean(dr["rl"]);
                        Globais.Usr_nome = Convert.ToString(dr["usr_nome"]);
                        Globais.Usr_ativo = Convert.ToBoolean(dr["usr_ativo"]);
                        Globais.Usr_senha = Convert.ToString(dr["usr_senha"]);
                    }
                }

                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }













        ///////////////////////////////////////////////////////////////////////////////////////////////









        public bool BuscarNomeUsuarioDAO(ProfissionaisENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT usr_nome FROM tb_profissionais WHERE usr_nome = @usr_nome", con.con);
                sql.Parameters.AddWithValue("@usr_nome", dado.Usr_nome);
                MySqlDataReader dr = sql.ExecuteReader();

                return dr.HasRows;
            }
            catch (Exception)
            {
                throw;
            }
        }

        


    }


}
