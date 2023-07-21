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
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Name)
                .IsRequired()
                .HasColumnType("nvarchar(200)");

            builder.Property(v => v.Document)
                .IsRequired()
                .HasColumnType("nvarchar(11)");

            //Configuração 1 : 1(um para um) => Um Vendedor possui um Endereço:
            builder.HasOne(v => v.Address)// O vendedor possui 1 endereço
                .WithOne(v => v.Vendor);//Este endereço está vinculado a 1 vendedor

            //Configuração 1 : N (um para muitos) => Um Vendedor possui VÁRIAS Vendas:
            builder.HasMany(v => v.Sales)// Um vendedor possui várias vendas
                .WithOne(v => v.Vendor) // Uma venda possui 1 vendedor
                .HasForeignKey(v => v.VendorId)// Informa a chave estrangeira do vendedor (VendorId)
                .HasForeignKey(v => v.VehicleId);// Informa a chave estrangeira do veículo (VehicleId)
        }
    }
}
