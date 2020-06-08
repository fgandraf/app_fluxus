using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Arqueng
{
    class Conexao
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
