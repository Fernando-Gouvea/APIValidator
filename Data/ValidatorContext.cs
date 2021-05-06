using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using validator.Models;

    public class ValidatorContext : DbContext
    {
        public ValidatorContext (DbContextOptions<ValidatorContext> options)
            : base(options)
        {
        }

        public DbSet<validator.Models.Customer> Customer { get; set; }
    }
