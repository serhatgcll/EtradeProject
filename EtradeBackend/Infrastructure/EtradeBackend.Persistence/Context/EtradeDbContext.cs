using EtradeBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeBackend.Persistence.Context
{
    public class EtradeDbContext:DbContext
    {
        public EtradeDbContext(DbContextOptions options) : base(options)
        { }
          public virtual  DbSet<Product> Products { get; set; }
          public virtual     DbSet<Order> Orders { get; set; }
          public virtual DbSet<Customer> Customers { get; set; }


    }
}
