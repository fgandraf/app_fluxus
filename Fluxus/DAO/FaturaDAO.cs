using System;
using System.Data;
using MySql.Data.MySqlClient;
using Fluxus.Model.ENT;

namespace Fluxus.DAO
{


    class FaturaDAO
    {
        MySqlCommand sql;
        Connection con = new Connection();




        //:INSERT
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



        //:UPDATE
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



        //:DELETE
        public void Delete(long id)
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



        //:SELECT
        public DataTable GetAll()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_fatura ORDER BY data", con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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

        public string GetDescricaoById(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT descricao FROM tb_fatura WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();
                dr.Read();
                if (dr.HasRows == false)
                    return null;
                else
                    return Convert.ToString(dr["descricao"]);
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
