
//using HotelManagement.Data.Access.Core;
//using HotelManagement.DTO;
//using HotelManagement.Ultils;
//using MySql.Data.MySqlClient;
//using MySqlX.XDevAPI.Common;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HotelManagement.DAO
//{
//    public class RoomDAO
//    {
//        private MySqlConnection conn;
//        private MySqlCommand cmd;
        

//        public RoomDAO()
//        {
//            conn = BaseConnection.getConnection();
//        }
//        public List<Room2> getAll()
//        {
//            List<Room2> list = new List<Room2>();
//            try
//            {
//                conn.Open();
//                string query = "select * from room";
//                //using MySqlCommand cmd = new MySqlCommand();
//                //cmd.CommandText = query;
//                //cmd.Connection = conn;

//                cmd = new MySqlCommand(query, conn);

//                MySqlDataReader reader = cmd.ExecuteReader();

//                while (reader.Read())
//                {
//                    Room2 r = new Room2();
//                    r.Id = reader["id"].ToString();
//                    r.Status = Convert.ToInt32(reader["status"].ToString());
//                    r.RoomTypeID = reader["roomtypeid"].ToString();

//                    list.Add(r);
//                }
//                return list;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi: " + ex.Message);
//                return list;
//            }
//            finally {
//                conn.Close();
//            }

//        }

//        public int AddRoom(Room2 room)
//        {
//            int result = 0;
//            try
//            {
//                conn.Open();
//                string query = "insert into room (id, status, roomtypeid)" +
//                " Values(@id,@st, @rtid)";
//                cmd = new MySqlCommand(query, conn);

//                cmd.Parameters.AddWithValue("@id", room.Id);
//                cmd.Parameters.AddWithValue("@st", room.Status);
//                cmd.Parameters.AddWithValue("@rtid", room.RoomTypeID);

//                result = cmd.ExecuteNonQuery();

//                return result;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                return result;
//            }
//            finally { conn.Close(); }
            
//        }

//        public int update(Room2 room)
//        {
//            int result = 0;
//            try
//            {
//                conn.Open();
//                string query = "update room set " +
//                "status = @st," +
//                "roomtypeid = @rtid " +
//                "where ID = @id";

//                cmd = new MySqlCommand(query, conn);

//                cmd.Parameters.AddWithValue("@id", room.Id);
//                cmd.Parameters.AddWithValue("@st", room.Status);
//                cmd.Parameters.AddWithValue("@rtid", room.RoomTypeID);

//                result = cmd.ExecuteNonQuery();

//                conn.Close();
//                return result;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi: " + ex.Message);
//                return result;
//            }
//            finally { conn.Close(); }
            
//        }

//        public int delete(string id)
//        {
//            int result = 0;
//            try
//            {
//                conn.Open();
//                string query = "delete from room where ID = @id";
//                cmd = new MySqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("@id", id);

//                result = cmd.ExecuteNonQuery();

//                return result;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                return result;
//            }finally { conn.Close(); }
            
//        }

//        public int getLength()
//        {
//            try
//            {
//                conn.Open();
//                string query = "select * from room";
//                using MySqlCommand cmd = new MySqlCommand();
//                cmd.CommandText = query;
//                cmd.Connection = conn;

//                DataTable table = new DataTable();
//                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
//                adapter.Fill(table);

//                return table.Rows.Count;
//            }catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                return 0;
//            }
//            finally { conn.Close(); }
//        }
//    }
//}
