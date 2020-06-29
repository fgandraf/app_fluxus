using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{
    class FaturasDAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();

        public void InsertFaturaDAO(FaturasENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_fatura(descricao, data, valor_os, valor_deslocamento, valor_total, rrtart) VALUES (@descricao, @data, @valor_os, @valor_deslocamento, @valor_total, @rrtart)", con.con);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@valor_os", dado.Valor_os);
                sql.Parameters.AddWithValue("@valor_deslocamento", dado.Valor_deslocamento);
                sql.Parameters.AddWithValue("@valor_total", dado.Valor_total);
                sql.Parameters.AddWithValue("@rrtart", dado.Rrtart);
                sql.ExecuteNonQuery();

                dado.Id = Convert.ToInt32(sql.LastInsertedId);
                
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
