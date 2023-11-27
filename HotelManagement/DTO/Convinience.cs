using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    public class Convinience
    {
        private string convinient_id;
        private string convinient_name;
        public Convinience(string id, string name)
        {
            this.convinient_id = id;
            this.convinient_name = name;
        }
        public Convinience(Convinience convinient) 
        {
            convinient_id=convinient.Convinient_id.ToString();  
            convinient_name=convinient.Convinient_name.ToString();
        }
        public string Convinient_id {get =>  convinient_id; set => convinient_id = value;}
        public string Convinient_name { get => convinient_name; set => convinient_name = value; } 
    }
    public class Convinience_Room_Type
    {
        private string convinient_id1;
        private string id_room;
        private int convinient_quantity;
        public Convinience_Room_Type(string convinient_name,string id_room, int convinient_quantity)
        {
            this.convinient_id1 = convinient_name;
            this.id_room = id_room;
            this.convinient_quantity = convinient_quantity;
        }
        public string Convinient_id1 { get => convinient_id1; set => convinient_id1 = value; }
        public string Id_room { get => id_room; set => id_room = value; }
        public int Convinient_quantity { get => convinient_quantity; set => convinient_quantity = value; }
    }
}
