using System;
using MySql.Data.MySqlClient;

namespace Fluxus.DAO
{
    public class Connection
    {
        private const string _connectionString = "SERVER=localhost; DATABASE=fluxus; UID=root; PWD=; PORT=3308; Sslmode=none; charset=utf8;";
        //private const string _connectionString = "SERVER=ayearquitetura.com.br; DATABASE=ayearq02_fluxus; UID=ayearq02_aye; PWD=u1GEnl939ukw;";
        //private const string _connectionString = "SERVER=fluxus-server.mysql.database.azure.com; DATABASE=fluxus; UID=fgandraf@fluxus-server; PWD=20pC6iiB0xZI; Sslmode=Required; charset=utf8;";

        public MySqlConnection Conn;



        //:METHODS
        public void OpenConnection()
        {
            try
            {
                Conn = new MySqlConnection(_connectionString);
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
                Conn = new MySqlConnection(_connectionString);
                Conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }



}
