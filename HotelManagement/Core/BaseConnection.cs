using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Core
{
    public class BaseConnection
    {   
        public static MySqlConnection getConnection()
        {
            var mysqlBuilder = new MySqlConnectionStringBuilder();
            mysqlBuilder["Server"] = "127.0.0.1";
            mysqlBuilder["Database"] = "qlks";
            mysqlBuilder["UID"] = "root";
            mysqlBuilder["PWD"] = "Tankhuong@25";
            mysqlBuilder["Port"] = "3306";

            string mysqlStringConnection = mysqlBuilder.ToString();

            MySqlConnection connection = new MySqlConnection(mysqlStringConnection);

            return connection;
        }

    }
}
