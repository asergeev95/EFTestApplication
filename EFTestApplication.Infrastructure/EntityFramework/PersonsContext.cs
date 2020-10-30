using Microsoft.EntityFrameworkCore;

namespace EFTestApplication.Infrastructure.EntityFramework
{
    public class PersonsContext : DbContext
    {
        public const string DefaultSchemaName = "Products";
        public PersonsContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema(DefaultSchemaName);
        }
    }
}