using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Access.Core
{
    public static class BaseConnection
    {
        public static MySqlConnection Connection
            => new(new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = "qlks",
                UserID = "root",
                Password = Environment.GetEnvironmentVariable("CS_QLKS_MySQL_PWD",
                    EnvironmentVariableTarget.User) ?? "",
                Port = 3306
            }.ToString());

        public static MySqlConnection getConnection()
        {
            var mysqlBuilder = new MySqlConnectionStringBuilder();
            mysqlBuilder["Server"] = "127.0.0.1";
            mysqlBuilder["Database"] = "qlks";
            mysqlBuilder["UID"] = "root";
            mysqlBuilder["PWD"] = "";
            mysqlBuilder["Port"] = "3306";

            string mysqlStringConnection = mysqlBuilder.ToString();

            MySqlConnection connection = new MySqlConnection(mysqlStringConnection);

            return connection;
        }

    }
}
