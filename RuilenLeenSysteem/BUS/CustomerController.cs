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

        internal Customer GetCustomersById(int Id)
        {
            Customer ReturnCustomer = new Customer();
            if (_DbData.ExistCustomerById(Id))
            {
                ReturnCustomer = _DbData.GetCustomersById(Id);
            }

            return ReturnCustomer;
            
        }

        internal Customer GetReadCustomersById(int Id)
        {
            Customer ReturnCustomer = new Customer();
            OrderData DBOrderData = new OrderData();
            if (_DbData.ExistCustomerById(Id))
            {
                ReturnCustomer = _DbData.GetCustomersById(Id);
                ReturnCustomer.AllBorrowOrders = DBOrderData.GetAllBorrowOrdersByCustomerId(Id);
                ReturnCustomer.AllTradeOrders = DBOrderData.GetAllBTradeOrdersByCustomerId(Id);
            }

            return ReturnCustomer;

        }

        internal bool AddCustomer(string FirstName, string LastName, string Address, string Email, int PhoneNumber)
        {
            bool created = false;
            if (!_DbData.ExistCustomerByEmail(Email))
            {
                Customer AddCustomer = new Customer()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Adress = Address,
                    Email = Email,
                    PhoneNumber = PhoneNumber
                };
                _DbData.AddCustomer(AddCustomer);
                created = true;
            }

            return created;
            
        }

        internal bool EditCustomer(int Id,string FirstName, string LastName, string Address, string Email, int PhoneNumber)
        {
            bool created = false;
            if (_DbData.ExistCustomerById(Id))
            {
                Customer EditCustomer = new Customer()
                {
                    Id = Id,
                    FirstName = FirstName,
                    LastName = LastName,
                    Adress = Address,
                    Email = Email,
                    PhoneNumber = PhoneNumber
                };
                _DbData.EditCustomer(EditCustomer);
                created = true;
            }

            return created;
        }

        internal bool DeleteCustomer(int Id)
        {
            bool Deleted = false;
            if (_DbData.ExistCustomerById(Id))
            {
                _DbData.DeleteCustomer(Id);
                Deleted = true;
            }

            return Deleted;
        }
    
    }
}
