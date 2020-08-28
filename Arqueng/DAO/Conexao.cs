using System;
using MySql.Data.MySqlClient;

namespace Arqueng.DAO
{


    public class CONEXAO
    {
        //string dadoscon = "SERVER=localhost; DATABASE=cef_db; UID=root; PWD=; PORT=3308";
        string dadoscon = "SERVER=ayearquitetura.com.br; DATABASE=ayearq02_cef_db; UID=ayearq02; PWD=452nyZRb7m;";
        
        public MySqlConnection con = null;


        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(dadoscon);
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
                con = new MySqlConnection(dadoscon);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}
