using System;
using MySql.Data.MySqlClient;

namespace Arqueng.DAO
{
    class CONEXAO
    {
        string conexao = "SERVER=localhost; DATABASE=cef_db; UID=root; PWD=;";
        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
