using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual List<Phone> Phone { get; set; }
        public virtual List<Address> Address { get; set; }
        public int IdCostumer { get; set; }
        public Customer Partner { get; set; }
    }
}
