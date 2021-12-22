using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Domain.Entities;
using OnionArcExample.Persistence.Context;

namespace OnionArcExample.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
