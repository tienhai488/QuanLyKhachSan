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
    public class RoomTypeDAO
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        

        public RoomTypeDAO()
        {
            conn = BaseConnection.getConnection();
        }
        public List<RoomType2> getAll()
        {
            List<RoomType2> list = new List<RoomType2>();
            try
            {
                conn.Open();
                string query = "select * from room_type";

                cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RoomType2 r = new RoomType2();
                    r.Id = reader["id"].ToString();
                    r.Name = reader["name"].ToString();
                    r.UnitPrice = Convert.ToDouble(reader["unitprice"].ToString());

                    list.Add(r);
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

        public int AddRoom(RoomType2 roomType)
        {
            int result = 0;
            try
            {
                conn.Open();
                string query = "insert into room_type (id, name, unitprice)" +
                " Values(@id,@name, @up)";
                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", roomType.Id);
                cmd.Parameters.AddWithValue("@name", roomType.Name);
                cmd.Parameters.AddWithValue("@up", roomType.UnitPrice);

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

        public int update(RoomType2 roomType)
        {
            int result = 0;
            try
            {
                conn.Open();
                string query = "update room_type set " +
                "Name = @name," +
                "unitprice = @up " +
                "where ID = @id";

                cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", roomType.Id);
                cmd.Parameters.AddWithValue("@name", roomType.Name);
                cmd.Parameters.AddWithValue("@up", roomType.UnitPrice);

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
                string query = "delete from room_type where ID = @id";
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

        public String getMaxID()
        {
            try
            {
                conn.Open();
                string query = "select max(id) from room_type";
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

//test git
