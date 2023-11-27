using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Core;
using HotelManagement.DTO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace HotelManagement.DAO
{
    //CRT: convinience_room_type
    public class ConvinienceDAO
    {
        private MySqlConnection ketnoi;
        public ConvinienceDAO() 
        {
            ketnoi = BaseConnection.getConnection();
        }
        public List<Convinience> getAllvalue()
        {
            ketnoi.Open();
            string query ;
            query = "SELECT * FROM convinience";
            using MySqlCommand caulenh=new MySqlCommand();
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            List<Convinience> ds = new List<Convinience>();
            var reader = caulenh.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    string id = reader.GetString("ID");
                    string name = reader.GetString("Name");
                    ds.Add(new Convinience(id,name));
                }
            }
            ketnoi.Close();
            return ds;
        }
        public List<Convinience_Room_Type> getAllTypevalue()
        {
            ketnoi.Open();
            string query;
            query = "SELECT * FROM convinience_room_type";
            using MySqlCommand caulenh = new MySqlCommand();
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            List<Convinience_Room_Type> ds = new List<Convinience_Room_Type>();
            var reader = caulenh.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetString("ConvinienceID");
                    string id_room = reader.GetString("RoomTypeID");
                    int quantity = reader.GetInt32("Quantity");
                    ds.Add(new Convinience_Room_Type(id, id_room, quantity));
                }
            }
            ketnoi.Close();
            return ds;
        }
        public int addConvinience(Convinience convinient)
        {
            ketnoi.Open();
            string query = "insert into convinience(ID,Name) values "
                + "(@id,@name)";
            using MySqlCommand caulenh = new MySqlCommand(query, ketnoi);
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            caulenh.Parameters.AddWithValue("@id",convinient.Convinient_id);
            caulenh.Parameters.AddWithValue("@name",convinient.Convinient_name);
            int ketqua = caulenh.ExecuteNonQuery();
            ketnoi.Close();
            return ketqua;
        }
        public int addCRT(Convinience_Room_Type crt)
        {
            ketnoi.Open();
            string query = "INSERT INTO `convinience_room_type` (`ConvinienceID`, `RoomTypeID`, `Quantity`) VALUES (@convinienceID, @roomTypeID, @quantity)";
            using MySqlCommand caulenh = new MySqlCommand(query, ketnoi);
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            caulenh.Parameters.AddWithValue("@convinienceID", crt.Convinient_id1);
            caulenh.Parameters.AddWithValue("@roomTypeID", crt.Id_room);
            caulenh.Parameters.AddWithValue("@quantity",crt.Convinient_quantity);
            int ketqua = caulenh.ExecuteNonQuery();
            ketnoi.Close();
            return ketqua;
        }
        public int updateConvinience(Convinience convinient)
        {
            ketnoi.Open();
            string query = "update convinience set ID=@id,Name=@name";
            using MySqlCommand caulenh = new MySqlCommand(query, ketnoi);
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            caulenh.Parameters.AddWithValue("@id", convinient.Convinient_id);
            caulenh.Parameters.AddWithValue("@name", convinient.Convinient_name);
            int ketqua = caulenh.ExecuteNonQuery();
            ketnoi.Close();
            return ketqua;
        }
        public int updateCRT(Convinience_Room_Type crt)
        {
            ketnoi.Open();
            string query = "update convinience_room_type set ConvinienceID=@convinienceID,RoomTypeID=@roomTypeID,Quantity=@quantity";
            using MySqlCommand caulenh = new MySqlCommand(query, ketnoi);
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            caulenh.Parameters.AddWithValue("@convinienceID",crt.Convinient_id1);
            caulenh.Parameters.AddWithValue("@roomTypeID",crt.Id_room);
            caulenh.Parameters.AddWithValue("@quantity",crt.Convinient_quantity);
            int ketqua = caulenh.ExecuteNonQuery();
            ketnoi.Close();
            return ketqua;
        }
        public int deleteConvinience(string matn)
        {
            ketnoi.Open();
            string query = "delete from convinience where ID = @id";
            using MySqlCommand caulenh = new MySqlCommand(query,ketnoi);
            caulenh.CommandText = query;
            caulenh.Parameters.AddWithValue("@id",matn);
            int ketqua = caulenh.ExecuteNonQuery();
            ketnoi.Close();
            return ketqua;
        }
        public int deleteCRT(string matn,string maphong)
        {
            ketnoi.Open();
            string query = "delete from convinience_room_type where ConvinienceID = @convinienceID AND RoomTypeID = @roomTypeID";
            using MySqlCommand caulenh = new MySqlCommand(query,ketnoi);
            caulenh.CommandText = query;
            caulenh.Parameters.AddWithValue("@convinienceID",matn);
            caulenh.Parameters.AddWithValue("@roomTypeID", maphong);
            int ketqua = caulenh.ExecuteNonQuery();
            ketnoi.Close();
            return ketqua;
        }
        public int getLengthConvinience()
        {
            ketnoi.Open();
            string query = "SELECT * FROM convinience";
            using MySqlCommand caulenh = new MySqlCommand();
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(caulenh);
            adapter.Fill(table);
            ketnoi.Close();
            return table.Rows.Count;
        }
        public int getLengthCRT()
        {
            ketnoi.Open();
            string query = "SELECT * FROM convinience_room_type";
            using MySqlCommand caulenh = new MySqlCommand();
            caulenh.CommandText = query;
            caulenh.Connection = ketnoi;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(caulenh);
            adapter.Fill(table);
            ketnoi.Close();
            return table.Rows.Count;
        }
    }
}
