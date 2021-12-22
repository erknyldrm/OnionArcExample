﻿using Microsoft.EntityFrameworkCore;
using OnionArcExample.Application.Interfaces.Context;
using OnionArcExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
              new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Product 1 Description", Price = 1000, Stock = 10 },
              new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Product 2 Description", Price = 2000, Stock = 20 },
              new Product { Id = Guid.NewGuid(), Name = "Product 3", Description = "Product 3 Description", Price = 3000, Stock = 30 },
              new Product { Id = Guid.NewGuid(), Name = "Product 4", Description = "Product 4 Description", Price = 4000, Stock = 40 }
              );
        }
    }
}
