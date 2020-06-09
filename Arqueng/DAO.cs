using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Arqueng.DAO
{
    public class Atividades_DAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();

        public DataTable ListarAtividadesDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_atividades order by codigo", con.con);
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
        public void InsertAtividadeDAO(ENT.Atividades_ENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO  tb_atividades(codigo, descricao, valor_atividade, valor_deslocamento) VALUES (@codigo, @descricao, @valor_atividade, @valor_deslocamento)", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }
        public void UpdateAtividadeDAO(ENT.Atividades_ENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_atividades SET descricao = @descricao, valor_atividade = @valor_atividade, valor_deslocamento = @valor_deslocamento WHERE codigo = @codigo", con.con);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }
        public void DeleteAtividadeDAO(ENT.Atividades_ENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM tb_atividades WHERE codigo = @codigo", con.con);
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

    public class Agencias_DAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();

        public DataTable ListarAgenciasDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_agencias order by agencia", con.con);
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
        public void InsertAgenciaDAO(ENT.Agencias_ENT dado)
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
        public void UpdateAgenciaDAO(ENT.Agencias_ENT dado)
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
        public void DeleteAgenciaDAO(ENT.Agencias_ENT dado)
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
