using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Simulador_de_Certificações_Informáticas
{
    static class SQL
    {
        public static MySqlConnection connection = new MySqlConnection("server=localhost; Database=paf_database; user=root; pwd=root");
        public static MySqlCommand command = new MySqlCommand();
        public static MySqlDataReader dataReader;
    }
}
