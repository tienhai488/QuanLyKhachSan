namespace HotelManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public const bool GenderMale = true, GenderFemale = false;

        private readonly BigInteger id;
        private string fullName, address, citizenID, phone;
        private bool gender;
        private DateOnly birthday;
        public BigInteger Id => id;
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string CitizenId { get => citizenID; set => citizenID = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string GenderString { get => gender == GenderMale ? "Male" : "Female"; }
        public DateOnly Birthday { get => birthday; set => birthday = value; }
        public Customer(BigInteger id)
        {
            this.id = id;
        }

        public Customer() { }
    }
}
