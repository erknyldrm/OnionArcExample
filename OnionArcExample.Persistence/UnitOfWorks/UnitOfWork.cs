using Microsoft.EntityFrameworkCore.Storage;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Application.Interfaces.UnitOfWork;
using OnionArcExample.Persistence.Context;
using System;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IProductRepository ProductRepository { get; }

        public UnitOfWork(ApplicationDbContext context, IProductRepository productRepository)
        {
            _context = context;
            ProductRepository = productRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();


        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
