using System;
using MySql.Data.MySqlClient;

namespace Fluxus.Model.DAO
{
    public class Connection
    {
        string dadoscon = "SERVER=localhost; DATABASE=fluxus; UID=root; PWD=; PORT=3308; Sslmode=none; charset=utf8;";
        //string dadoscon = "SERVER=ayearquitetura.com.br; DATABASE=ayearq02_fluxus; UID=ayearq02_aye; PWD=u1GEnl939ukw;";
        public MySqlConnection Conn;



        //:METHODS
        public void OpenConnection()
        {
            try
            {
                Conn = new MySqlConnection(dadoscon);
                Conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            try
            {
                Conn = new MySqlConnection(dadoscon);
                Conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }



}
