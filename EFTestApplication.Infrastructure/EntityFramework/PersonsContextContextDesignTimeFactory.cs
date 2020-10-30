using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFTestApplication.Infrastructure.EntityFramework
{
    [UsedImplicitly]
    public sealed class PersonsContextContextDesignTimeFactory : IDesignTimeDbContextFactory<PersonsContext>
    {
        private const string DefaultConnectionString =
            "Data Source=127.0.0.1;Initial Catalog=EFTestApplication;User Id=sa; Password=2wsx2WSX;";
        public static DbContextOptions<PersonsContext> GetSqlServerOptions([CanBeNull]string connectionString)
        {
            return new DbContextOptionsBuilder<PersonsContext>()
                .UseSqlServer(connectionString ?? DefaultConnectionString, x =>
                {
                    x.MigrationsHistoryTable("__EFMigrationsHistory", PersonsContext.DefaultSchemaName);
                })
                .Options;
        }
        public PersonsContext CreateDbContext(string[] args)
        {
            return new PersonsContext(GetSqlServerOptions(null));
        }
    }
}
