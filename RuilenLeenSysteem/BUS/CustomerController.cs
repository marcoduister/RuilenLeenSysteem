using RuilenLeenSysteem.DAL;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.BUS
{
    class CustomerController
    {
        private CustomerData _DbData;
        public CustomerController()
        {
            _DbData = new CustomerData();
        }

        internal List<Customer> GetAllCustomers()
        {
            return _DbData.GetAllCustomers();
        }

        internal Customer GetCustomersById()
        {
            throw new NotImplementedException();
        }

        internal bool AddCustomer(string FirstName, string LastName, string Address, string Email, string PhoneNumber)
        {
            if (!_DbData.ExistCustomerByEmail(Email))
            {
                Customer AddCustomer = new Customer()
                {

                };
            }

            return false;
            
        }
    }
}
