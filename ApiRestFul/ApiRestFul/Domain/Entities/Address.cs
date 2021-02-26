using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Domain.Entities
{
    public class Address : BaseDomain
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
