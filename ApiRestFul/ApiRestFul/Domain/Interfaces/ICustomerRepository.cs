using ApiRestFul.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCostumerByEmail(string email);
        IEnumerable<Customer> GetCustomers();
        void Add(Customer customer);
        void Edit(Customer customer);
        void Delete(Customer customer);
    }
}
