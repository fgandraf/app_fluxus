using MySql.Data.MySqlClient;

namespace Arqueng.Globais
{
    public class My
    {
        public static MySqlConnection conexaoDB;
        public static MySqlCommand comando;
        public static MySqlDataAdapter da;
        public static MySqlDataReader dr;
        public static string dadosdb = "SERVER=localhost; DATABASE=cef_db; UID=root; PWD=;";
    }
}
