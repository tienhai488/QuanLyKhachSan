using HotelManagement.Data;
using HotelManagement.Data.Access;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace HotelManagement.BUS
{
    public class CustomerBUS
    {
        private CustomerEFCoreDAO customerEFCoreDAO = new CustomerEFCoreDAO();

        public List<Customer> getAll()
        {
            return customerEFCoreDAO.Customers.AsNoTracking().ToList();
        }
        public int add(Customer customer)
        {
            customerEFCoreDAO.Customers.Add(customer);
            return customerEFCoreDAO.SaveChanges();
        }

        public int update(Customer customer)
        {
            customerEFCoreDAO.Entry(customer).State = EntityState.Detached;
            customerEFCoreDAO.Customers.Attach(customer);
            customerEFCoreDAO.Entry(customer).State = EntityState.Modified;

            Customer temp = customerEFCoreDAO.Customers.First(item => item.Id.Equals(customer.Id));
            temp.FullName = customer.FullName;
            temp.Gender = customer.Gender;
            temp.Birthday = customer.Birthday;
            temp.CitizenID = customer.CitizenID;
            temp.PhoneNumber = customer.PhoneNumber;
            temp.Address = customer.Address;
            
            return customerEFCoreDAO.SaveChanges(); 
        }

        public int delete(string id)
        {
            Customer temp = customerEFCoreDAO.Customers.First(item => item.Id.Equals(id));
            customerEFCoreDAO.Customers.Remove(temp);

            return customerEFCoreDAO.SaveChanges();
        }
        public int getLength()
        {
            return getAll().Count();
        }

        public bool validateEmpty(Customer customer)
        {
            StringBuilder sb = new StringBuilder();
            if(customer.FullName.Length == 0)
            {
                sb.Append("Họ tên không được để trống!\n");
            }
            if (customer.CitizenID.Length == 0)
            {
                sb.Append("CCCD không được để trống!\n");
            }
            if (customer.PhoneNumber.Length == 0)
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
