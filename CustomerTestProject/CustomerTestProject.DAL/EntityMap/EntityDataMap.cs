using CustomerTestProject.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerTestProject.DAL.EntityMap
{
    public static class EntityDataMap
    {
        public static void Map(this EntityTypeBuilder<CustomerEntity> entityBuilder)
        {
            entityBuilder.ToTable("Customers");
            entityBuilder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            entityBuilder.Property(x => x.Symbol).HasMaxLength(30).IsRequired();
            entityBuilder.Property(x => x.NIP).HasMaxLength(10).IsRequired();
            entityBuilder.Property(x => x.PhoneNumber).HasMaxLength(15);
            entityBuilder.Property(x => x.Regon).HasMaxLength(9);
        }

        public static void Map(this EntityTypeBuilder<AddressEntity> entityBuilder)
        {
            entityBuilder.ToTable("Addresses");
            entityBuilder.Property(x => x.City).HasMaxLength(30).IsRequired();
            entityBuilder.Property(x => x.Country).HasMaxLength(30).IsRequired();
            entityBuilder.Property(x => x.Street).HasMaxLength(30).IsRequired();
            entityBuilder.Property(x => x.HouseNumber).HasMaxLength(10);
            entityBuilder.Property(x => x.LocalNumber).HasMaxLength(10);
        }
    }
}
