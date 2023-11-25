﻿using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Ultils;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace HotelManagement.BUS
{
    public class ServiceBUS
    {
        private ServiceEFCoreDAO serviceEFCoreDAO = new ServiceEFCoreDAO();
        private ServiceTypeEFCoreDAO serviceTypeEFCoreDAO = new ServiceTypeEFCoreDAO();

        public List<Service> getAllService()
        {
            return serviceEFCoreDAO.Services.Include(s => s.ServiceType).AsNoTracking().ToList();
        }

        public Service getServiceById(string id)
        {
            return serviceEFCoreDAO.Set<Service>().First(item => item.Id.Equals(id));
        }
        public int addService(Service service)
        {
            serviceEFCoreDAO.Services.Add(service);
            return serviceEFCoreDAO.SaveChanges();
        }

        public int updateService(Service service)
        {
            serviceEFCoreDAO.Entry(service).State = EntityState.Detached;
            serviceEFCoreDAO.Services.Attach(service);
            serviceEFCoreDAO.Entry(service).State = EntityState.Modified;

            Service temp = serviceEFCoreDAO.Services.First(item => item.Id.Equals(service.Id));
            temp.Name = service.Name;
            temp.UnitPrice = service.UnitPrice;
            temp.Unit = service.Unit;
            temp.ServiceType = service.ServiceType;

            return serviceEFCoreDAO.SaveChanges();
        }

        public int deleteService(string id)
        {
            var temp = serviceEFCoreDAO.Set<Service>().First(item => item.Id.Equals(id));
            serviceEFCoreDAO.Set<Service>().Remove(temp);
            return serviceEFCoreDAO.SaveChanges();
        }
        public int getLengthService()
        {
            return serviceEFCoreDAO.Set<Service>().Count();
        }

        public List<ServiceType> getAllType()
        {
            return serviceTypeEFCoreDAO.Set<ServiceType>().AsNoTracking().ToList();
        }
        public int addType(ServiceType serviceType)
        {
            var temp = new Service();
            serviceTypeEFCoreDAO.Set<ServiceType>().Add(serviceType);
            return serviceTypeEFCoreDAO.SaveChanges();
        }


        public int updateType(ServiceType serviceType)
        {
            var temp = serviceTypeEFCoreDAO.Set<ServiceType>().First(item => item.Id.Equals(serviceType.Id));
            temp.Name = serviceType.Name;
            return serviceTypeEFCoreDAO.SaveChanges();
        }

        public int deleteType(string id)
        {
            var temp = serviceTypeEFCoreDAO.Set<ServiceType>().First(item => item.Id.Equals(id));
            serviceTypeEFCoreDAO.Set<ServiceType>().Remove(temp);
            return serviceTypeEFCoreDAO.SaveChanges();
        }

        public int getLengthType()
        {
            return serviceTypeEFCoreDAO.Set<ServiceType>().Count();
        }

        public int getLengServiceForType(string type_id)
        {
            return serviceEFCoreDAO.Services.Where(item=>item.ServiceTypeId.Equals(type_id)).Count();
        }

        public ServiceType getServiceTypeById(string type_id)
        {
            return serviceTypeEFCoreDAO.Set<ServiceType>().First(item => item.Id.Equals(type_id));
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

        public bool validateEmptyType(string name)
        {
            StringBuilder sb = new StringBuilder();
            if (name.Length == 0)
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

        public bool validateType(string name)
        {
            if (!validateEmptyType(name))
            {
                return false;
            }
            return true;
        }

    }
}
