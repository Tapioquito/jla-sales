using JLASales.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(s => s.StreetName)
                .IsRequired()
                .HasColumnType("nvarchar(200)");

            builder.Property(s => s.AdditionalInfo)
                .HasColumnType("nvarchar(200)");

            builder.Property(s => s.Number)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.ZipCode)
                .IsRequired()
                .HasColumnType("nvarchar(10)");

            builder.Property(s => s.Neighbourhood)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(s => s.City)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(s => s.State)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.ToTable("Addresses");
        }
    }
}
