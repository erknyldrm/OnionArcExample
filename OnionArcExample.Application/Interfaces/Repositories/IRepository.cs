using OnionArcExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new ()
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
