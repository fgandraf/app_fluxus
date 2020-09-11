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


        public DataTable SelectAllDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_os ORDER BY data_ordem", con.con);
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


        public DataTable NFaturadasDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_os WHERE fatura_cod = 0 ORDER BY data_ordem", con.con);
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


        public void InsertDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_os(titulo, referencia, agencia, data_ordem, prazo_execucao, profissional_cod, atividade_cod, siopi, nome_cliente, cidade, nome_contato, telefone_contato, coordenada, status, data_pendente, data_vistoria, data_concluida, obs) VALUES (@titulo, @referencia, @agencia, @data_ordem, @prazo_execucao, @profissional_cod, @atividade_cod, @siopi, @nome_cliente, @cidade, @nome_contato, @telefone_contato, @coordenada, @status, @data_pendente, @data_vistoria, @data_concluida, @obs)", con.con);

                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@coordenada", dado.Coordenada);
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


        public void UpdateDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET titulo = @titulo, data_ordem = @data_ordem, prazo_execucao = @prazo_execucao, profissional_cod = @profissional_cod, atividade_cod = @atividade_cod, siopi = @siopi, nome_cliente = @nome_cliente, cidade = @cidade, nome_contato = @nome_contato, telefone_contato = @telefone_contato, coordenada = @coordenada, status = @status, data_pendente = @data_pendente, data_vistoria = @data_vistoria, data_concluida = @data_concluida, obs = @obs WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@coordenada", dado.Coordenada);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateFaturada(string referencia, string fatura_cod)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET fatura_cod = @fatura_cod WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", referencia);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
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
                sql = new MySqlCommand("DELETE FROM tb_os WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public DataTable ListarOSFaturaDAO(string fatura_cod, bool status)
        {
            try
            {
                con.AbrirConexao();
                if (status == false)
                    sql = new MySqlCommand("SELECT t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t1.fatura_cod, t1.status, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t1.data_concluida", con.con);
                else
                    sql = new MySqlCommand("SELECT t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t1.fatura_cod, t1.status, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = 0 AND status = 'CONCLUÍDA' ORDER BY t1.data_concluida", con.con);

                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
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

        public DataTable ListarOSFiltradaDAO(string sqlFiltro)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand(sqlFiltro, con.con);
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











































        //***** LISTAR ORDENS DE SERVIÇO À SEREM FATURADAS *****//
        public DataTable ListarOSAFaturarDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.status = 'CONCLUÍDA' AND t1.fatura_cod = 0 ORDER BY t1.data_concluida", con.con);
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



        public DataTable DistinctProOSFaturadaDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT DISTINCT t1.profissional_cod, t2.nomeid FROM tb_os t1 INNER JOIN tb_profissionais t2 on t1.profissional_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t2.nomeid", con.con);
                sql.Parameters.AddWithValue("@fatura_cod", dado.Fatura_cod);
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




        public void UpdateStatusRecebida(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET status = 'RECEBIDA' WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateStatusPendente(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET status = 'PENDENTE', data_pendente = @data_pendente WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@data_pendente", DateTime.Now);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }

        public void UpdateStatusVistoriada(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET status = 'VISTORIADA', data_vistoria = @data_vistoria WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@data_vistoria", DateTime.Now);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }

        public void UpdateStatusConcluida(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET status = 'CONCLUÍDA', data_concluida = @data_concluida WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@data_concluida", DateTime.Now);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }



        public DataTable DistinctCidadesDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT DISTINCT cidade FROM tb_os ORDER BY cidade", con.con);
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



    }
}