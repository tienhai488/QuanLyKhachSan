namespace HotelManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Numerics;

    public class CancelationStatus
    {
        private BigInteger id;
        private string reason;
        private double fee;
        private DateTime time;
        public BigInteger Id { get => id; private set => id = value; }
        public string Reason { get => reason; set => reason = value; }
        public double Fee { get => fee; set => fee = value; }
        public DateTime Time { get => time; set => time = value; }
        public CancelationStatus(BigInteger id)
        {
            this.id = id;
        }
        public CancelationStatus() { }
    }


    [Table("service")]
    public class Service
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("Name", TypeName = "varchar")]
        private string name;

        [StringLength(50)]
        [Column("Unit", TypeName = "varchar")]
        private string unit;

        [Column("UnitPrice", TypeName = "double")]
        private double unitPrice;

        [Column("ServiceTypeId", TypeName = "varchar")]
        private string serviceTypeId;

        [ForeignKey("ServiceTypeId")]
        private ServiceType serviceType;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string ServiceTypeId { get => serviceTypeId; set => serviceTypeId = value; }
        public ServiceType ServiceType { get => serviceType; set => serviceType = value; }
        public Service() { }
    }

    [Table("service_type")]
    public class ServiceType
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("Name", TypeName = "varchar")]
        private string name;

        private IList<Service> services;
        public string Id { get => id; set => id = value; }
        public string Name { get { return name; } set { name = value; } }
        public IList<Service> Services
        {
            get
            {
                var r = services;
                if (r is null) services = r = new List<Service>();
                return r;
            }
        }
        public ServiceType(string id)
        {
            this.id = id;
        }
        public ServiceType() { }
    }
}
