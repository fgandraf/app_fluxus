using System;
using MySql.Data.MySqlClient;

namespace FluxusAPI.DAO
{
    public class ConnectionToServer
    {
        
        public MySqlConnection Conn;
        private string _connectionString = ConnectionString.Conn;

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
                //Conn = new MySqlConnection(_connectionString);
                Conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
