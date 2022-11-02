using EtradeBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeBackend.Application.Repositories
{
    public interface IOrderReadRepository :IReadRepository<Order>
    {
    }
}
