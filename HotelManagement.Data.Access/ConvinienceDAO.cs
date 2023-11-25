using HotelManagement.Data.Access.Core;
using HotelManagement.DTO;
using HotelManagement.Ultils;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class ConvinienceDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        

        public ConvinienceDAO()
        {
            conn = BaseConnection.getConnection();
        }
        public List<Convinience2> getAll()
        {
            List<Convinience2> list = new List<Convinience2>();
            try
            {
                conn.Open();
                string query = "select * from convinience";

                cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Convinience2 c = new Convinience2();
                    c.Id = reader["id"].ToString();
                    c.Name = reader["name"].ToString();

                    list.Add(c);
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return list;
            }
            finally {
                conn.Close();
            }
        }

        public int add(Convinience2 convinience)
        {
            int result = 0;
            try
            {
                conn.Open();
                string query = "insert into convinience (id, name)" +
                " Values(@id,@name)";
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", convinience.Id);
                cmd.Parameters.AddWithValue("@name", convinience.Name);

                result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            finally { conn.Close(); }
            
        }

        public int update(Convinience2 convinience)
        {
            int result = 0;
            try
            {
                conn.Open();
                string query = "update convinience set " +
                "Name = @name " +
                "where ID = @id";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", convinience.Id);
                cmd.Parameters.AddWithValue("@name", convinience.Name);

                result = cmd.ExecuteNonQuery();

                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return result;
            }
            finally { conn.Close(); }
            
        }

        public int delete(string id)
        {
            int result = 0;
            try
            {
                conn.Open();
                string query = "delete from covinience where ID = @id";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }finally { conn.Close(); }
            
        }

        public string getMaxID()
        {
            try
            {
                conn.Open();
                string query = "select max(id) from convinience";
                using MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conn;

                object result = cmd.ExecuteScalar();

                return result.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally { conn.Close(); }
        }
    }
}
