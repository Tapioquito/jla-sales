using JLASales.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JLASales.Data.Mappings
{
    public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ModelName)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.MotorPower)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.Document)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.ReleaseYear)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.Manufacturer)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.LicensePlate)
                .IsRequired()
                .HasColumnType("text");
            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("money");

        }
    }
}
