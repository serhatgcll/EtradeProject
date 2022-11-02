using EtradeBackend.Application.Repositories;
using EtradeBackend.Domain.Entities;
using EtradeBackend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeBackend.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(EtradeDbContext etradeDbContext) : base(etradeDbContext)
        {
        }
    }
}
