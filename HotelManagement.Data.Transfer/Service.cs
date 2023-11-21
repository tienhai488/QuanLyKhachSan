using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    public class Service
    {
        private string id;
        private string name;
        private double unit_price;
        private string unit;
        private string service_type_id;
        private string service_type_name;

        public Service()
        {
            id = name = unit = service_type_id = service_type_name = "";
            unit_price = 0d;   
        }

        public Service(string id, string name, double unit_price, string unit, string service_type_id, string service_type_name)
        {
            Id = id;
            Name = name;
            Unit_price = unit_price;
            Unit = unit;
            Service_type_id = service_type_id;
            Service_type_name = service_type_name;
        }

        public Service(Service service)
        {
            id = service.Id;
            name = service.Name;
            unit = service.Unit;
            unit_price = service.Unit_price;
            service_type_id = service.Service_type_id;
            service_type_name = service.service_type_name;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Unit_price { get => unit_price; set => unit_price = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Service_type_id { get => service_type_id; set => service_type_id = value; }
        public string Service_type_name { get => service_type_name; set => service_type_name = value; }
    }

    public class ServiceType
    {
        private string id;
        private string name;

        public ServiceType()
        {
            id = name = "";
        }

        public ServiceType(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public ServiceType(ServiceType o)
        {
            id = o.Id;  
            Name = o.Name;  
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
