using HotelManagement.Core;
using HotelManagement.DTO;
using HotelManagement.GUI;
using HotelManagement.Ultils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class CustomerDAO
    {
        private MySqlConnection conn;
        public CustomerDAO()
        {
            conn = BaseConnection.getConnection();
        }
        public List<Customer> getAll()
        {
            conn.Open();
            string query = "select * from customer";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            List<Customer> list = new List<Customer>();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetString("ID");
                    string fullname = reader.GetString("Fullname");
                    int gender = reader.GetString("Gender").Equals("Nam") ? 1 : 0;
                    string birthday = reader.GetDateTime("Birthday").ToString(Configs.formatBirthday);
                    string address = reader.GetString("Address");
                    string cccd = reader.GetString("CitizenID");
                    string phone = reader.GetString("PhoneNumber");
                    list.Add(new Customer(id,fullname,gender,birthday,address,cccd,phone));
                }
            }

            conn.Close();

            return list;
        }
        public int add(Customer customer)
        {
            conn.Open();
            string query = "insert into customer (ID,Fullname,Gender,Birthday,Address,CitizenID,PhoneNumber) values " +
            "(@id,@fullname,@gender,@birthday,@address,@citizen_id,@phone_number)";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id",customer.Id);
            cmd.Parameters.AddWithValue("@fullname",customer.Fullname);
            cmd.Parameters.AddWithValue("@gender",customer.Gender == 1 ? "Nam" : "Nữ");
            cmd.Parameters.AddWithValue("@birthday", DateTime.ParseExact(customer.Birthday, Configs.formatBirthday, CultureInfo.InvariantCulture, DateTimeStyles.None));
            cmd.Parameters.AddWithValue("@address",customer.Address);
            cmd.Parameters.AddWithValue("@citizen_id",customer.CitizenId);
            cmd.Parameters.AddWithValue("@phone_number",customer.Phone);

            int result = cmd.ExecuteNonQuery(); 

            conn.Close();
            return result;
        }

        public int update(Customer customer)
        {
            conn.Open();
            string query = "update customer set " +
            "Fullname = @fullname," +
            "Gender = @gender," +
            "Birthday = @birthday," +
            "Address = @address," +
            "CitizenID = @citizen_id," +
            "PhoneNumber = @phone_number  " +
            "where ID = @id";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", customer.Id);
            cmd.Parameters.AddWithValue("@fullname", customer.Fullname);
            cmd.Parameters.AddWithValue("@gender", customer.Gender == 1 ? "Nam" : "Nữ");
            cmd.Parameters.AddWithValue("@birthday", DateTime.ParseExact(customer.Birthday, Configs.formatBirthday, CultureInfo.InvariantCulture, DateTimeStyles.None));
            cmd.Parameters.AddWithValue("@address", customer.Address);
            cmd.Parameters.AddWithValue("@citizen_id", customer.CitizenId);
            cmd.Parameters.AddWithValue("@phone_number", customer.Phone);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }

        public int delete(string id)
        {
            conn.Open();
            string query = "delete from customer where ID = @id";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            return result;
        }
        public int getLength()
        {
            conn.Open();

            string query = "select * from customer";
            using MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            conn.Close();
            return table.Rows.Count;    
        }
    }
}
