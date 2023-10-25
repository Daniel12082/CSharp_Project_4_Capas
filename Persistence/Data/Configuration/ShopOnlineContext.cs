using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Configuration
{
    public class ShopOnlineContext : DbContext
    {
        public ShopOnlineContext(DbContextOptions options) : base(options) { }
        public DbSet<Rol> Roles;
        public DbSet<User> Users;
        public DbSet<UserRol> UserRols;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}