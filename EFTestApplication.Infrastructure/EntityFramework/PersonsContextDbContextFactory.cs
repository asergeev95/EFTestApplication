using System;

namespace EFTestApplication.Infrastructure.EntityFramework
{
    public sealed class PersonsContextDbContextFactory
    {
        private readonly string _connectionString;

        public PersonsContextDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PersonsContext GetContext()
        {
            return new PersonsContext(PersonsContextContextDesignTimeFactory.GetSqlServerOptions(_connectionString));
        }
    }
}