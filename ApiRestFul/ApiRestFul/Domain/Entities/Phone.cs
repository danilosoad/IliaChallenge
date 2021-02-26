using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestFul.Domain.Entities
{
    public class Phone : BaseDomain
    {
        public string CustomerPhone { get; set; }
        public int Type { get; set; }
        public int IdCustomer { get; set; }
        public Customer Customer { get; set; }
    }
}
