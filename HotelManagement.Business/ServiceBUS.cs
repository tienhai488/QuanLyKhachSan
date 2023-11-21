using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.Ultils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class ServiceBUS
    {
        private ServiceDAO serviceDAO = new ServiceDAO();

        public List<Service> getAllService()
        {
            return serviceDAO.getAllService();
        }
        public int addService(Service service)
        {
            return serviceDAO.addService(service);
        }

        public int updateService(Service service)
        {
            return serviceDAO.updateService(service);
        }

        public int deleteService(string id)
        {
            return serviceDAO.deleteService(id);
        }
        public int getLengthService()
        {
            return serviceDAO.getLengthService();
        }
        public List<ServiceType> getAllType()
        {
            return serviceDAO.getAllType();
        }
        public int addType(ServiceType serviceType)
        {
            return serviceDAO.addType(serviceType); 
        }

        public int updateType(ServiceType serviceType)
        {
            return serviceDAO.updateType(serviceType);
        }

        public int deleteType(string id)
        {
            return serviceDAO.deleteType(id);
        }

        public int getLengthType()
        {
            return serviceDAO.getLengthType();
        }

        public bool validateEmptyService(string name, string unit, string unitPrice)
        {
            StringBuilder sb = new StringBuilder();
            if (name.Length == 0)
            {
                sb.Append("Tên dịch vụ không được để trống!\n");
            }
            if (unitPrice.Length == 0)
            {
                sb.Append("Giá dịch vụ không được để trống!\n");
            }
            if (unit.Length == 0)
            {
                sb.Append("Đơn vị dịch vụ không được để trống!\n");
            }
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

        public bool validateService(string name, string unit, string unitPrice)
        {
            if (!validateEmptyService(name, unit, unitPrice))
            {
                return false;
            }

            StringBuilder sb = new StringBuilder();
            if (!ValidationCustom.checkDouble(unitPrice))
            {
                sb.Append("Giá dịch vụ không hợp lệ! Vui lòng nhập lại.");
            }
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

        public bool validateEmptyType(ServiceType serviceType)
        {
            StringBuilder sb = new StringBuilder();
            if (serviceType.Name.Length == 0)
            {
                sb.Append("Tên loại dịch vụ không được để trống!\n");
            }
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

        public bool validateType(ServiceType serviceType)
        {
            if (!validateEmptyType(serviceType))
            {
                return false;
            }
            return true;
        }

        public int getLengServiceForType(string type_id)
        {
            return serviceDAO.getLengServiceForType(type_id);
        }
    }
}
