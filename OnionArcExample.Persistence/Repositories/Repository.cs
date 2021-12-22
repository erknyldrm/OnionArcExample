using Microsoft.EntityFrameworkCore;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Domain.Common;
using OnionArcExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new ()
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context) => _context = context;

        private DbSet<T> Table { get => _context.Set<T>(); }

        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<List<T>> GetAsync() => await Table.ToListAsync();
        public async Task<T> GetByIdAsync(Guid id) => await Table.FindAsync(id);
    }
}
