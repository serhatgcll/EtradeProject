using EtradeBackend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeBackend.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EtradeDbContext>
    {
        public EtradeDbContext CreateDbContext(string[] args)
        {


            DbContextOptionsBuilder<EtradeDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<EtradeDbContext>();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);

            return new(dbContextOptionsBuilder.Options);


        }
    }
}
