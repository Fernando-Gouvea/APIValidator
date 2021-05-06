using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace validator.Models
{
    public class Customer : User
    {
        public string CPF { get; set; }
        public Address Address { get; set; }
    }
}
