using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{
    public class OsDAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();

        public DataTable ListarOsDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_os order by data_ordem", con.con);
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

        public DataTable ListarOsStatusDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                if (dado.Status == null)
                    sql = new MySqlCommand("SELECT * FROM tb_os order by data_ordem", con.con);
                else
                {
                    sql = new MySqlCommand("SELECT id, titulo FROM tb_os WHERE status = @status AND faturada = 0 order by data_ordem", con.con);
                    sql.Parameters.AddWithValue("@status", dado.Status);
                }
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











        public void BuscarOSDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_os WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id);
                MySqlDataReader dr = sql.ExecuteReader();
                
                while (dr.Read())
                {
                    dado.Id = Convert.ToString(dr["id"]);
                    dado.Titulo = Convert.ToString(dr["titulo"]);
                    dado.Referencia = Convert.ToString(dr["referencia"]);
                    dado.Data_ordem = Convert.ToDateTime(dr["data_ordem"]);
                    dado.Prazo_execucao = Convert.ToDateTime(dr["prazo_execucao"]);
                    dado.Profissional_cod = Convert.ToString(dr["profissional_cod"]);
                    dado.Atividade_cod = Convert.ToString(dr["atividade_cod"]);
                    dado.Siopi = Convert.ToBoolean(dr["siopi"]);
                    dado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                    dado.Cidade = Convert.ToString(dr["cidade"]);
                    dado.Nome_contato = Convert.ToString(dr["nome_contato"]);
                    dado.Telefone_contato = Convert.ToString(dr["telefone_contato"]);
                    dado.Status = Convert.ToString(dr["status"]);
                    dado.Data_pendente = Convert.ToDateTime(dr["data_pendente"]);
                    dado.Data_vistoria = Convert.ToDateTime(dr["data_vistoria"]);
                    dado.Data_concluida = Convert.ToDateTime(dr["data_concluida"]);
                    dado.Obs = Convert.ToString(dr["obs"]);
                    dado.Faturada = Convert.ToBoolean(dr["faturada"]);
                    dado.Fatura_cod = Convert.ToString(dr["fatura_cod"]);
                }
            

                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }





















        //public DataTable ListarOsFatDAO()
        //{
        //    try
        //    {
        //        con.AbrirConexao();
        //        sql = new MySqlCommand("SELECT * FROM tb_os WHERE faturada is not null order by data_ordem", con.con);
        //        MySqlDataAdapter da = new MySqlDataAdapter();
        //        da.SelectCommand = sql;
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        public void InsertOsDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_os(titulo, referencia, data_ordem, prazo_execucao, profissional_cod, atividade_cod, siopi, nome_cliente, cidade, nome_contato, telefone_contato, status, data_pendente, data_vistoria, data_concluida, obs) VALUES (@titulo, @referencia, @data_ordem, @prazo_execucao, @profissional_cod, @atividade_cod, @siopi, @nome_cliente, @cidade, @nome_contato, @telefone_contato, @status, @data_pendente, @data_vistoria, @data_concluida, @obs)", con.con);

                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }
        public void UpdateOsDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET titulo = @titulo, referencia = @referencia, data_ordem = @data_ordem, prazo_execucao = @prazo_execucao, profissional_cod = @profissional_cod, atividade_cod = @atividade_cod, siopi = @siopi, nome_cliente = @nome_cliente, cidade = @cidade, nome_contato = @nome_contato, telefone_contato = @telefone_contato, status = @status, data_pendente = @data_pendente, data_vistoria = @data_vistoria, data_concluida = @data_concluida, obs = @obs WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id);
                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }
        public void DeleteOsDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM tb_os WHERE id = @id", con.con);
                sql.Parameters.AddWithValue("@id", dado.Id);
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
