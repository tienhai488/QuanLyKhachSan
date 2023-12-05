using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Ultils;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace HotelManagement.BUS
{
    public class ServiceBUS
    {
        private ServiceDAO serviceDAO = new ServiceDAO();
        private ServiceTypeDAO serviceTypeDAO = new ServiceTypeDAO();

        public List<Service> getAllService()
        {
            return serviceDAO.Services.Include(s => s.ServiceType).AsNoTracking().ToList();
        }

        public Service getServiceById(string id)
        {
            return getAllService().First(item => item.Id.Equals(id));
        }
        public int addService(Service service)
        {
            serviceDAO.Services.Add(service);
            return serviceDAO.SaveChanges();
        }

        public int updateService(Service service)
        {
            serviceDAO.Entry(service).State = EntityState.Detached;
            serviceDAO.Services.Attach(service);
            serviceDAO.Entry(service).State = EntityState.Modified;

            Service temp = serviceDAO.Services.First(item => item.Id.Equals(service.Id));
            temp.Name = service.Name;
            temp.UnitPrice = service.UnitPrice;
            temp.Unit = service.Unit;
            temp.ServiceType = service.ServiceType;

            return serviceDAO.SaveChanges();
        }

        public int deleteService(string id)
        {
            var temp = serviceDAO.Set<Service>().First(item => item.Id.Equals(id));
            serviceDAO.Set<Service>().Remove(temp);
            return serviceDAO.SaveChanges();
        }
        public int getLengthService()
        {
            return serviceDAO.Set<Service>().Count();
        }

        public List<ServiceType> getAllType()
        {
            return serviceTypeDAO.Set<ServiceType>().AsNoTracking().ToList();
        }
        public int addType(ServiceType serviceType)
        {
            var temp = new Service();
            serviceTypeDAO.Set<ServiceType>().Add(serviceType);
            return serviceTypeDAO.SaveChanges();
        }


        public int updateType(ServiceType serviceType)
        {
            var temp = serviceTypeDAO.Set<ServiceType>().First(item => item.Id.Equals(serviceType.Id));
            temp.Name = serviceType.Name;
            return serviceTypeDAO.SaveChanges();
        }

        public int deleteType(string id)
        {
            var temp = serviceTypeDAO.Set<ServiceType>().First(item => item.Id.Equals(id));
            serviceTypeDAO.Set<ServiceType>().Remove(temp);
            return serviceTypeDAO.SaveChanges();
        }

        public int getLengthType()
        {
            return serviceTypeDAO.Set<ServiceType>().Count();
        }

        public int getLengServiceForType(string type_id)
        {
            return serviceDAO.Services.Where(item=>item.ServiceTypeId.Equals(type_id)).Count();
        }

        public ServiceType getServiceTypeById(string type_id)
        {
            return serviceTypeDAO.Set<ServiceType>().First(item => item.Id.Equals(type_id));
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

        public bool validateService(string id, string name, string unit, string unitPrice)
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

            //if (getAllService().Any(item => !item.Equals(id) && item.Name.Equals(name)))
            //{
            //    sb.Append("Tên dịch vụ đã tồn tại!\n");
            //}
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

        public bool validateType(string id, string name)
        {
            StringBuilder sb = new StringBuilder();
            if (!validateEmptyType(name))
            {
                return false;
            }

            //if (getAllType().Any(item => !item.Id.Equals(id) && item.Name.Equals(name)))
            //{
            //    sb.Append("Tên loại dịch vụ đã tồn tại\n");
            //}

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

    }
}
