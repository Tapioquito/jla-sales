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
    public class SaleMapping : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.Id);

            // Configuração 1 para 1 => Venda para Veículo:
            builder.HasOne(s => s.Vehicle);//Uma venda está ligada a um veículo;

            // Configuração 1 para 1 => Venda para Vendedor:
            builder.HasOne(s => s.Vendor);//Uma venda está ligada a um vendedor;

            builder.ToTable("Sales");
        }
    }
}
