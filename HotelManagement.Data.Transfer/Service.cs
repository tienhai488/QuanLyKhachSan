namespace HotelManagement.Data
{
    using System;
    using System.Collections.Generic;
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

    public class Service
    {
        private BigInteger id;
        private BigInteger? typeId;
        private string name;
        private string unit;
        private double unitPrice;
        private ServiceType serviceType;
        public BigInteger Id { get => id; private set => id = value; }
        public BigInteger? TypeId { get => typeId; private set => typeId = value; }
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public ServiceType ServiceType { get => serviceType; set => serviceType = value; }
        public Service(BigInteger id, BigInteger? typeId)
        {
            this.id = id;
            this.typeId = typeId;
        }
        public Service() { }
    }

    public class ServiceType
    {
        private BigInteger id;
        private string name;
        private IList<Service> services;
        public BigInteger Id { get => id; private set => id = value; }
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
        public ServiceType(BigInteger id)
        {
            this.id = id;
        }
        public ServiceType() { }
    }
}
