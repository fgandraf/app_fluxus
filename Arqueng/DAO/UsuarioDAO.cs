using System;
using Arqueng.ENTIDADES;
using MySql.Data.MySqlClient;
using System.Data;

namespace Arqueng.DAO
{
    public class UsuarioDAO
    {

        //MySqlCommand sql;
        //CONEXAO con = new CONEXAO();

        //public void BuscarUsuarioDAO(UsuarioENT dado)
        //{
            //try
            //{
            //    con.AbrirConexao();
            //    sql = new MySqlCommand("SELECT nomeid FROM tb_profissionais WHERE codigo = @codigo", con.con);
            //    sql.Parameters.AddWithValue("@codigo", dado.Codigo);
            //    MySqlDataReader dr = sql.ExecuteReader();

            //    if (dr.HasRows == false)
            //        dado.Nomeid = null;
            //    else
            //    {
            //        while (dr.Read())
            //        {
            //            dado.Nomeid = Convert.ToString(dr["nomeid"]);
            //        }
            //    }

            //    con.FecharConexao();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        //}
    }
}
