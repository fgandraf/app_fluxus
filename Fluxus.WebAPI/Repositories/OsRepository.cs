using System;
using MySql.Data.MySqlClient;
using Fluxus.Domain.Models;
using System.Collections;
using System.Globalization;

namespace Fluxus.API.Repositories
{


    public class OsRepository
    {


        MySqlCommand sql;
        Connection con = new Connection();








        public ArrayList GetOrdensDoFluxo()
        {
            try
            {
                ArrayList osArray = new ArrayList();
                con.OpenConnection();
                sql = new MySqlCommand("SELECT id, referencia, titulo, status, profissional_cod FROM tb_os WHERE fatura_cod = 0 ORDER BY data_ordem", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dynamic osFluxo = new
                        {
                            Id = Convert.ToInt64(dr["id"]),
                            Referencia = Convert.ToString(dr["referencia"]),
                            Titulo = Convert.ToString(dr["titulo"]),
                            Status = Convert.ToString(dr["status"]),
                            Profissional_cod = Convert.ToString(dr["profissional_cod"])
                        };

                        osArray.Add(osFluxo);
                    }
                    return osArray;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public ArrayList GetOrdensFaturadasBy(long fatura_cod)
        {
            try
            {
                ArrayList osArray = new ArrayList();

                con.OpenConnection();
                //sql = new MySqlCommand("SELECT t1.id, t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t1.fatura_cod, t1.status, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t1.data_concluida", con.Conn);
                sql = new MySqlCommand("SELECT id, data_ordem, referencia, profissional_cod, atividade_cod, cidade, nome_cliente, data_vistoria, data_concluida, fatura_cod, status, valor_atividade, valor_deslocamento FROM tb_os WHERE fatura_cod = @fatura_cod ORDER BY data_concluida", con.Conn);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        dynamic osFatura = new
                        {
                            Id = Convert.ToInt64(dr["id"]),
                            Data_ordem = Convert.ToDateTime(dr["data_ordem"]),
                            Referencia = Convert.ToString(dr["referencia"]),
                            Profissional_cod = Convert.ToString(dr["profissional_cod"]),
                            Atividade_cod = Convert.ToString(dr["atividade_cod"]),
                            Cidade = Convert.ToString(dr["cidade"]),
                            Nome_cliente = Convert.ToString(dr["nome_cliente"]),
                            Data_vistoria = Convert.ToDateTime(dr["data_vistoria"]),
                            Data_concluida = Convert.ToDateTime(dr["data_concluida"]),
                            Fatura_cod = Convert.ToInt64(dr["fatura_cod"]),
                            Status = Convert.ToString(dr["status"]),
                            Valor_atividade = Convert.ToDouble(dr["valor_atividade"]),
                            Valor_deslocamento = Convert.ToDouble(dr["valor_deslocamento"])
                        };

                        osArray.Add(osFatura);

                    }
                    return osArray;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public ArrayList GetOrdensConcluidasAFaturar()
        {
            try
            {
                ArrayList osArray = new ArrayList();

                con.OpenConnection();
                //sql = new MySqlCommand("SELECT t1.id, t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = 0 AND status = 'CONCLUÍDA' ORDER BY t1.data_concluida", con.Conn);
                sql = new MySqlCommand("SELECT id, data_ordem, referencia, profissional_cod, atividade_cod, cidade, nome_cliente, data_vistoria, data_concluida, valor_atividade, valor_deslocamento FROM tb_os WHERE fatura_cod = 0 AND status = 'CONCLUÍDA' ORDER BY data_concluida", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dynamic osFatura = new
                        {
                            Id = Convert.ToInt64(dr["id"]),
                            Data_ordem = Convert.ToDateTime(dr["data_ordem"]),
                            Referencia = Convert.ToString(dr["referencia"]),
                            Profissional_cod = Convert.ToString(dr["profissional_cod"]),
                            Atividade_cod = Convert.ToString(dr["atividade_cod"]),
                            Cidade = Convert.ToString(dr["cidade"]),
                            Nome_cliente = Convert.ToString(dr["nome_cliente"]),
                            Data_vistoria = Convert.ToDateTime(dr["data_vistoria"]),
                            Data_concluida = Convert.ToDateTime(dr["data_concluida"]),
                            Valor_atividade = Convert.ToDouble(dr["valor_atividade"]),
                            Valor_deslocamento = Convert.ToDouble(dr["valor_deslocamento"])
                        };

                        osArray.Add(osFatura);
                    }
                    return osArray;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public ArrayList GetFiltered(string filtro)
        {
            try
            {
                ArrayList osArray = new ArrayList();
                con.OpenConnection();
                sql = new MySqlCommand(filtro, con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Os os = new Os();

                        os.Id = Convert.ToInt64(dr["id"]);
                        os.Referencia = Convert.ToString(dr["referencia"]);
                        os.Agencia = Convert.ToString(dr["agencia"]);
                        os.Titulo = Convert.ToString(dr["titulo"]);
                        os.Data_ordem = Util.DateTimeToShortDateString(Convert.ToString(dr["data_ordem"]));
                        os.Prazo_execucao = Convert.ToDateTime(dr["prazo_execucao"]);
                        os.Profissional_cod = Convert.ToString(dr["profissional_cod"]);
                        os.Atividade_cod = Convert.ToString(dr["atividade_cod"]);
                        os.Valor_atividade = Convert.ToString(dr["valor_atividade"]);
                        os.Valor_deslocamento = Convert.ToString(dr["valor_deslocamento"]);
                        os.Siopi = Convert.ToBoolean(dr["siopi"]);
                        os.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                        os.Cidade = Convert.ToString(dr["cidade"]);
                        os.Nome_contato = Convert.ToString(dr["nome_contato"]);
                        os.Telefone_contato = Convert.ToString(dr["telefone_contato"]);
                        os.Coordenada = Convert.ToString(dr["coordenada"]);
                        os.Status = Convert.ToString(dr["status"]);
                        os.Data_pendente = Util.DateTimeToShortDateString(Convert.ToString(dr["data_pendente"]));
                        os.Data_vistoria = Util.DateTimeToShortDateString(Convert.ToString(dr["data_vistoria"]));
                        os.Data_concluida = Util.DateTimeToShortDateString(Convert.ToString(dr["data_concluida"]));
                        os.Obs = Convert.ToString(dr["obs"]);
                        os.Fatura_cod = Convert.ToInt64(dr["fatura_cod"]);
                        osArray.Add(os);
                    }
                    return osArray;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public ArrayList GetProfissionaisDaFatura(long fatura_cod)
        {
            try
            {
                ArrayList profissionaisArray = new ArrayList();

                con.OpenConnection();
                sql = new MySqlCommand("SELECT DISTINCT t1.profissional_cod, t2.nomeid FROM tb_os t1 INNER JOIN tb_profissionais t2 on t1.profissional_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t2.nomeid", con.Conn);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);

                MySqlDataReader dr = sql.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dynamic profissionais = new
                        {
                            Codigo = Convert.ToString(dr["profissional_cod"]),
                            Nomeid = Convert.ToString(dr["nomeid"])
                        };

                        profissionaisArray.Add(profissionais);

                    }
                    return profissionaisArray;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public ArrayList GetCidadesDasOrdens()
        {
            try
            {
                ArrayList cidadesArray = new ArrayList();

                con.OpenConnection();
                sql = new MySqlCommand("SELECT DISTINCT cidade FROM tb_os ORDER BY cidade", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dynamic cidade = new
                        {
                            Cidade = Convert.ToString(dr["cidade"])
                        };

                        cidadesArray.Add(cidade);
                    }
                    return cidadesArray;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public Os GetBy(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_os WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    Os os = new Os();
                    if (dr.Read())
                    {
                        os.Id = Convert.ToInt64(dr["id"]);
                        os.Referencia = Convert.ToString(dr["referencia"]);
                        os.Agencia = Convert.ToString(dr["agencia"]);
                        os.Titulo = Convert.ToString(dr["titulo"]);
                        os.Data_ordem = Convert.ToString(dr["data_ordem"]);
                        os.Prazo_execucao = Convert.ToDateTime(dr["prazo_execucao"]);
                        os.Profissional_cod = Convert.ToString(dr["profissional_cod"]);
                        os.Atividade_cod = Convert.ToString(dr["atividade_cod"]);
                        os.Valor_atividade = Convert.ToString(dr["valor_atividade"]);
                        os.Valor_deslocamento = Convert.ToString(dr["valor_deslocamento"]);
                        os.Siopi = Convert.ToBoolean(dr["siopi"]);
                        os.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                        os.Cidade = Convert.ToString(dr["cidade"]);
                        os.Nome_contato = Convert.ToString(dr["nome_contato"]);
                        os.Telefone_contato = Convert.ToString(dr["telefone_contato"]);
                        os.Coordenada = Convert.ToString(dr["coordenada"]);
                        os.Status = Convert.ToString(dr["status"]);
                        os.Data_pendente = Convert.ToString(dr["data_pendente"]);
                        os.Data_vistoria = Convert.ToString(dr["data_vistoria"]);
                        os.Data_concluida = Convert.ToString(dr["data_concluida"]);
                        os.Obs = Convert.ToString(dr["obs"]);
                        os.Fatura_cod = Convert.ToInt64(dr["fatura_cod"]);
                    }

                    if (os.Data_ordem == "01/01/0001 00:00:00")
                        os.Data_ordem = string.Empty;

                    if (os.Data_pendente == "01/01/0001 00:00:00")
                        os.Data_pendente = string.Empty;

                    if (os.Data_vistoria == "01/01/0001 00:00:00")
                        os.Data_vistoria = string.Empty;

                    if (os.Data_concluida == "01/01/0001 00:00:00")
                        os.Data_concluida = string.Empty;




                    return os;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        /////////////////////////////////////////////////////////////////////





        public long Insert(Os dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO tb_os(titulo, referencia, agencia, data_ordem, prazo_execucao, profissional_cod, atividade_cod, valor_atividade, valor_deslocamento, siopi, nome_cliente, cidade, nome_contato, telefone_contato, coordenada, status, data_pendente, data_vistoria, data_concluida, obs) VALUES (@titulo, @referencia, @agencia, @data_ordem, @prazo_execucao, @profissional_cod, @atividade_cod, @valor_atividade, @valor_deslocamento, @siopi, @nome_cliente, @cidade, @nome_contato, @telefone_contato, @coordenada, @status, @data_pendente, @data_vistoria, @data_concluida, @obs)", con.Conn);

                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@data_ordem", Util.DateOrNull(dado.Data_ordem));
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@coordenada", dado.Coordenada);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", Util.DateOrNull(dado.Data_pendente));
                sql.Parameters.AddWithValue("@data_vistoria", Util.DateOrNull(dado.Data_vistoria));
                sql.Parameters.AddWithValue("@data_concluida", Util.DateOrNull(dado.Data_concluida));
                sql.Parameters.AddWithValue("@obs", dado.Obs);

                sql.ExecuteNonQuery();
                return sql.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        /////////////////////////////////////////////////////////////////////





        public void Update(long id, Os dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE tb_os SET titulo = @titulo, data_ordem = @data_ordem, prazo_execucao = @prazo_execucao, profissional_cod = @profissional_cod, atividade_cod = @atividade_cod, valor_atividade = valor_atividade, valor_deslocamento = valor_deslocamento, siopi = @siopi, nome_cliente = @nome_cliente, cidade = @cidade, nome_contato = @nome_contato, telefone_contato = @telefone_contato, coordenada = @coordenada, status = @status, data_pendente = @data_pendente, data_vistoria = @data_vistoria, data_concluida = @data_concluida, obs = @obs WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@data_ordem", Util.DateOrNull(dado.Data_ordem));
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@coordenada", dado.Coordenada);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", Util.DateOrNull(dado.Data_pendente));
                sql.Parameters.AddWithValue("@data_vistoria", Util.DateOrNull(dado.Data_vistoria));
                sql.Parameters.AddWithValue("@data_concluida", Util.DateOrNull(dado.Data_concluida));
                sql.Parameters.AddWithValue("@obs", dado.Obs);
                sql.Parameters.AddWithValue("@id", id);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE tb_os SET fatura_cod = @fatura_cod WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public void UpdateStatus(long id, string status)
        {
            try
            {
                con.OpenConnection();

                if (status == "RECEBIDA")
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'RECEBIDA' WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                }
                else if (status == "PENDENTE")
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'PENDENTE', data_pendente = @data_pendente WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.Parameters.AddWithValue("@data_pendente", DateTime.Now);
                }
                else if (status == "VISTORIADA")
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'VISTORIADA', data_vistoria = @data_vistoria WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.Parameters.AddWithValue("@data_vistoria", DateTime.Now);
                }
                else
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'CONCLUÍDA', data_concluida = @data_concluida WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.Parameters.AddWithValue("@data_concluida", DateTime.Now);
                }

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        /////////////////////////////////////////////////////////////////////





        public void Delete(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("DELETE FROM tb_os WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }


    }


}