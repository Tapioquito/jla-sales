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
    public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.ModelName).
    IsRequired()
    .HasColumnType("nvarchar(200)");


            builder.Property(v => v.MotorPower).
                IsRequired()
                .HasColumnType("nvarchar(100)");


            builder.Property(v => v.Document).
                IsRequired()
                .HasColumnType("nvarchar(11)");


            builder.Property(v => v.ReleaseYear).
                IsRequired()
                .HasColumnType("nvarchar(20)");


            builder.Property(v => v.Manufacturer).
                IsRequired()
                .HasColumnType("nvarchar(200)");


            builder.Property(v => v.LicensePlate).
                IsRequired()
                .HasColumnType("nvarchar(10)");

            /*
            builder.Property(v => v.Price).
                IsRequired()
                .HasColumnType("nvarchar(200)");
            */

            builder.ToTable("Vehicles");
        }
    }
}
