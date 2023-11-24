namespace HotelManagement.Data
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    [Table("customer")]
    public class Customer
    {
        public const bool GenderMale = true, GenderFemale = false;

        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("Fullname", TypeName = "varchar")]
        private string fullName;

        [StringLength(10)]
        [Column("Gender", TypeName = "varchar")]
        private string gender;

        [Column("Birthday", TypeName = "date")]
        private DateTime birthday;

        [StringLength(50)]
        [Column("Address", TypeName = "varchar")]
        private string address;

        [StringLength(50)]
        [Column("CitizenID", TypeName = "varchar")]
        private string citizenID;

        [StringLength(50)]
        [Column("PhoneNumber", TypeName = "varchar")]
        private string phone;

        public string Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string GenderString { get => gender.Equals("0") ? "Nữ" : "Nam"; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public string CitizenID { get => citizenID; set => citizenID = value; }
        public string PhoneNumber { get => phone; set => phone = value; }

        public Customer()
        {
            Id = FullName = Gender = Address = CitizenID = PhoneNumber = "";
            Birthday = DateTime.Now;
        }

        public Customer(string id, string fullname, string gender, DateTime birthday, string address, string citizenId, string phone)
        {
            Id = id;
            FullName = fullname;
            Gender = gender;
            Birthday = birthday;
            Address = address;
            CitizenID = citizenId;
            PhoneNumber = phone;
        }

    }
}
