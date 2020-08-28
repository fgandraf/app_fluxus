using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{


    public class AtividadesDAO
    {


        MySqlCommand sql;
        CONEXAO con = new CONEXAO();


        public DataTable SelectAllDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_atividades ORDER BY codigo", con.con);
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
 

        public void InsertDAO(AtividadesENT dado)
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


        public void UpdateDAO(AtividadesENT dado)
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


        public void DeleteDAO(AtividadesENT dado)
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


}
