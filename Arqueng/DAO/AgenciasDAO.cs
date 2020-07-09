using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{


    public class AgenciasDAO
    {
        

        MySqlCommand sql;
        CONEXAO con = new CONEXAO();


        public DataTable ListarAgenciasDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_agencias ORDER BY agencia", con.con);
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


        public void BuscarAgenciaDAO(AgenciasENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT nome, telefone1, email FROM tb_agencias WHERE agencia = @agencia", con.con);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows == false)
                    dado.Agencia = null;
                else
                {
                    while (dr.Read())
                    {
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Telefone1 = Convert.ToString(dr["telefone1"]);
                        dado.Email = Convert.ToString(dr["email"]);
                    }
                }

                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void InsertAgenciaDAO(AgenciasENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO  tb_agencias(agencia, nome, endereco, complemento, bairro, cidade, CEP, UF, contato, telefone1, telefone2, email) VALUES (@agencia, @nome, @endereco, @complemento, @bairro, @cidade, @CEP, @UF, @contato, @telefone1, @telefone2, @email)", con.con);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@complemento", dado.Complemento);
                sql.Parameters.AddWithValue("@bairro", dado.Bairro);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@CEP", dado.CEP);
                sql.Parameters.AddWithValue("@UF", dado.UF);
                sql.Parameters.AddWithValue("@contato", dado.Contato);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateAgenciaDAO(AgenciasENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_agencias SET nome = @nome, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, CEP = @CEP, UF = @UF, contato = @contato, telefone1 = @telefone1, telefone2 = @telefone2, email = @email WHERE agencia = @agencia", con.con);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@complemento", dado.Complemento);
                sql.Parameters.AddWithValue("@bairro", dado.Bairro);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@CEP", dado.CEP);
                sql.Parameters.AddWithValue("@UF", dado.UF);
                sql.Parameters.AddWithValue("@contato", dado.Contato);
                sql.Parameters.AddWithValue("@telefone1", dado.Telefone1);
                sql.Parameters.AddWithValue("@telefone2", dado.Telefone2);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void DeleteAgenciaDAO(AgenciasENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM tb_agencias WHERE agencia = @agencia", con.con);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
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
