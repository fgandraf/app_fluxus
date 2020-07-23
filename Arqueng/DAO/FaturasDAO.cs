﻿using System;
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
                sql = new MySqlCommand("INSERT INTO tb_fatura(descricao, data, subtotal_os, subtotal_desloc, total, rrtart) VALUES (@descricao, @data, @subtotal_os, @subtotal_desloc, @total, @rrtart)", con.con);
                sql.Parameters.AddWithValue("@descricao", dado.descricao);
                sql.Parameters.AddWithValue("@data", dado.data);
                sql.Parameters.AddWithValue("@subtotal_os", dado.subtotal_os);
                sql.Parameters.AddWithValue("@subtotal_desloc", dado.subtotal_desloc);
                sql.Parameters.AddWithValue("@total", dado.total);
                sql.Parameters.AddWithValue("@rrtart", dado.rrtart);
                sql.ExecuteNonQuery();

                dado.id = Convert.ToInt32(sql.LastInsertedId);

                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public DataTable ListarFaturasDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_fatura ORDER BY data", con.con);
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