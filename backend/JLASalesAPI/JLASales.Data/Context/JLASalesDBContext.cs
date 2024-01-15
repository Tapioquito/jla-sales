using JLASales.Business.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace JLASales.Data.Context
{
    public class JLASalesDBContext : IdentityDbContext
    {
        public JLASalesDBContext(DbContextOptions<JLASalesDBContext> options) : base(options)
        {
            //Algumas configurações:
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //Não rastrear as entidades, para não ficar carregando na memória
            ChangeTracker.AutoDetectChangesEnabled = false;
            //Não detectar mudanças, para não ficar carregando na memória
        }
        //Mapear entidades de negócios:

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetProperties()
               .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100");
            }
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JLASalesDBContext).Assembly);
            //toda vez que o projeto for inicializado ele vai pegar todos os tipos 

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
                //Impede que haja deleção em cascata em objetos relacionais
            }

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("RegisterDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("RegisterDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("RegisterDate").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
