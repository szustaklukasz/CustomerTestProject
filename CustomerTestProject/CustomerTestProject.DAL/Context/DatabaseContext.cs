using CustomerTestProject.DAL.Entity;
using CustomerTestProject.DAL.EntityMap;
using Microsoft.EntityFrameworkCore;

namespace CustomerTestProject.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CustomerEntity> Customers { get; private set; }
        public DbSet<AddressEntity> Addresses { get; private set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { 
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerEntity>()
             .HasOne(p => p.Address)
             .WithOne(b => b.Customer)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CustomerEntity>().Map();
            modelBuilder.Entity<AddressEntity>().Map();
        }
    }
}
