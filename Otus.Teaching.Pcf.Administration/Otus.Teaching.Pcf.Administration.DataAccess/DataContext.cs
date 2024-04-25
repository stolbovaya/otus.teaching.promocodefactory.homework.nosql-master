using Microsoft.EntityFrameworkCore;
using Otus.Teaching.Pcf.Administration.Core.Domain.Administration;
using Otus.Teaching.Pcf.Administration.DataAccess.Data;

namespace Otus.Teaching.Pcf.Administration.DataAccess
{
        public class DataContext : DbContext
        {
            public DbSet<Employee> Employees { get; init; }


            public DbSet<Role> Roles { get; init; }


            public DataContext(DbContextOptions options)
            : base(options)
            {
            }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);


                modelBuilder.Entity<Employee>();
                modelBuilder.Entity<Role>();
            }
        }
    
   
}