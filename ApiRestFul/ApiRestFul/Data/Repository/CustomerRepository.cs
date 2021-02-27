using ApiRestFul.Data.DataContext;
using ApiRestFul.Domain.Entities;
using ApiRestFul.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataConext _context;

        public CustomerRepository(DataConext context)
        {
            _context = context;
        }
        public Customer GetCostumerByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(x => x.Email.Equals(email));
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.Include(x => x.Phone).ToList();
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public void Edit(Customer customer)
        {
            _context.Customers.Update(customer);
        }

        public Customer GetCostumerById(int id)
        {
            return _context.Customers.AsNoTracking().FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
