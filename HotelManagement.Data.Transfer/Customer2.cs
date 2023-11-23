using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    public class Customer2
    {
        private string id;
        private string fullname;
        private int gender;
        private string birthday;
        private string address;
        private string citizenId;
        private string phone;

        public Customer2()
        {
            id = fullname = birthday = address = citizenId = phone = "";
            gender = 0;
        }

        public Customer2(string id, string fullname, int gender, string birthday, string address, string citizenId, string phone)
        {
            Id = id;
            Fullname = fullname;    
            Gender = gender;
            Birthday = birthday;
            Address = address;
            CitizenId = citizenId;
            Phone = phone;
        }

        public Customer2(Customer2 customer)
        {
            Id = customer.Id;
            Fullname = customer.Fullname;
            Gender = customer.Gender;
            Birthday = customer.Birthday;
            Address = customer.Address;
            CitizenId = customer.CitizenId;
            Phone = customer.Phone;
        }

        public string Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public string CitizenId { get => citizenId; set => citizenId = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Gender { get => gender; set => gender = value; }
    }
}
