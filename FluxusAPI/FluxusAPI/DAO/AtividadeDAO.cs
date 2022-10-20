using System;
using System.Collections;
using MySql.Data.MySqlClient;
using FluxusAPI.Model;

namespace FluxusAPI.DAO
{
    public class AtividadeDAO
    {


        MySqlCommand sql;
        Connection con = new Connection();




        public ArrayList GetAll()
        {
            try
            {
                ArrayList atividadesArray = new ArrayList();

                con.OpenConnection();

                sql = new MySqlCommand("SELECT id, codigo, descricao, valor_atividade, valor_deslocamento FROM tb_atividades ORDER BY codigo", con.Conn);

                MySqlDataReader dr = sql.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AtividadeENT atividade = new AtividadeENT();

                        atividade.Id = Convert.ToInt64(dr["id"]);
                        atividade.Codigo = Convert.ToString(dr["codigo"]);
                        atividade.Descricao = Convert.ToString(dr["descricao"]);
                        atividade.Valor_atividade = Convert.ToString(dr["valor_atividade"]);
                        atividade.Valor_deslocamento = Convert.ToString(dr["valor_deslocamento"]);

                        atividadesArray.Add(atividade);
                    }
                    return atividadesArray;
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





        public AtividadeENT GetBy(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_atividades WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    AtividadeENT atividade = new AtividadeENT();
                    if (dr.Read())
                    {
                        atividade.Id = Convert.ToInt64(dr["id"]);
                        atividade.Codigo = Convert.ToString(dr["codigo"]);
                        atividade.Descricao = Convert.ToString(dr["descricao"]);
                        atividade.Valor_atividade = Convert.ToString(dr["valor_atividade"]);
                        atividade.Valor_deslocamento = Convert.ToString(dr["valor_deslocamento"]);
                    }
                    return atividade;
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





        public long Insert(AtividadeENT dado)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("INSERT INTO tb_atividades(codigo, descricao, valor_atividade, valor_deslocamento) VALUES (@codigo, @descricao, @valor_atividade, @valor_deslocamento)", con.Conn);
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
                con.CloseConnection();
            }

        }





        public void Update(long id, AtividadeENT dado)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("UPDATE tb_atividades SET descricao = @descricao, valor_atividade = @valor_atividade, valor_deslocamento = @valor_deslocamento WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@valor_atividade", dado.Valor_atividade);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
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





        public void Delete(long id)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("DELETE FROM tb_atividades WHERE id = @id", con.Conn);
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