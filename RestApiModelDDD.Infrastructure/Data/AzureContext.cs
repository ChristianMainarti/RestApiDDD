using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestApiModelDDD.Domain.Entitys;
using System;
using System.Linq;

namespace RestApiModelDDD.Infrastructure.Data
{
    public class AzureContext : DbContext
    {
        public AzureContext() { }

        public AzureContext(DbContextOptions<AzureContext> options) : base(options)
        { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("EntryDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("EntryDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("EntryDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
