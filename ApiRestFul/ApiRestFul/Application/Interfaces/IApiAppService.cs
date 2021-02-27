using ApiRestFul.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Application.Interfaces
{
    public interface IApiAppService
    {
        IEnumerable<Customer> GetCustomers();
        dynamic GetCustomersByEmail(string email);
        dynamic GetCustomersById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
