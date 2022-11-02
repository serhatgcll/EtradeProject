﻿using EtradeBackend.Application.Repositories;
using EtradeBackend.Domain.Entities.Common;
using EtradeBackend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EtradeBackend.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        EtradeDbContext _etradeDbContext;

        public ReadRepository(EtradeDbContext etradeDbContext)
        {
           _etradeDbContext = etradeDbContext;
        }

        public DbSet<T> Table => _etradeDbContext.Set<T>();   

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
              query=  query.AsNoTracking();
            return query;
        }
        public async Task<T> GetByIdAsync(string id, bool tracking = true   )
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstAsync(data => data.Id == Guid.Parse(id));

        }


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter, bool tracking = true  )
        {
            var query = Table.AsQueryable();
            if(!tracking)
                query= query.AsNoTracking();
            return await query.FirstOrDefaultAsync(filter);

        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter, bool tracking = true    )
        {
           var query= Table.Where(filter);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
       
    }
}
