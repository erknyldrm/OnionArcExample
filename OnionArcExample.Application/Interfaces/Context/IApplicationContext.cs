using Microsoft.EntityFrameworkCore;
using OnionArcExample.Domain.Entities;

namespace OnionArcExample.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
    }
}
