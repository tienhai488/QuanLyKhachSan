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
//    public class Convinience_RoomTypeDAO
//    {
//        private MySqlConnection conn;
//        private MySqlCommand cmd;
        

//        public Convinience_RoomTypeDAO()
//        {
//            conn = BaseConnection.getConnection();
//        }
//        public List<Convinience_RoomType2> getAll()
//        {
//            List<Convinience_RoomType2> list = new List<Convinience_RoomType2>();
//            try
//            {
//                conn.Open();
//                string query = "select * from convinience_room_type";

//                cmd = new MySqlCommand(query, conn);

//                MySqlDataReader reader = cmd.ExecuteReader();

//                while (reader.Read())
//                {
//                    Convinience_RoomType2 cr = new Convinience_RoomType2();
//                    cr.ConvinienceID = reader["convinienceid"].ToString();
//                    cr.RoomTypeID = reader["roomtypeid"].ToString();
//                    cr.Quantity = Convert.ToInt32(reader["quantity"].ToString());

//                    list.Add(cr);
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

//        public int add(Convinience_RoomType2 convinience_roomType)
//        {
//            int result = 0;
//            try
//            {
//                conn.Open();
//                string query = "insert into convinience_room_type (convinienceid, roomtypeid, quantity)" +
//                " Values(@cid, @rtid, @qt)";
//                cmd = new MySqlCommand(query, conn);

//                cmd.Parameters.AddWithValue("@cid", convinience_roomType.ConvinienceID);
//                cmd.Parameters.AddWithValue("@rtid", convinience_roomType.RoomTypeID);
//                cmd.Parameters.AddWithValue("@qt", convinience_roomType.Quantity);

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

//        public int update(Convinience_RoomType2 convinience_roomType)
//        {
//            int result = 0;
//            try
//            {
//                conn.Open();
//                string query = "update convinience_room_type set " +
//                "quantity = @qt " +
//                "where convinienceid = @cid " +
//                "and roomtypeid = @rtid";

//                cmd = new MySqlCommand(query, conn);

//                cmd.Parameters.AddWithValue("@cid", convinience_roomType.ConvinienceID);
//                cmd.Parameters.AddWithValue("@rtid", convinience_roomType.RoomTypeID);
//                cmd.Parameters.AddWithValue("@qt", convinience_roomType.Quantity);

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

//        public int delete(string convinienceID, string roomTypeID)
//        {
//            int result = 0;
//            try
//            {
//                conn.Open();
//                string query = "delete from convinience_room_type where convinienceid = @cid and roomtypeid = @rtid";
//                cmd = new MySqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("@cid", convinienceID);
//                cmd.Parameters.AddWithValue("@rtid", roomTypeID);

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
//                string query = "select * from convinience_room_typeid";
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
