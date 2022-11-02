using EtradeBackend.Domain.Entities;
using EtradeBackend.Domain.Entities.Common;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           var datas=  ChangeTracker.Entries<BaseEntity>();
            foreach (var item in datas)
            {
                 _ = item.State switch
                {
                  EntityState.Added=>item.Entity.CreatedDate=DateTime.UtcNow ,
                  EntityState.Modified=>item.Entity.UpdateDate=DateTime.UtcNow ,    
                };
            }

            return await base.SaveChangesAsync(cancellationToken);    
        }


    }
}
