using HotelManagement.Core;
using HotelManagement.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class ServiceDAO
    {
        private MySqlConnection conn;
        public ServiceDAO()
        {
            conn = BaseConnection.getConnection();
        }
        public List<Service> getAllService()
        {
            conn.Open();
            string query = "select service.*,service_type.Name as ServiceTypeName from service,service_type where service.ServiceTypeID = service_type.ID and  service.IS_DELETED = 0";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            List<Service> list = new List<Service>();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetString("ID");
                    string name = reader.GetString("Name");
                    double unitPrice = reader.GetDouble("UnitPrice");
                    string unit = reader.GetString("Unit");
                    string serviceTypeId = reader.GetString("ServiceTypeID");
                    string serviceTypeName = reader.GetString("ServiceTypeName");
                    list.Add(new Service(id, name,unitPrice,unit,serviceTypeId,serviceTypeName));
                }
            }

            conn.Close();

            return list;
        }
        public int addService(Service service)
        {
            conn.Open();
            string query = "insert into service (ID,Name,UnitPrice,Unit,ServiceTypeID) values " +
            "(@id,@name,@unitPrice,@unit,@serviceTypeID)";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", service.Id);
            cmd.Parameters.AddWithValue("@name", service.Name);
            cmd.Parameters.AddWithValue("@unitPrice", service.Unit_price);
            cmd.Parameters.AddWithValue("@unit", service.Unit);
            cmd.Parameters.AddWithValue("@serviceTypeID", service.Service_type_id);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int updateService(Service service)
        {
            conn.Open();
            string query = "update service set " +
                "Name = @name," +
                "UnitPrice = @unitPrice," +
                "Unit = @unit," +
                "ServiceTypeID = @serviceTypeID " +
                " where ID = @id";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", service.Id);
            cmd.Parameters.AddWithValue("@name", service.Name);
            cmd.Parameters.AddWithValue("@unitPrice", service.Unit_price);
            cmd.Parameters.AddWithValue("@unit", service.Unit);
            cmd.Parameters.AddWithValue("@serviceTypeID", service.Service_type_id);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int deleteService(string id)
        {
            conn.Open();
            string query = "update service set IS_DELETED = 1 where ID = @id";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }
        public int getLengthService()
        {
            conn.Open();

            string query = "select * from service";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            conn.Close();
            return table.Rows.Count;
        }

        public List<ServiceType> getAllType()
        {
            conn.Open();
            string query = "select * from service_type where IS_DELETED = 0";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            List<ServiceType> list = new List<ServiceType>();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetString("ID");
                    string name = reader.GetString("Name");
                    list.Add(new ServiceType(id, name));
                }
            }

            conn.Close();

            return list;
        }
        public int addType(ServiceType serviceType)
        {
            conn.Open();
            string query = "insert into service_type (ID,Name) values (@id,@name)";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", serviceType.Id);
            cmd.Parameters.AddWithValue("@name", serviceType.Name);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int updateType(ServiceType serviceType)
        {
            conn.Open();
            string query = "update service_type set Name = @name  where ID = @id";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", serviceType.Id);
            cmd.Parameters.AddWithValue("@name", serviceType.Name);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int deleteType(string id)
        {
            conn.Open();
            string query = "update service_type set IS_DELETED = 1 where ID = @id";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int getLengthType()
        {
            conn.Open();

            string query = "select * from service_type";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            conn.Close();
            return table.Rows.Count;
        }

        public int getLengServiceForType(string type_id)
        {
            conn.Open();

            string query = "select * from service,service_type where service.ServiceTypeID = service_type.ID " +
                "and service_type.ID = @type_id and service.IS_DELETED = 0";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@type_id",type_id);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            conn.Close();
            return table.Rows.Count;
        }
    }
}
