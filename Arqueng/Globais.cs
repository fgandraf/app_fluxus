using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Arqueng.Entidades
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
