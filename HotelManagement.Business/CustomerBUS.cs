using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class CustomerBUS
    {
        private CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> getAll()
        {
            return customerDAO.getAll();
        }
        public int add(Customer customer)
        {
            return customerDAO.add(customer);
        }

        public int update(Customer customer)
        {
            return customerDAO.update(customer);
        }

        public int delete(string id)
        {
            return customerDAO.delete(id);
        }
        public int getLength()
        {
            return customerDAO.getLength();
        }

        public bool validateEmpty(Customer customer)
        {
            StringBuilder sb = new StringBuilder();
            if(customer.Fullname.Length == 0)
            {
                sb.Append("Họ tên không được để trống!\n");
            }
            if (customer.CitizenId.Length == 0)
            {
                sb.Append("CCCD không được để trống!\n");
            }
            if (customer.Phone.Length == 0)
            {
                sb.Append("Sdt không được để trống!\n");
            }
            if (customer.Address.Length == 0)
            {
                sb.Append("Địa chỉ không được để trống!\n");
            }
            if(sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

        public bool validate(Customer customer)
        {
            if (!validateEmpty(customer))
            {
                return false;
            }
            return true;
        }
    }
}
