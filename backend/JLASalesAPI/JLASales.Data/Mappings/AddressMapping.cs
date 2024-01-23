using JLASales.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JLASales.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {

            builder.ToTable("Addresses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StreetName)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.AdditionalInfo)
               .IsRequired()
               .HasColumnType("text");
            builder.Property(x => x.Number)
               .IsRequired()
               .HasColumnType("text");
            builder.Property(x => x.ZipCode)
               .IsRequired()
               .HasColumnType("text");
            builder.Property(x => x.Neighbourhood)
               .IsRequired()
               .HasColumnType("text");
            builder.Property(x => x.City)
               .IsRequired()
               .HasColumnType("text");
            builder.Property(x => x.State)
               .IsRequired()
               .HasColumnType("text");

        }
    }
}
