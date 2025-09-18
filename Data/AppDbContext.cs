﻿using Microsoft.EntityFrameworkCore;
using smart_stock.Models;

namespace smart_stock.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }

    }
}
