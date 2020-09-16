using System;
using MySql.Data.MySqlClient;

namespace Fluxus.DAO
{
    public class CONEXAO
    {
        string dadoscon = "SERVER=localhost; DATABASE=fluxus; UID=root; PWD=; PORT=3308";
        //string dadoscon = "SERVER=ayearquitetura.com.br; DATABASE=ayearq02_fluxus; UID=ayearq02_aye; PWD=u1GEnl939ukw;";
        public MySqlConnection con = null;



        //:METHODS
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
