using API.Model.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace API.Model.DB
{
    public class AtividadeDB
    {



        MySqlCommand sql;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=fluxus; UID=root; PWD=; PORT=3308");


        public long Insert(AtividadeENT dado)
        {
            try
            {
                conn.Open();
                sql = new MySqlCommand("INSERT INTO tb_atividades(codigo, descricao, valor_atividade, valor_deslocamento) VALUES (@codigo, @descricao, @valor_atividade, @valor_deslocamento)", conn);
                sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                sql.ExecuteNonQuery();
                return sql.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }


        public bool Update(long id, AtividadeENT dado)
        {
            try
            {
                conn.Open();
                sql = new MySqlCommand("SELECT * FROM tb_atividades WHERE id = @id", conn);
                sql.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    sql = new MySqlCommand("UPDATE tb_atividades SET codigo = @codigo, descricao = @descricao, valor_atividade = @valor_atividade, valor_deslocamento = @valor_deslocamento WHERE id = @id", conn);
                    sql.Parameters.AddWithValue("@codigo", dado.Codigo);
                    sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                    sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                    sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }




        public AtividadeENT GetAtividade(long id)
        {
            try
            {
                AtividadeENT atividade = new AtividadeENT();

                conn.Open();
                sql = new MySqlCommand("SELECT * FROM tb_atividades WHERE id = @id", conn);
                sql.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.Read())
                {
                    atividade.Id = dr.GetInt32(0);
                    atividade.Codigo = dr.GetString(1);
                    atividade.Descricao = dr.GetString(2);
                    atividade.Valor_atividade = dr.GetString(3);
                    atividade.Valor_deslocamento = dr.GetString(4);
                    return atividade;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        public bool Delete(long id)
        {
            try
            {
                AtividadeENT atividade = new AtividadeENT();

                conn.Open();
                sql = new MySqlCommand("SELECT * FROM tb_atividades WHERE id = @id", conn);
                sql.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    sql = new MySqlCommand("DELETE FROM tb_atividades WHERE id = @id", conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }


        public ArrayList GetAll()
        {
            try
            {
                ArrayList atividadesArray = new ArrayList();

                conn.Open();
                sql = new MySqlCommand("SELECT * FROM tb_atividades ORDER BY codigo", conn);

                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    AtividadeENT ativ = new AtividadeENT();
                    ativ.Id = dr.GetInt32(0);
                    ativ.Codigo = dr.GetString(1);
                    ativ.Descricao = dr.GetString(2);
                    ativ.Valor_atividade = dr.GetString(3);
                    ativ.Valor_deslocamento = dr.GetString(4);
                    atividadesArray.Add(ativ);
                }

                return atividadesArray;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}