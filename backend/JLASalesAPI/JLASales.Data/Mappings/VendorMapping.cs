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
    public class VendorMapping : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendors");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.Document)
                .IsRequired()
                .HasColumnType("text");

            //Relations:
            //1 : 1 => Supplier : Address
            builder.HasOne(x => x.Address)
                .WithOne(x => x.Vendor);

            //1: N => Supplier : Products
            builder.HasMany(x => x.Sales)
                .WithOne(x => x.Vendor)
                .HasForeignKey(x => x.VendorId);


        }
    }
}
