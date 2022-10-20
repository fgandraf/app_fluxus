using System;
using MySql.Data.MySqlClient;
using FluxusAPI.Model;
using System.Collections;

namespace FluxusAPI.DAO
{


    class FaturaDAO
    {


        MySqlCommand sql;
        ConnectionToServer con = new ConnectionToServer();





        public ArrayList GetAll()
        {
            try
            {
                ArrayList faturaArray = new ArrayList();
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_fatura ORDER BY data DESC", con.Conn);
                MySqlDataReader dr = sql.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FaturaENT fatura = new FaturaENT();

                        fatura.id = Convert.ToInt32(dr["id"]);
                        fatura.descricao = Convert.ToString(dr["descricao"]);
                        fatura.data = Convert.ToDateTime(dr["data"]);
                        fatura.subtotal_os = Convert.ToDouble(dr["subtotal_os"]);
                        fatura.subtotal_desloc = Convert.ToDouble(dr["subtotal_desloc"]);
                        fatura.total = Convert.ToDouble(dr["total"]);

                        faturaArray.Add(fatura);
                    }
                    return faturaArray;
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





        public string GetDescricaoBy(string id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT descricao FROM tb_fatura WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    return Convert.ToString(dr["descricao"]);
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






        public long Insert(FaturaENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO tb_fatura(descricao, data, subtotal_os, subtotal_desloc, total) VALUES (@descricao, @data, @subtotal_os, @subtotal_desloc, @total)", con.Conn);
                sql.Parameters.AddWithValue("@descricao", dado.descricao);
                sql.Parameters.AddWithValue("@data", dado.data);
                sql.Parameters.AddWithValue("@subtotal_os", dado.subtotal_os);
                sql.Parameters.AddWithValue("@subtotal_desloc", dado.subtotal_desloc);
                sql.Parameters.AddWithValue("@total", dado.total);
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







        public void UpdateTotals(long id, FaturaENT dado)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("UPDATE tb_fatura SET subtotal_os = @subtotal_os, subtotal_desloc = @subtotal_desloc, total = @total WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@subtotal_os", dado.subtotal_os);
                sql.Parameters.AddWithValue("@subtotal_desloc", dado.subtotal_desloc);
                sql.Parameters.AddWithValue("@total", dado.total);
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





        public void Delete(string id)
        {
            try
            {
                con.OpenConnection();

                sql = new MySqlCommand("DELETE FROM tb_fatura WHERE id = @id", con.Conn);
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
